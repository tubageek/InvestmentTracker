using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace InvestmentTracker
{
    public partial class Form1 : Form
    {
        public Decimal CurrentValue { get; set; }
        public Decimal CurrentValue_ForLast12Calc { get; set; }
        public Decimal ValueLast12 { get; set; }
        public Decimal Investments { get; set; }
        public Decimal Gains { get; set; }
        public Decimal ROI { get; set; }
        List<ReturnOnInvestment> returns = new List<ReturnOnInvestment>();
        Dictionary<DateTime, Double> allTransactions = new Dictionary<DateTime, double>();
        Dictionary<DateTime, Double> transactionsLast12 = new Dictionary<DateTime, double>();
        Int32 counter = 0;

        public Form1()
        {
            InitializeComponent();

            using (InvestmentEntities entities = new InvestmentEntities())
            {
                var allInvestments = entities.MutualFundViews.Where(m => m.MutualFundID > 0).ToList();
                var investmentList = allInvestments.Select(i => i.MutualFundSymbol).Distinct().ToList();

                ReturnOnInvestment header = new ReturnOnInvestment("Fund Name", "Description", "Investments", "Dividends", "Current Value", "APY", "Yield L12", "Since");
                flowLayoutPanel1.Controls.Add(header);
                CurrentValue = 0.0M;
                CurrentValue_ForLast12Calc = 0.0M;

                DateTime last12Start = entities.GetLast12StartDate().First().Value;

                //List<Task> taskList = new List<Task>();

                foreach (String investment in investmentList)
                {
                    GetInvestments(allInvestments.Where(f => f.MutualFundSymbol == investment).ToList(), investment, last12Start, entities);
                    //var task = Task.Factory.StartNew(() => GetInvestments(allInvestments, investment));
                    //taskList.Add(task);
                }

                //Task.WaitAll(taskList.ToArray());

                foreach (var control in returns.OrderBy(r => r.FundName))
                {
                    flowLayoutPanel1.Controls.Add(control);
                }

                Investments = allInvestments.Where(i => i.ReturnType == "Investment").Sum(i => i.Amount);
                Gains = allInvestments.Where(i => i.ReturnType != "Investment").Sum(i => i.Amount);

                ROI = Convert.ToDecimal(Calculations.IRR.solveIRR(allTransactions, Convert.ToDouble(CurrentValue), 1, 1000, DateTime.Now));
                Decimal ROILast12 = Convert.ToDecimal(Calculations.IRR.solveIRR(transactionsLast12, Convert.ToDouble(CurrentValue_ForLast12Calc), 1, 1000, DateTime.Now));

                flowLayoutPanel1.Controls.Add(new ReturnOnInvestment("Totals", "", this.Investments.ToString("c"), this.Gains.ToString("c"), this.CurrentValue.ToString("c"), this.ROI.ToString("p"), ROILast12.ToString("p"), ""));
            }
        }

        private void GetInvestments(List<MutualFundView> allInvestments, String investment, DateTime last12Start, InvestmentEntities entities)
        {
            MutualFundCalculator mutualFund = new MutualFundCalculator(investment, allInvestments.Where(i => i.MutualFundSymbol == investment).ToList(), allInvestments.First(i => i.MutualFundSymbol == investment).HasBalance, last12Start, entities);
            String description = allInvestments.First(i => i.MutualFundSymbol == investment).MutualFundDescription;
            ReturnOnInvestment control = new ReturnOnInvestment(investment, description, mutualFund.Investments.ToString("c"), mutualFund.Gains.ToString("c"), 
                mutualFund.CurrentValue.ToString("c"), mutualFund.ROI.ToString("p"), mutualFund.ROILast12_Display, mutualFund.FirstPurchase.ToString("M/d/yyyy"));

            if (allInvestments.First(i => i.MutualFundSymbol == investment).HasBalance)
                returns.Add(control);

            CurrentValue += mutualFund.CurrentValue;
            if (mutualFund.Last12Valid)
                CurrentValue_ForLast12Calc += mutualFund.CurrentValue;

            foreach (MutualFundView fund in allInvestments)
            {
                if (fund.ReturnType == "Investment")
                {
                    allTransactions.Add(fund.TransactionDate.AddSeconds(counter), Convert.ToDouble(fund.Amount));
                    counter++;
                }
            }

            foreach (var key in mutualFund.TransactionsLast12.Keys)
            {
                if (mutualFund.Last12Valid)
                {
                    transactionsLast12.Add(key.AddSeconds(counter), mutualFund.TransactionsLast12[key]);
                    counter++;
                }
            }
        }

        private void btnAddInvestment_Click(object sender, EventArgs e)
        {
            AddInvestment window = new AddInvestment();
            window.Show();
        }

        private void btnAddReturn_Click(object sender, EventArgs e)
        {
            AddReturn window = new AddReturn();
            window.Show();
        }
    }
}
