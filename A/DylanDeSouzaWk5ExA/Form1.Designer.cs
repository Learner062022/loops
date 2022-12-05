namespace DylanDeSouzaWk5ExA
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
            this.btnAscendBy4 = new System.Windows.Forms.Button();
            this.btnAscendBy2 = new System.Windows.Forms.Button();
            this.btnAscendBy1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAscendBy4
            // 
            this.btnAscendBy4.Location = new System.Drawing.Point(364, 332);
            this.btnAscendBy4.Name = "btnAscendBy4";
            this.btnAscendBy4.Size = new System.Drawing.Size(96, 23);
            this.btnAscendBy4.TabIndex = 7;
            this.btnAscendBy4.Text = "Descend by 3";
            this.btnAscendBy4.UseVisualStyleBackColor = true;
            this.btnAscendBy4.Click += new System.EventHandler(this.btnAscendBy4_Click);
            // 
            // btnAscendBy2
            // 
            this.btnAscendBy2.Location = new System.Drawing.Point(364, 303);
            this.btnAscendBy2.Name = "btnAscendBy2";
            this.btnAscendBy2.Size = new System.Drawing.Size(75, 23);
            this.btnAscendBy2.TabIndex = 6;
            this.btnAscendBy2.Text = "Ascend by 2";
            this.btnAscendBy2.UseVisualStyleBackColor = true;
            this.btnAscendBy2.Click += new System.EventHandler(this.btnAscendBy2_Click);
            // 
            // btnAscendBy1
            // 
            this.btnAscendBy1.Location = new System.Drawing.Point(364, 274);
            this.btnAscendBy1.Name = "btnAscendBy1";
            this.btnAscendBy1.Size = new System.Drawing.Size(75, 23);
            this.btnAscendBy1.TabIndex = 5;
            this.btnAscendBy1.Text = "Ascend by 1";
            this.btnAscendBy1.UseVisualStyleBackColor = true;
            this.btnAscendBy1.Click += new System.EventHandler(this.btnAscendBy1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(340, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAscendBy4);
            this.Controls.Add(this.btnAscendBy2);
            this.Controls.Add(this.btnAscendBy1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAscendBy4;
        private System.Windows.Forms.Button btnAscendBy2;
        private System.Windows.Forms.Button btnAscendBy1;
        private System.Windows.Forms.ListBox listBox1;
    }
}