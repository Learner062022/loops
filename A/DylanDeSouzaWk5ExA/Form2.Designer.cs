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
            this.lstSquares = new System.Windows.Forms.ListBox();
            this.btnAscendBy1 = new System.Windows.Forms.Button();
            this.btnAscendBy2 = new System.Windows.Forms.Button();
            this.btnAscendBy4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSquares
            // 
            this.lstSquares.FormattingEnabled = true;
            this.lstSquares.Location = new System.Drawing.Point(296, 5);
            this.lstSquares.Name = "lstSquares";
            this.lstSquares.Size = new System.Drawing.Size(120, 173);
            this.lstSquares.TabIndex = 0;
            this.lstSquares.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAscendBy1
            // 
            this.btnAscendBy1.Location = new System.Drawing.Point(320, 184);
            this.btnAscendBy1.Name = "btnAscendBy1";
            this.btnAscendBy1.Size = new System.Drawing.Size(75, 23);
            this.btnAscendBy1.TabIndex = 1;
            this.btnAscendBy1.Text = "Ascend by 1";
            this.btnAscendBy1.UseVisualStyleBackColor = true;
            this.btnAscendBy1.Click += new System.EventHandler(this.btnAscendBy1_Click);
            // 
            // btnAscendBy2
            // 
            this.btnAscendBy2.Location = new System.Drawing.Point(320, 213);
            this.btnAscendBy2.Name = "btnAscendBy2";
            this.btnAscendBy2.Size = new System.Drawing.Size(75, 23);
            this.btnAscendBy2.TabIndex = 2;
            this.btnAscendBy2.Text = "Ascend by 2";
            this.btnAscendBy2.UseVisualStyleBackColor = true;
            this.btnAscendBy2.Click += new System.EventHandler(this.btnAscendBy2_Click);
            // 
            // btnAscendBy4
            // 
            this.btnAscendBy4.Location = new System.Drawing.Point(320, 242);
            this.btnAscendBy4.Name = "btnAscendBy4";
            this.btnAscendBy4.Size = new System.Drawing.Size(96, 23);
            this.btnAscendBy4.TabIndex = 3;
            this.btnAscendBy4.Text = "Descend by 4";
            this.btnAscendBy4.UseVisualStyleBackColor = true;
            this.btnAscendBy4.Click += new System.EventHandler(this.btnAscendBy4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAscendBy4);
            this.Controls.Add(this.btnAscendBy2);
            this.Controls.Add(this.btnAscendBy1);
            this.Controls.Add(this.lstSquares);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSquares;
        private System.Windows.Forms.Button btnAscendBy1;
        private System.Windows.Forms.Button btnAscendBy2;
        private System.Windows.Forms.Button btnAscendBy4;
    }
}