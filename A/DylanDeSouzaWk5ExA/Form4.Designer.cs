namespace DylanDeSouzaWk5ExA
{
    partial class Form4
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lstDivisibleNumbers = new System.Windows.Forms.ListBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(365, 360);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lstDivisibleNumbers
            // 
            this.lstDivisibleNumbers.FormattingEnabled = true;
            this.lstDivisibleNumbers.Location = new System.Drawing.Point(340, 124);
            this.lstDivisibleNumbers.Name = "lstDivisibleNumbers";
            this.lstDivisibleNumbers.Size = new System.Drawing.Size(206, 225);
            this.lstDivisibleNumbers.TabIndex = 6;
            this.lstDivisibleNumbers.SelectedIndexChanged += new System.EventHandler(this.lstDivisibleNumbers_SelectedIndexChanged);
            // 
            // txtPrompt
            // 
            this.txtPrompt.Location = new System.Drawing.Point(340, 86);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(100, 20);
            this.txtPrompt.TabIndex = 8;
            this.txtPrompt.TextChanged += new System.EventHandler(this.txtPrompt_TextChanged);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrompt.Location = new System.Drawing.Point(255, 93);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(81, 15);
            this.lblPrompt.TabIndex = 9;
            this.lblPrompt.Text = "Enter a number";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lstDivisibleNumbers);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ListBox lstDivisibleNumbers;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Label lblPrompt;
    }
}