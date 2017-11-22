namespace MERP_V2
{
    partial class SiparisEmirleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEmirleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_satinalma_no = new System.Windows.Forms.ToolStripTextBox();
            this.label = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_proje_no = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_tedarikci = new System.Windows.Forms.ToolStripTextBox();
            this.btn_temizle = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_duzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_toplam = new System.Windows.Forms.ToolStripLabel();
            this.dgw_siparisemirleri = new MetroFramework.Controls.MetroGrid();
            this.mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlCommandListele = new MySql.Data.MySqlClient.MySqlCommand();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_siparisemirleri)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txt_satinalma_no,
            this.label,
            this.toolStripLabel2,
            this.cmb_proje_no,
            this.toolStripSeparator5,
            this.toolStripLabel4,
            this.txt_tedarikci,
            this.btn_temizle});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1346, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel1.Text = "Satınalma No :";
            // 
            // txt_satinalma_no
            // 
            this.txt_satinalma_no.Name = "txt_satinalma_no";
            this.txt_satinalma_no.Size = new System.Drawing.Size(100, 25);
            this.txt_satinalma_no.TextChanged += new System.EventHandler(this.txt_satinalma_no_TextChanged);
            // 
            // label
            // 
            this.label.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "Proje No :";
            // 
            // cmb_proje_no
            // 
            this.cmb_proje_no.Name = "cmb_proje_no";
            this.cmb_proje_no.Size = new System.Drawing.Size(121, 25);
            this.cmb_proje_no.SelectedIndexChanged += new System.EventHandler(this.cmb_proje_no_SelectedIndexChanged);
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
            this.toolStripLabel4.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel4.Text = "Tedarikçi :";
            // 
            // txt_tedarikci
            // 
            this.txt_tedarikci.Name = "txt_tedarikci";
            this.txt_tedarikci.Size = new System.Drawing.Size(100, 25);
            this.txt_tedarikci.TextChanged += new System.EventHandler(this.txt_tedarikci_TextChanged);
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
            this.btn_sil,
            this.toolStripSeparator4,
            this.btn_duzenle,
            this.toolStripLabel6,
            this.lbl_toplam});
            this.toolStrip2.Location = new System.Drawing.Point(20, 742);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1346, 26);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
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
            // dgw_siparisemirleri
            // 
            this.dgw_siparisemirleri.AllowUserToResizeRows = false;
            this.dgw_siparisemirleri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgw_siparisemirleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_siparisemirleri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw_siparisemirleri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_siparisemirleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw_siparisemirleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_siparisemirleri.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_siparisemirleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_siparisemirleri.EnableHeadersVisualStyles = false;
            this.dgw_siparisemirleri.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgw_siparisemirleri.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgw_siparisemirleri.Location = new System.Drawing.Point(20, 85);
            this.dgw_siparisemirleri.Name = "dgw_siparisemirleri";
            this.dgw_siparisemirleri.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_siparisemirleri.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgw_siparisemirleri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgw_siparisemirleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_siparisemirleri.Size = new System.Drawing.Size(1346, 657);
            this.dgw_siparisemirleri.TabIndex = 4;
            this.dgw_siparisemirleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_siparisemirleri_CellClick);
            this.dgw_siparisemirleri.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_siparisemirleri_RowHeaderMouseClick);
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "server=localhost;database=merp_dbv1;user id=root;password=root";
            // 
            // mySqlCommand
            // 
            this.mySqlCommand.CacheAge = 60;
            this.mySqlCommand.Connection = this.mySqlConnection;
            this.mySqlCommand.EnableCaching = false;
            this.mySqlCommand.Transaction = null;
            // 
            // mySqlDataAdapter
            // 
            this.mySqlDataAdapter.DeleteCommand = null;
            this.mySqlDataAdapter.InsertCommand = null;
            this.mySqlDataAdapter.SelectCommand = this.mySqlCommandListele;
            this.mySqlDataAdapter.UpdateCommand = null;
            // 
            // mySqlCommandListele
            // 
            this.mySqlCommandListele.CacheAge = 60;
            this.mySqlCommandListele.CommandText = "SELECT * FROM db_siparis_emri";
            this.mySqlCommandListele.Connection = this.mySqlConnection;
            this.mySqlCommandListele.EnableCaching = false;
            this.mySqlCommandListele.Transaction = null;
            // 
            // SiparisEmirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.dgw_siparisemirleri);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SiparisEmirleri";
            this.Text = "Sipariş Emirleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SiparisEmirleri_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_siparisemirleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_satinalma_no;
        private System.Windows.Forms.ToolStripSeparator label;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmb_proje_no;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_tedarikci;
        private System.Windows.Forms.ToolStripButton btn_temizle;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_sil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_duzenle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel lbl_toplam;
        private MetroFramework.Controls.MetroGrid dgw_siparisemirleri;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommandListele;
    }
}