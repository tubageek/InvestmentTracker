using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvestmentTracker
{
    public partial class AddInvestment : Form
    {
        public AddInvestment()
        {
            InitializeComponent();

            using (InvestmentEntities entities = new InvestmentEntities())
            {
                ddlInvestment.DataSource = entities.MutualFunds.OrderBy(mf => mf.MutualFundSymbol);
                ddlInvestment.ValueMember = "MutualFundID";
                ddlInvestment.DisplayMember = "DisplayText";
            }

            CalculateActual();
        }

        private void txtNumberOfShares_TextChanged(object sender, EventArgs e)
        {
            CalculateActual();
        }

        private void txtPricePerShare_TextChanged(object sender, EventArgs e)
        {
            CalculateActual();
        }

        private void CalculateActual()
        {
            float numberOfShares = 0f;
            float pricePerShare = 0f;

            if (!float.TryParse(txtNumberOfShares.Text, out numberOfShares))
            {
                lblActualCheck.Text = "N/A";
                return;
            }

            if (!float.TryParse(txtPricePerShare.Text, out pricePerShare))
            {
                lblActualCheck.Text = "N/A";
                return;
            }

            lblActualCheck.Text = Math.Round(numberOfShares * pricePerShare, 2).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (InvestmentEntities entities = new InvestmentEntities())
            {
                MutualFundTransaction transaction = new MutualFundTransaction();
                transaction.MutualFundID = Convert.ToInt32(ddlInvestment.SelectedValue);
                transaction.NumberOfShares = Decimal.Parse(txtNumberOfShares.Text);
                transaction.PricePerShare = Decimal.Parse(txtPricePerShare.Text);
                transaction.ActualAmount = Decimal.Parse(txtActualAmount.Text);
                transaction.TransactionDate = DateTime.Parse(txtTransactionDate.Text);
                transaction.Note = txtNote.Text;

                entities.MutualFundTransactions.AddObject(transaction);
                entities.SaveChanges();
            }

            MessageBox.Show("This transaction has been saved");
        }
    }
}
