namespace MatchMaker
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
            this.ImportCSV = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ImportCSV
            // 
            this.ImportCSV.Location = new System.Drawing.Point(12, 12);
            this.ImportCSV.Name = "ImportCSV";
            this.ImportCSV.Size = new System.Drawing.Size(75, 23);
            this.ImportCSV.TabIndex = 0;
            this.ImportCSV.Text = "Import CSV";
            this.ImportCSV.UseVisualStyleBackColor = true;
            this.ImportCSV.Click += new System.EventHandler(this.ImportCSV_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(124, 14);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 20);
            this.FileName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 212);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.ImportCSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportCSV;
        private System.Windows.Forms.TextBox FileName;
    }
}

