namespace MERP_V2
{
    partial class FormMessageBox
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
            this.txt_mesaj = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txt_mesaj
            // 
            this.txt_mesaj.AutoSize = true;
            this.txt_mesaj.BackColor = System.Drawing.Color.Transparent;
            this.txt_mesaj.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txt_mesaj.ForeColor = System.Drawing.Color.White;
            this.txt_mesaj.Location = new System.Drawing.Point(52, 74);
            this.txt_mesaj.Name = "txt_mesaj";
            this.txt_mesaj.Size = new System.Drawing.Size(41, 19);
            this.txt_mesaj.TabIndex = 0;
            this.txt_mesaj.Text = "TEXT";
            this.txt_mesaj.UseCustomBackColor = true;
            this.txt_mesaj.UseCustomForeColor = true;
            this.txt_mesaj.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.ForeColor = System.Drawing.Color.Gold;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(437, 91);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 31);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "OK";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FormMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 134);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txt_mesaj);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMessageBox";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Message Box";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroLabel txt_mesaj;
    }
}