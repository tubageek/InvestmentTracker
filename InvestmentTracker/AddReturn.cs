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
    public partial class AddReturn : Form
    {
        public AddReturn()
        {
            InitializeComponent();

            using (InvestmentEntities entities = new InvestmentEntities())
            {
                ddlInvestment.DataSource = entities.MutualFunds.OrderBy(mf => mf.MutualFundSymbol);
                ddlInvestment.ValueMember = "MutualFundID";
                ddlInvestment.DisplayMember = "DisplayText";

                ddlReturnType.DataSource = entities.MutualFundReturnTypes.OrderBy(rt => rt.MutualFundReturnTypeName);
                ddlReturnType.ValueMember = "MutualFundReturnTypeName";
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
                MutualFundReturn mfReturn = new MutualFundReturn();
                mfReturn.MutualFundID = Convert.ToInt32(ddlInvestment.SelectedValue);
                mfReturn.NumberOfShares = Decimal.Parse(txtNumberOfShares.Text);
                mfReturn.PricePerShare = Decimal.Parse(txtPricePerShare.Text);
                mfReturn.Amount = Decimal.Parse(txtActualAmount.Text);
                mfReturn.TransactionDate = DateTime.Parse(txtTransactionDate.Text);
                mfReturn.MutualFundReturnTypeName = ddlReturnType.SelectedValue.ToString();
                mfReturn.Destination = "Reinvest";

                entities.MutualFundReturns.AddObject(mfReturn);
                entities.SaveChanges();
            }

            MessageBox.Show("This return has been saved");
        }
    }
}
