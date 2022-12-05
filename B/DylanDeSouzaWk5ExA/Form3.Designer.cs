namespace DylanDeSouzaWk5ExA
{
    partial class Form3
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
            this.lblInvestmentAmount = new System.Windows.Forms.Label();
            this.txtInvestmentAmount = new System.Windows.Forms.TextBox();
            this.lstSimpleInterestEarned = new System.Windows.Forms.ListBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInvestmentAmount
            // 
            this.lblInvestmentAmount.AutoSize = true;
            this.lblInvestmentAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInvestmentAmount.Location = new System.Drawing.Point(191, 105);
            this.lblInvestmentAmount.Name = "lblInvestmentAmount";
            this.lblInvestmentAmount.Size = new System.Drawing.Size(141, 15);
            this.lblInvestmentAmount.TabIndex = 9;
            this.lblInvestmentAmount.Text = "Enter an investment amount";
            // 
            // txtInvestmentAmount
            // 
            this.txtInvestmentAmount.Location = new System.Drawing.Point(348, 100);
            this.txtInvestmentAmount.Name = "txtInvestmentAmount";
            this.txtInvestmentAmount.Size = new System.Drawing.Size(100, 20);
            this.txtInvestmentAmount.TabIndex = 8;
            // 
            // lstSimpleInterestEarned
            // 
            this.lstSimpleInterestEarned.FormattingEnabled = true;
            this.lstSimpleInterestEarned.Location = new System.Drawing.Point(348, 147);
            this.lstSimpleInterestEarned.Name = "lstSimpleInterestEarned";
            this.lstSimpleInterestEarned.Size = new System.Drawing.Size(391, 160);
            this.lstSimpleInterestEarned.TabIndex = 7;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(364, 327);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 6;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(348, 126);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualInterestRate.TabIndex = 10;
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(192, 133);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(142, 15);
            this.lblAnnualInterestRate.TabIndex = 11;
            this.lblAnnualInterestRate.Text = "Enter an annual interest rate";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnnualInterestRate);
            this.Controls.Add(this.txtAnnualInterestRate);
            this.Controls.Add(this.lblInvestmentAmount);
            this.Controls.Add(this.txtInvestmentAmount);
            this.Controls.Add(this.lstSimpleInterestEarned);
            this.Controls.Add(this.btnClick);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvestmentAmount;
        private System.Windows.Forms.TextBox txtInvestmentAmount;
        private System.Windows.Forms.ListBox lstSimpleInterestEarned;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.Label lblAnnualInterestRate;
    }
}