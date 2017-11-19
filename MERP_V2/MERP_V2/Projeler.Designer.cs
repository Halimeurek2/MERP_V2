namespace MERP_V2
{
    partial class Projeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projeler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_proje_adi = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_proje_no = new System.Windows.Forms.ToolStripComboBox();
            this.btn_temizle = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_toplam = new System.Windows.Forms.ToolStripLabel();
            this.btn_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_duzenle = new System.Windows.Forms.ToolStripButton();
            this.dgw_projeler = new MetroFramework.Controls.MetroGrid();
            this.mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlCommandListele = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_projeler)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txt_proje_adi,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.cmb_proje_no,
            this.btn_temizle});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1338, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel1.Text = "Proje Adı :";
            // 
            // txt_proje_adi
            // 
            this.txt_proje_adi.Name = "txt_proje_adi";
            this.txt_proje_adi.Size = new System.Drawing.Size(100, 25);
            this.txt_proje_adi.TextChanged += new System.EventHandler(this.txt_proje_adi_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "Proje No :";
            // 
            // cmb_proje_no
            // 
            this.cmb_proje_no.Items.AddRange(new object[] {
            "",
            "Hepsi"});
            this.cmb_proje_no.Name = "cmb_proje_no";
            this.cmb_proje_no.Size = new System.Drawing.Size(121, 25);
            this.cmb_proje_no.SelectedIndexChanged += new System.EventHandler(this.cmb_proje_no_SelectedIndexChanged);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_temizle.ForeColor = System.Drawing.Color.Red;
            this.btn_temizle.Image = global::MERP_V2.Properties.Resources.appbar_refresh;
            this.btn_temizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(68, 22);
            this.btn_temizle.Text = "Temizle";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.lbl_toplam,
            this.btn_sil,
            this.toolStripSeparator1,
            this.btn_duzenle});
            this.toolStrip2.Location = new System.Drawing.Point(20, 734);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1338, 26);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(75, 23);
            this.toolStripLabel5.Text = "TOPLAM :";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(13, 23);
            this.lbl_toplam.Text = "0";
            // 
            // btn_sil
            // 
            this.btn_sil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_sil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_sil.ForeColor = System.Drawing.Color.Red;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(32, 23);
            this.btn_sil.Text = "SİL";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_duzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_duzenle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_duzenle.ForeColor = System.Drawing.Color.Red;
            this.btn_duzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_duzenle.Image")));
            this.btn_duzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(74, 23);
            this.btn_duzenle.Text = "DÜZENLE";
            // 
            // dgw_projeler
            // 
            this.dgw_projeler.AllowUserToResizeRows = false;
            this.dgw_projeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgw_projeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_projeler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw_projeler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_projeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgw_projeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_projeler.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgw_projeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_projeler.EnableHeadersVisualStyles = false;
            this.dgw_projeler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgw_projeler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgw_projeler.Location = new System.Drawing.Point(20, 85);
            this.dgw_projeler.Name = "dgw_projeler";
            this.dgw_projeler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_projeler.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgw_projeler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgw_projeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_projeler.Size = new System.Drawing.Size(1338, 649);
            this.dgw_projeler.TabIndex = 4;
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "server=localhost;database=merp_dbv1;user id=root;password=root";
            // 
            // mySqlCommandListele
            // 
            this.mySqlCommandListele.CacheAge = 60;
            this.mySqlCommandListele.CommandText = resources.GetString("mySqlCommandListele.CommandText");
            this.mySqlCommandListele.Connection = this.mySqlConnection;
            this.mySqlCommandListele.EnableCaching = false;
            this.mySqlCommandListele.Transaction = null;
            // 
            // mySqlDataAdapter
            // 
            this.mySqlDataAdapter.DeleteCommand = null;
            this.mySqlDataAdapter.InsertCommand = null;
            this.mySqlDataAdapter.SelectCommand = this.mySqlCommandListele;
            this.mySqlDataAdapter.UpdateCommand = null;
            // 
            // mySqlCommand
            // 
            this.mySqlCommand.CacheAge = 60;
            this.mySqlCommand.Connection = this.mySqlConnection;
            this.mySqlCommand.EnableCaching = false;
            this.mySqlCommand.Transaction = null;
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.dgw_projeler);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Projeler";
            this.Text = "Projeler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Projeler_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_projeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_proje_adi;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmb_proje_no;
        private System.Windows.Forms.ToolStripButton btn_temizle;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lbl_toplam;
        private System.Windows.Forms.ToolStripButton btn_sil;
        private System.Windows.Forms.ToolStripButton btn_duzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MetroFramework.Controls.MetroGrid dgw_projeler;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommandListele;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand;
    }
}