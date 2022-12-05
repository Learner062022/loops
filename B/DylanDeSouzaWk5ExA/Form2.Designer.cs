namespace DylanDeSouzaWk5ExA
{
    partial class Form2
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
            this.TimesTable = new System.Windows.Forms.ListBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimesTable
            // 
            this.TimesTable.FormattingEnabled = true;
            this.TimesTable.Location = new System.Drawing.Point(270, 124);
            this.TimesTable.Name = "TimesTable";
            this.TimesTable.Size = new System.Drawing.Size(261, 160);
            this.TimesTable.TabIndex = 3;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(286, 304);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(270, 77);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 4;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrompt.Location = new System.Drawing.Point(113, 82);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(151, 15);
            this.lblPrompt.TabIndex = 5;
            this.lblPrompt.Text = "Enter a whole positive number";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.TimesTable);
            this.Controls.Add(this.btnClick);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TimesTable;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblPrompt;
    }
}