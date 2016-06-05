using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace InvestmentTracker
{
    public class MutualFundCalculator
    {
        //private List<MutualFundView> AllTransactions;
        public Decimal CurrentValue { get; set; }
        public Decimal Investments { get; set; }
        public Decimal Gains { get; set; }
        public Decimal ROI { get; set; }
        public Decimal ROILast12 { get; set; }
        public String FundName { get; set; }
        private GoogleResults ValueToday { get; set; }
        public Dictionary<DateTime, Double> TransactionsLast12 = new Dictionary<DateTime, double>();
        public Boolean Last12Valid { get; set; }
        public String ROILast12_Display
        {
            get
            {
                if (Last12Valid)
                    return ROILast12.ToString("p");
                else
                    return "---";
            }
        }
        public DateTime FirstPurchase { get; set; }

        public MutualFundCalculator(String fundName, List<MutualFundView> transactions, Boolean isOpenFund, DateTime last12Start, InvestmentEntities entities)
        {
            FundName = fundName;

            if (ValueToday == null && isOpenFund)
            {
                var mutualFund = entities.MutualFunds.Single(mf => mf.MutualFundSymbol == fundName);

                if (mutualFund.IsGoogleTracked)
                {
                    //http://ichart.yahoo.com/table.csv?s=FSDIX&a=2&b=1&c=2013&d=2&e=1&f=2014&g=d&ignore=.csv a=Month-1, b=day, c=year (d, e, f = m,d,y end date)
                    String url = "http://finance.google.com/finance/info?client=ig&q=" + fundName;
                    WebRequest request = WebRequest.Create(url);
                    WebResponse response = request.GetResponse();
                    String responseString = "";
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader answer = new StreamReader(stream))
                        {
                            responseString = answer.ReadToEnd();
                        }
                    }

                    ValueToday = JSONHelper.Deserialise<GoogleResults>(responseString);
                }
                else
                {
                    GoogleResults r = new GoogleResults();
                    r.l = mutualFund.LastKnownValue.ToString();
                    ValueToday = r;
                }
            }

            Decimal todaysValue = !isOpenFund ? transactions.OrderByDescending(t => t.TransactionDate).First().PricePerShare : Decimal.Parse(ValueToday.l);
            CurrentValue = todaysValue * transactions.Sum(i => i.NumberOfShares);
            Investments = transactions.Where(i => i.ReturnType == "Investment").Sum(i => i.Amount);
            Gains = transactions.Where(i => i.ReturnType != "Investment").Sum(i => i.Amount);
            FirstPurchase = transactions.OrderBy(i => i.TransactionDate).First().TransactionDate;
            
            Dictionary<DateTime, Double> allTransactions = new Dictionary<DateTime,double>();

            foreach (MutualFundView fund in transactions)
            {
                if (fund.ReturnType == "Investment")
                {
                    allTransactions.Add(fund.TransactionDate, Convert.ToDouble(fund.Amount));
                    if (fund.TransactionDate > last12Start)
                        TransactionsLast12.Add(fund.TransactionDate, Convert.ToDouble(fund.Amount));
                }
            }

            try
            {
                ROI = Convert.ToDecimal(Calculations.IRR.solveIRR(allTransactions, Convert.ToDouble(CurrentValue), 1, 1000, DateTime.Now));

                if (allTransactions.Count == TransactionsLast12.Count)
                {
                    ROILast12 = ROI;
                    Last12Valid = true;
                }
                else
                {
                    MutualFundPriceHistory historicalPrice = entities.MutualFundPriceHistories.SingleOrDefault(h => h.MutualFundSymbol == fundName && h.QuoteDate == last12Start);
                    if (historicalPrice != null)
                    {
                        Decimal numberOfSharesYearAgo = transactions.Sum(i => i.NumberOfShares) - transactions.Where(i => i.TransactionDate > last12Start).Sum(i => i.NumberOfShares);
                        TransactionsLast12.Add(last12Start, Convert.ToDouble(numberOfSharesYearAgo * historicalPrice.DayPrice));
                        ROILast12 = Convert.ToDecimal(Calculations.IRR.solveIRR(TransactionsLast12, Convert.ToDouble(CurrentValue), 1, 1000, DateTime.Now));
                        Last12Valid = true;
                    }
                    else
                    {
                        ROILast12 = 0;
                        Last12Valid = false;
                    }
                }
            }
            catch
            {
                //ROI = -1;
                //ROILast12 = -1;
            }
        }

        private class JSONHelper
        {
            public static T Deserialise<T>(string json)
            {
                string fixedJSON = json.Replace("//", "").Replace("\n", "").Replace("[", "").Replace("]", "");
                T obj = Activator.CreateInstance<T>();
                using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(fixedJSON)))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                    obj = (T)serializer.ReadObject(ms); 
                    return obj;
                }
            }
        }

        //[ { "id": "16511456" ,"t" : "OAKWX" ,"e" : "MUTF" ,"l" : "10.20" ,"l_cur" : "$10.20" ,"s": "0" ,"ltt":"4:00PM EDT" ,"lt" : "Oct 7, 4:00PM EDT" ,"c" : "-0.03" ,"cp" : "-0.29" ,"ccol" : "chr" } ]
        [DataContract]
        private class GoogleResults
        {
            [DataMember]
            public String id { get; set; }

            [DataMember]
            public String l { get; set; }

            [DataMember]
            public String c { get; set; }

            [DataMember]
            public String cp { get; set; }
        }
    }
}
