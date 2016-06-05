namespace InvestmentTracker
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.btnAddInvestment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 751);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.Location = new System.Drawing.Point(897, 769);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(75, 23);
            this.btnAddReturn.TabIndex = 1;
            this.btnAddReturn.Text = "Add Return";
            this.btnAddReturn.UseVisualStyleBackColor = true;
            this.btnAddReturn.Click += new System.EventHandler(this.btnAddReturn_Click);
            // 
            // btnAddInvestment
            // 
            this.btnAddInvestment.Location = new System.Drawing.Point(789, 769);
            this.btnAddInvestment.Name = "btnAddInvestment";
            this.btnAddInvestment.Size = new System.Drawing.Size(102, 23);
            this.btnAddInvestment.TabIndex = 2;
            this.btnAddInvestment.Text = "Add Investment";
            this.btnAddInvestment.UseVisualStyleBackColor = true;
            this.btnAddInvestment.Click += new System.EventHandler(this.btnAddInvestment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 798);
            this.Controls.Add(this.btnAddInvestment);
            this.Controls.Add(this.btnAddReturn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddReturn;
        private System.Windows.Forms.Button btnAddInvestment;


    }
}

