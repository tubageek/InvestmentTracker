namespace InvestmentTracker
{
    partial class AddReturn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActualAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPricePerShare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfShares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlInvestment = new System.Windows.Forms.ComboBox();
            this.lblActualCheck = new System.Windows.Forms.Label();
            this.ddlReturnType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Transaction Date";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(626, 25);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(200, 20);
            this.txtTransactionDate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Actual Amount";
            // 
            // txtActualAmount
            // 
            this.txtActualAmount.Location = new System.Drawing.Point(492, 26);
            this.txtActualAmount.Name = "txtActualAmount";
            this.txtActualAmount.Size = new System.Drawing.Size(127, 20);
            this.txtActualAmount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price Per Share";
            // 
            // txtPricePerShare
            // 
            this.txtPricePerShare.Location = new System.Drawing.Point(360, 26);
            this.txtPricePerShare.Name = "txtPricePerShare";
            this.txtPricePerShare.Size = new System.Drawing.Size(127, 20);
            this.txtPricePerShare.TabIndex = 15;
            this.txtPricePerShare.TextChanged += new System.EventHandler(this.txtPricePerShare_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of Shares";
            // 
            // txtNumberOfShares
            // 
            this.txtNumberOfShares.Location = new System.Drawing.Point(224, 26);
            this.txtNumberOfShares.Name = "txtNumberOfShares";
            this.txtNumberOfShares.Size = new System.Drawing.Size(127, 20);
            this.txtNumberOfShares.TabIndex = 13;
            this.txtNumberOfShares.TextChanged += new System.EventHandler(this.txtNumberOfShares_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mutual Fund";
            // 
            // ddlInvestment
            // 
            this.ddlInvestment.FormattingEnabled = true;
            this.ddlInvestment.Location = new System.Drawing.Point(12, 25);
            this.ddlInvestment.Name = "ddlInvestment";
            this.ddlInvestment.Size = new System.Drawing.Size(206, 21);
            this.ddlInvestment.TabIndex = 11;
            // 
            // lblActualCheck
            // 
            this.lblActualCheck.AutoSize = true;
            this.lblActualCheck.Location = new System.Drawing.Point(492, 53);
            this.lblActualCheck.Name = "lblActualCheck";
            this.lblActualCheck.Size = new System.Drawing.Size(47, 13);
            this.lblActualCheck.TabIndex = 21;
            this.lblActualCheck.Text = "lblActual";
            // 
            // ddlReturnType
            // 
            this.ddlReturnType.FormattingEnabled = true;
            this.ddlReturnType.Location = new System.Drawing.Point(12, 67);
            this.ddlReturnType.Name = "ddlReturnType";
            this.ddlReturnType.Size = new System.Drawing.Size(206, 21);
            this.ddlReturnType.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Return Type";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(751, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 262);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlReturnType);
            this.Controls.Add(this.lblActualCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTransactionDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtActualAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPricePerShare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfShares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlInvestment);
            this.Name = "AddReturn";
            this.Text = "AddReturn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtTransactionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActualAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPricePerShare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfShares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlInvestment;
        private System.Windows.Forms.Label lblActualCheck;
        private System.Windows.Forms.ComboBox ddlReturnType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
    }
}