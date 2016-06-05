using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvestmentTracker
{
    public partial class ReturnOnInvestment : UserControl
    {
        public String FundName
        {
            get { return this.InvestmentName.Text; }
        }

        public ReturnOnInvestment()
        {
            InitializeComponent();
        }

        public ReturnOnInvestment(String FundName, String Description, String InvestmentsToDate, String DividendsToDate, String CurrentValue, String ActualReturn, String ReturnLast12, String FirstPurchase)
        {
            InitializeComponent();
            this.InvestmentName.Text = FundName;
            this.Description.Text = Description;
            this.InvestmentsToDate.Text = InvestmentsToDate;
            this.DividendsToDate.Text = DividendsToDate;
            this.CurrentValue.Text = CurrentValue;
            this.ActualReturn.Text = ActualReturn;
            this.ReturnLast12.Text = ReturnLast12;
            this.StartDate.Text = FirstPurchase;
        }
    }
}
