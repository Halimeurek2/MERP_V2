namespace MERP_V2
{
    partial class AnaEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.faturalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projelerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEmriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEmriGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeyeGöreRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acilNormalİşlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diğerİşlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_cokacil = new System.Windows.Forms.Panel();
            this.timerPanel = new System.Windows.Forms.Timer(this.components);
            this.btn_menu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "server=localhost;database=merp_dbv1;user id=root;password=root";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturalarToolStripMenuItem,
            this.projelerToolStripMenuItem,
            this.siparişEmriToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.acilNormalİşlerToolStripMenuItem,
            this.diğerİşlerToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(23, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1332, 84);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faturalarToolStripMenuItem
            // 
            this.faturalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaGirişToolStripMenuItem,
            this.faturalarToolStripMenuItem1});
            this.faturalarToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.appbar_cabinet_files;
            this.faturalarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.faturalarToolStripMenuItem.Name = "faturalarToolStripMenuItem";
            this.faturalarToolStripMenuItem.Size = new System.Drawing.Size(136, 80);
            this.faturalarToolStripMenuItem.Text = "Faturalar";
            // 
            // faturaGirişToolStripMenuItem
            // 
            this.faturaGirişToolStripMenuItem.Name = "faturaGirişToolStripMenuItem";
            this.faturaGirişToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.faturaGirişToolStripMenuItem.Text = "Fatura Giriş";
            this.faturaGirişToolStripMenuItem.Click += new System.EventHandler(this.faturaGirişToolStripMenuItem_Click);
            // 
            // faturalarToolStripMenuItem1
            // 
            this.faturalarToolStripMenuItem1.Name = "faturalarToolStripMenuItem1";
            this.faturalarToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.faturalarToolStripMenuItem1.Text = "Faturalar";
            this.faturalarToolStripMenuItem1.Click += new System.EventHandler(this.faturalarToolStripMenuItem1_Click);
            // 
            // projelerToolStripMenuItem
            // 
            this.projelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeGirişToolStripMenuItem,
            this.projelerToolStripMenuItem1});
            this.projelerToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.appbar_rocket_rotated_45;
            this.projelerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.projelerToolStripMenuItem.Name = "projelerToolStripMenuItem";
            this.projelerToolStripMenuItem.Size = new System.Drawing.Size(125, 80);
            this.projelerToolStripMenuItem.Text = "Projeler";
            // 
            // projeGirişToolStripMenuItem
            // 
            this.projeGirişToolStripMenuItem.Name = "projeGirişToolStripMenuItem";
            this.projeGirişToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.projeGirişToolStripMenuItem.Text = "Proje Giriş";
            this.projeGirişToolStripMenuItem.Click += new System.EventHandler(this.projeGirişToolStripMenuItem_Click);
            // 
            // projelerToolStripMenuItem1
            // 
            this.projelerToolStripMenuItem1.Name = "projelerToolStripMenuItem1";
            this.projelerToolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.projelerToolStripMenuItem1.Text = "Projeler";
            this.projelerToolStripMenuItem1.Click += new System.EventHandler(this.projelerToolStripMenuItem1_Click);
            // 
            // siparişEmriToolStripMenuItem
            // 
            this.siparişEmriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEmriGirişToolStripMenuItem,
            this.siparişlerToolStripMenuItem});
            this.siparişEmriToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.appbar_transit_connection;
            this.siparişEmriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.siparişEmriToolStripMenuItem.Name = "siparişEmriToolStripMenuItem";
            this.siparişEmriToolStripMenuItem.Size = new System.Drawing.Size(156, 80);
            this.siparişEmriToolStripMenuItem.Text = "Sipariş Emri";
            // 
            // siparişEmriGirişToolStripMenuItem
            // 
            this.siparişEmriGirişToolStripMenuItem.Name = "siparişEmriGirişToolStripMenuItem";
            this.siparişEmriGirişToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.siparişEmriGirişToolStripMenuItem.Text = "Sipariş Emri Giriş";
            this.siparişEmriGirişToolStripMenuItem.Click += new System.EventHandler(this.siparişEmriGirişToolStripMenuItem_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.siparişlerToolStripMenuItem.Text = "Sipariş Emirleri";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeyeGöreRaporToolStripMenuItem});
            this.raporToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.appbar_graph_line_up;
            this.raporToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(111, 80);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // projeyeGöreRaporToolStripMenuItem
            // 
            this.projeyeGöreRaporToolStripMenuItem.Name = "projeyeGöreRaporToolStripMenuItem";
            this.projeyeGöreRaporToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.projeyeGöreRaporToolStripMenuItem.Text = "Projeye Göre Rapor";
            this.projeyeGöreRaporToolStripMenuItem.Click += new System.EventHandler(this.projeyeGöreRaporToolStripMenuItem_Click);
            // 
            // acilNormalİşlerToolStripMenuItem
            // 
            this.acilNormalİşlerToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.appbar_clock;
            this.acilNormalİşlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.acilNormalİşlerToolStripMenuItem.Name = "acilNormalİşlerToolStripMenuItem";
            this.acilNormalİşlerToolStripMenuItem.Size = new System.Drawing.Size(216, 80);
            this.acilNormalİşlerToolStripMenuItem.Text = "Acil-Normal İşler";
            // 
            // diğerİşlerToolStripMenuItem
            // 
            this.diğerİşlerToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.appbar_paperclip_rotated;
            this.diğerİşlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.diğerİşlerToolStripMenuItem.Name = "diğerİşlerToolStripMenuItem";
            this.diğerİşlerToolStripMenuItem.Size = new System.Drawing.Size(170, 80);
            this.diğerİşlerToolStripMenuItem.Text = "Diğer İşler";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.appbar_question;
            this.hakkındaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(139, 80);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // pnl_cokacil
            // 
            this.pnl_cokacil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_cokacil.Location = new System.Drawing.Point(8, 164);
            this.pnl_cokacil.Name = "pnl_cokacil";
            this.pnl_cokacil.Size = new System.Drawing.Size(262, 396);
            this.pnl_cokacil.TabIndex = 0;
            // 
            // timerPanel
            // 
            this.timerPanel.Interval = 80;
            this.timerPanel.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_menu.Location = new System.Drawing.Point(699, 346);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(192, 51);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "MENU";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::MERP_V2.Properties.Resources.Picture2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 742);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.pnl_cokacil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaEkran";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "MERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MySql.Data.MySqlClient.MySqlConnection mySqlConnection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faturalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişEmriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acilNormalİşlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diğerİşlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem projeGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projelerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem siparişEmriGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeyeGöreRaporToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_cokacil;
        private System.Windows.Forms.Timer timerPanel;
        private System.Windows.Forms.Button btn_menu;
    }
}

