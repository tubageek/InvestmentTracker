namespace InvestmentTracker
{
    partial class AddInvestment
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
            this.ddlInvestment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfShares = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPricePerShare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActualAmount = new System.Windows.Forms.TextBox();
            this.lblActualCheck = new System.Windows.Forms.Label();
            this.txtTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ddlInvestment
            // 
            this.ddlInvestment.FormattingEnabled = true;
            this.ddlInvestment.Location = new System.Drawing.Point(12, 39);
            this.ddlInvestment.Name = "ddlInvestment";
            this.ddlInvestment.Size = new System.Drawing.Size(206, 21);
            this.ddlInvestment.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mutual Fund";
            // 
            // txtNumberOfShares
            // 
            this.txtNumberOfShares.Location = new System.Drawing.Point(224, 40);
            this.txtNumberOfShares.Name = "txtNumberOfShares";
            this.txtNumberOfShares.Size = new System.Drawing.Size(127, 20);
            this.txtNumberOfShares.TabIndex = 2;
            this.txtNumberOfShares.TextChanged += new System.EventHandler(this.txtNumberOfShares_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Shares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price Per Share";
            // 
            // txtPricePerShare
            // 
            this.txtPricePerShare.Location = new System.Drawing.Point(360, 40);
            this.txtPricePerShare.Name = "txtPricePerShare";
            this.txtPricePerShare.Size = new System.Drawing.Size(127, 20);
            this.txtPricePerShare.TabIndex = 4;
            this.txtPricePerShare.TextChanged += new System.EventHandler(this.txtPricePerShare_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Actual Amount";
            // 
            // txtActualAmount
            // 
            this.txtActualAmount.Location = new System.Drawing.Point(492, 40);
            this.txtActualAmount.Name = "txtActualAmount";
            this.txtActualAmount.Size = new System.Drawing.Size(127, 20);
            this.txtActualAmount.TabIndex = 6;
            // 
            // lblActualCheck
            // 
            this.lblActualCheck.AutoSize = true;
            this.lblActualCheck.Location = new System.Drawing.Point(492, 67);
            this.lblActualCheck.Name = "lblActualCheck";
            this.lblActualCheck.Size = new System.Drawing.Size(0, 13);
            this.lblActualCheck.TabIndex = 8;
            this.lblActualCheck.Text = "lblActual";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(626, 39);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(200, 20);
            this.txtTransactionDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transaction Date";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(751, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(48, 63);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(439, 20);
            this.txtNote.TabIndex = 13;
            // 
            // AddInvestment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 262);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTransactionDate);
            this.Controls.Add(this.lblActualCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtActualAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPricePerShare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfShares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlInvestment);
            this.Name = "AddInvestment";
            this.Text = "AddInvestment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlInvestment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfShares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPricePerShare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActualAmount;
        private System.Windows.Forms.Label lblActualCheck;
        private System.Windows.Forms.DateTimePicker txtTransactionDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
    }
}