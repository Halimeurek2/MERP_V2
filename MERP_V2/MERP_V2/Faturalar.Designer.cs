namespace MERP_V2
{
    partial class Faturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faturalar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_fatura_no = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_proje_no = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_firma = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_tip = new System.Windows.Forms.ToolStripTextBox();
            this.btn_temizle = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_elektronik = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_mekanik = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_gnlgiderler = new System.Windows.Forms.ToolStripLabel();
            this.btn_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_duzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_toplam = new System.Windows.Forms.ToolStripLabel();
            this.dgw_faturalar = new MetroFramework.Controls.MetroGrid();
            this.mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlCommandProjeler = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommandFirmalar = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_faturalar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txt_fatura_no,
            this.toolStripSeparator6,
            this.toolStripLabel2,
            this.cmb_proje_no,
            this.toolStripSeparator7,
            this.toolStripLabel3,
            this.cmb_firma,
            this.toolStripSeparator5,
            this.toolStripLabel4,
            this.txt_tip,
            this.btn_temizle});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Fatura No :";
            // 
            // txt_fatura_no
            // 
            this.txt_fatura_no.Name = "txt_fatura_no";
            this.txt_fatura_no.Size = new System.Drawing.Size(100, 25);
            this.txt_fatura_no.TextChanged += new System.EventHandler(this.txt_fatura_no_TextChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel3.Text = "Firma :";
            // 
            // cmb_firma
            // 
            this.cmb_firma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_firma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_firma.Items.AddRange(new object[] {
            ""});
            this.cmb_firma.Name = "cmb_firma";
            this.cmb_firma.Size = new System.Drawing.Size(121, 25);
            this.cmb_firma.SelectedIndexChanged += new System.EventHandler(this.cmb_firma_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel4.Text = "Fatura Tipi :";
            // 
            // txt_tip
            // 
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.Size = new System.Drawing.Size(100, 25);
            this.txt_tip.TextChanged += new System.EventHandler(this.txt_tip_TextChanged);
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
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.lbl_elektronik,
            this.toolStripSeparator3,
            this.toolStripLabel7,
            this.lbl_mekanik,
            this.toolStripSeparator2,
            this.toolStripLabel9,
            this.lbl_gnlgiderler,
            this.btn_sil,
            this.toolStripSeparator4,
            this.btn_duzenle,
            this.toolStripSeparator1,
            this.toolStripLabel6,
            this.lbl_toplam});
            this.toolStrip2.Location = new System.Drawing.Point(20, 686);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1252, 26);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(84, 23);
            this.toolStripLabel5.Text = "Elektronik :";
            // 
            // lbl_elektronik
            // 
            this.lbl_elektronik.Name = "lbl_elektronik";
            this.lbl_elektronik.Size = new System.Drawing.Size(13, 23);
            this.lbl_elektronik.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(74, 23);
            this.toolStripLabel7.Text = "Mekanik :";
            // 
            // lbl_mekanik
            // 
            this.lbl_mekanik.Name = "lbl_mekanik";
            this.lbl_mekanik.Size = new System.Drawing.Size(13, 23);
            this.lbl_mekanik.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(114, 23);
            this.toolStripLabel9.Text = "Genel Giderler :";
            // 
            // lbl_gnlgiderler
            // 
            this.lbl_gnlgiderler.Name = "lbl_gnlgiderler";
            this.lbl_gnlgiderler.Size = new System.Drawing.Size(13, 23);
            this.lbl_gnlgiderler.Text = "0";
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
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
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(75, 23);
            this.toolStripLabel6.Text = "TOPLAM :";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(13, 23);
            this.lbl_toplam.Text = "0";
            // 
            // dgw_faturalar
            // 
            this.dgw_faturalar.AllowUserToResizeRows = false;
            this.dgw_faturalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgw_faturalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_faturalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw_faturalar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_faturalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_faturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_faturalar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_faturalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_faturalar.EnableHeadersVisualStyles = false;
            this.dgw_faturalar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgw_faturalar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgw_faturalar.Location = new System.Drawing.Point(20, 85);
            this.dgw_faturalar.Name = "dgw_faturalar";
            this.dgw_faturalar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_faturalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw_faturalar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgw_faturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_faturalar.Size = new System.Drawing.Size(1252, 601);
            this.dgw_faturalar.TabIndex = 3;
            this.dgw_faturalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_faturalar_CellClick);
            this.dgw_faturalar.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_faturalar_RowHeaderMouseClick);
            // 
            // mySqlCommand
            // 
            this.mySqlCommand.CacheAge = 60;
            this.mySqlCommand.CommandText = "SELECT * FROM (SELECT * FROM db_faturalar ORDER BY fatura_id DESC LIMIT 200) as r" +
    " ORDER BY fatura_id";
            this.mySqlCommand.Connection = this.mySqlConnection;
            this.mySqlCommand.EnableCaching = false;
            this.mySqlCommand.Transaction = null;
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "server=localhost;database=merp_dbv1;user id=root;password=root";
            // 
            // mySqlDataAdapter
            // 
            this.mySqlDataAdapter.DeleteCommand = null;
            this.mySqlDataAdapter.InsertCommand = null;
            this.mySqlDataAdapter.SelectCommand = this.mySqlCommand;
            this.mySqlDataAdapter.UpdateCommand = null;
            // 
            // mySqlCommandProjeler
            // 
            this.mySqlCommandProjeler.CacheAge = 60;
            this.mySqlCommandProjeler.CommandText = "SELECT DISTINCT proje_no FROM db_projeler";
            this.mySqlCommandProjeler.Connection = this.mySqlConnection;
            this.mySqlCommandProjeler.EnableCaching = false;
            this.mySqlCommandProjeler.Transaction = null;
            // 
            // mySqlCommandFirmalar
            // 
            this.mySqlCommandFirmalar.CacheAge = 60;
            this.mySqlCommandFirmalar.CommandText = "SELECT DISTINCT fatura_firma FROM db_faturalar";
            this.mySqlCommandFirmalar.Connection = this.mySqlConnection;
            this.mySqlCommandFirmalar.EnableCaching = false;
            this.mySqlCommandFirmalar.Transaction = null;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 60;
            this.mySqlCommand1.Connection = this.mySqlConnection;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 732);
            this.Controls.Add(this.dgw_faturalar);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Faturalar";
            this.Text = "Faturalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Faturalar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_faturalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_fatura_no;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmb_proje_no;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmb_firma;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_tip;
        private System.Windows.Forms.ToolStripButton btn_temizle;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lbl_elektronik;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel lbl_mekanik;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel lbl_gnlgiderler;
        private System.Windows.Forms.ToolStripButton btn_sil;
        private System.Windows.Forms.ToolStripButton btn_duzenle;
        private MetroFramework.Controls.MetroGrid dgw_faturalar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel lbl_toplam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommandProjeler;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommandFirmalar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}