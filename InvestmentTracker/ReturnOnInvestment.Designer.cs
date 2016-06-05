namespace InvestmentTracker
{
    partial class ReturnOnInvestment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InvestmentName = new System.Windows.Forms.Label();
            this.ActualReturn = new System.Windows.Forms.Label();
            this.InvestmentsToDate = new System.Windows.Forms.Label();
            this.DividendsToDate = new System.Windows.Forms.Label();
            this.CurrentValue = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.ReturnLast12 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InvestmentName
            // 
            this.InvestmentName.AutoSize = true;
            this.InvestmentName.Location = new System.Drawing.Point(4, 4);
            this.InvestmentName.Name = "InvestmentName";
            this.InvestmentName.Size = new System.Drawing.Size(35, 13);
            this.InvestmentName.TabIndex = 0;
            this.InvestmentName.Text = "Name";
            this.InvestmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActualReturn
            // 
            this.ActualReturn.AutoSize = true;
            this.ActualReturn.Location = new System.Drawing.Point(758, 4);
            this.ActualReturn.MinimumSize = new System.Drawing.Size(50, 0);
            this.ActualReturn.Name = "ActualReturn";
            this.ActualReturn.Size = new System.Drawing.Size(50, 13);
            this.ActualReturn.TabIndex = 1;
            this.ActualReturn.Text = "Return";
            this.ActualReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InvestmentsToDate
            // 
            this.InvestmentsToDate.AutoSize = true;
            this.InvestmentsToDate.Location = new System.Drawing.Point(287, 4);
            this.InvestmentsToDate.MinimumSize = new System.Drawing.Size(80, 0);
            this.InvestmentsToDate.Name = "InvestmentsToDate";
            this.InvestmentsToDate.Size = new System.Drawing.Size(80, 13);
            this.InvestmentsToDate.TabIndex = 2;
            this.InvestmentsToDate.Text = "ToDate";
            this.InvestmentsToDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DividendsToDate
            // 
            this.DividendsToDate.AutoSize = true;
            this.DividendsToDate.Location = new System.Drawing.Point(411, 4);
            this.DividendsToDate.MinimumSize = new System.Drawing.Size(80, 0);
            this.DividendsToDate.Name = "DividendsToDate";
            this.DividendsToDate.Size = new System.Drawing.Size(80, 13);
            this.DividendsToDate.TabIndex = 3;
            this.DividendsToDate.Text = "Dividends";
            this.DividendsToDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentValue
            // 
            this.CurrentValue.AutoSize = true;
            this.CurrentValue.Location = new System.Drawing.Point(523, 4);
            this.CurrentValue.MinimumSize = new System.Drawing.Size(80, 0);
            this.CurrentValue.Name = "CurrentValue";
            this.CurrentValue.Size = new System.Drawing.Size(80, 13);
            this.CurrentValue.TabIndex = 4;
            this.CurrentValue.Text = "Current";
            this.CurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(88, 4);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(35, 13);
            this.Description.TabIndex = 5;
            this.Description.Text = "label1";
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReturnLast12
            // 
            this.ReturnLast12.AutoSize = true;
            this.ReturnLast12.Location = new System.Drawing.Point(825, 4);
            this.ReturnLast12.MinimumSize = new System.Drawing.Size(77, 13);
            this.ReturnLast12.Name = "ReturnLast12";
            this.ReturnLast12.Size = new System.Drawing.Size(77, 13);
            this.ReturnLast12.TabIndex = 6;
            this.ReturnLast12.Text = "Return Last 12";
            this.ReturnLast12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(640, 4);
            this.StartDate.MinimumSize = new System.Drawing.Size(77, 13);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(77, 13);
            this.StartDate.TabIndex = 7;
            this.StartDate.Text = "Since";
            this.StartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReturnOnInvestment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.ReturnLast12);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.CurrentValue);
            this.Controls.Add(this.DividendsToDate);
            this.Controls.Add(this.InvestmentsToDate);
            this.Controls.Add(this.ActualReturn);
            this.Controls.Add(this.InvestmentName);
            this.Name = "ReturnOnInvestment";
            this.Size = new System.Drawing.Size(905, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvestmentName;
        private System.Windows.Forms.Label ActualReturn;
        private System.Windows.Forms.Label InvestmentsToDate;
        private System.Windows.Forms.Label DividendsToDate;
        private System.Windows.Forms.Label CurrentValue;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label ReturnLast12;
        private System.Windows.Forms.Label StartDate;
    }
}
