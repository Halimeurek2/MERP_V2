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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.flw_fatura = new System.Windows.Forms.FlowLayoutPanel();
            this.flw_tarih = new System.Windows.Forms.FlowLayoutPanel();
            this.flw_butce = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_usd = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_eur = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_gbp = new System.Windows.Forms.ToolStripLabel();
            this.cmb_Barprojeler = new System.Windows.Forms.ToolStripComboBox();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flw_tarih2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flw_fatura2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flw_butce2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "server=localhost;database=merp_dbv1;user id=root;password=root";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuStrip1.Size = new System.Drawing.Size(1534, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faturalarToolStripMenuItem
            // 
            this.faturalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaGirişToolStripMenuItem,
            this.faturalarToolStripMenuItem1});
            this.faturalarToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.if_Money_728958;
            this.faturalarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.faturalarToolStripMenuItem.Name = "faturalarToolStripMenuItem";
            this.faturalarToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.faturalarToolStripMenuItem.Text = "Faturalar";
            // 
            // faturaGirişToolStripMenuItem
            // 
            this.faturaGirişToolStripMenuItem.Name = "faturaGirişToolStripMenuItem";
            this.faturaGirişToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.faturaGirişToolStripMenuItem.Text = "Fatura Giriş";
            this.faturaGirişToolStripMenuItem.Click += new System.EventHandler(this.faturaGirişToolStripMenuItem_Click);
            // 
            // faturalarToolStripMenuItem1
            // 
            this.faturalarToolStripMenuItem1.Name = "faturalarToolStripMenuItem1";
            this.faturalarToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.faturalarToolStripMenuItem1.Text = "Faturalar";
            this.faturalarToolStripMenuItem1.Click += new System.EventHandler(this.faturalarToolStripMenuItem1_Click);
            // 
            // projelerToolStripMenuItem
            // 
            this.projelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeGirişToolStripMenuItem,
            this.projelerToolStripMenuItem1});
            this.projelerToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.if_Lightbulb_728950;
            this.projelerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.projelerToolStripMenuItem.Name = "projelerToolStripMenuItem";
            this.projelerToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.projelerToolStripMenuItem.Text = "Projeler";
            // 
            // projeGirişToolStripMenuItem
            // 
            this.projeGirişToolStripMenuItem.Name = "projeGirişToolStripMenuItem";
            this.projeGirişToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.projeGirişToolStripMenuItem.Text = "Proje Giriş";
            this.projeGirişToolStripMenuItem.Click += new System.EventHandler(this.projeGirişToolStripMenuItem_Click);
            // 
            // projelerToolStripMenuItem1
            // 
            this.projelerToolStripMenuItem1.Name = "projelerToolStripMenuItem1";
            this.projelerToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.projelerToolStripMenuItem1.Text = "Projeler";
            this.projelerToolStripMenuItem1.Click += new System.EventHandler(this.projelerToolStripMenuItem1_Click);
            // 
            // siparişEmriToolStripMenuItem
            // 
            this.siparişEmriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEmriGirişToolStripMenuItem,
            this.siparişlerToolStripMenuItem});
            this.siparişEmriToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.if_News_728959;
            this.siparişEmriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.siparişEmriToolStripMenuItem.Name = "siparişEmriToolStripMenuItem";
            this.siparişEmriToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.siparişEmriToolStripMenuItem.Text = "Sipariş Emri";
            // 
            // siparişEmriGirişToolStripMenuItem
            // 
            this.siparişEmriGirişToolStripMenuItem.Name = "siparişEmriGirişToolStripMenuItem";
            this.siparişEmriGirişToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.siparişEmriGirişToolStripMenuItem.Text = "Sipariş Emri Giriş";
            this.siparişEmriGirişToolStripMenuItem.Click += new System.EventHandler(this.siparişEmriGirişToolStripMenuItem_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.siparişlerToolStripMenuItem.Text = "Sipariş Emirleri";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeyeGöreRaporToolStripMenuItem});
            this.raporToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.if_PieChart_728965;
            this.raporToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // projeyeGöreRaporToolStripMenuItem
            // 
            this.projeyeGöreRaporToolStripMenuItem.Name = "projeyeGöreRaporToolStripMenuItem";
            this.projeyeGöreRaporToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.projeyeGöreRaporToolStripMenuItem.Text = "Projeye Göre Rapor";
            this.projeyeGöreRaporToolStripMenuItem.Click += new System.EventHandler(this.projeyeGöreRaporToolStripMenuItem_Click);
            // 
            // acilNormalİşlerToolStripMenuItem
            // 
            this.acilNormalİşlerToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.if_Alarm_728899;
            this.acilNormalİşlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.acilNormalİşlerToolStripMenuItem.Name = "acilNormalİşlerToolStripMenuItem";
            this.acilNormalİşlerToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            this.acilNormalİşlerToolStripMenuItem.Text = "Acil-Normal İşler";
            // 
            // diğerİşlerToolStripMenuItem
            // 
            this.diğerİşlerToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.if_Pin_728961;
            this.diğerİşlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.diğerİşlerToolStripMenuItem.Name = "diğerİşlerToolStripMenuItem";
            this.diğerİşlerToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.diğerİşlerToolStripMenuItem.Text = "Diğer İşler";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::MERP_V2.Properties.Resources.if_Info_728979;
            this.hakkındaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(23, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1534, 704);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(42, 704);
            this.splitContainer2.SplitterDistance = 234;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MERP_V2.Properties.Resources.malvefatu;
            this.pictureBox1.Location = new System.Drawing.Point(3, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 234);
            this.button1.TabIndex = 0;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer3.Panel1.Controls.Add(this.button2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer3.Panel2.Controls.Add(this.btn_grafik);
            this.splitContainer3.Size = new System.Drawing.Size(42, 466);
            this.splitContainer3.SplitterDistance = 233;
            this.splitContainer3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MERP_V2.Properties.Resources.cokaciil;
            this.pictureBox2.Location = new System.Drawing.Point(3, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 233);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MERP_V2.Properties.Resources.grafik;
            this.pictureBox3.Location = new System.Drawing.Point(3, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btn_grafik_Click);
            // 
            // btn_grafik
            // 
            this.btn_grafik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_grafik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_grafik.Image = ((System.Drawing.Image)(resources.GetObject("btn_grafik.Image")));
            this.btn_grafik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_grafik.Location = new System.Drawing.Point(0, 0);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(42, 229);
            this.btn_grafik.TabIndex = 1;
            this.btn_grafik.UseVisualStyleBackColor = true;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            // 
            // flw_fatura
            // 
            this.flw_fatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_fatura.Location = new System.Drawing.Point(0, 125);
            this.flw_fatura.Name = "flw_fatura";
            this.flw_fatura.Size = new System.Drawing.Size(1476, 47);
            this.flw_fatura.TabIndex = 8;
            // 
            // flw_tarih
            // 
            this.flw_tarih.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_tarih.Location = new System.Drawing.Point(0, 19);
            this.flw_tarih.Name = "flw_tarih";
            this.flw_tarih.Size = new System.Drawing.Size(1476, 47);
            this.flw_tarih.TabIndex = 6;
            // 
            // flw_butce
            // 
            this.flw_butce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_butce.Location = new System.Drawing.Point(0, 72);
            this.flw_butce.Name = "flw_butce";
            this.flw_butce.Size = new System.Drawing.Size(1476, 47);
            this.flw_butce.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.lbl_usd,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.lbl_eur,
            this.toolStripSeparator1,
            this.toolStripLabel6,
            this.lbl_gbp,
            this.cmb_Barprojeler});
            this.toolStrip1.Location = new System.Drawing.Point(0, 679);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1488, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "KURLAR";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel2.Text = "USD :";
            // 
            // lbl_usd
            // 
            this.lbl_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usd.Name = "lbl_usd";
            this.lbl_usd.Size = new System.Drawing.Size(14, 22);
            this.lbl_usd.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel4.Text = "EURO :";
            // 
            // lbl_eur
            // 
            this.lbl_eur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eur.Name = "lbl_eur";
            this.lbl_eur.Size = new System.Drawing.Size(14, 22);
            this.lbl_eur.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel6.Text = "GBP :";
            // 
            // lbl_gbp
            // 
            this.lbl_gbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gbp.Name = "lbl_gbp";
            this.lbl_gbp.Size = new System.Drawing.Size(14, 22);
            this.lbl_gbp.Text = "0";
            // 
            // cmb_Barprojeler
            // 
            this.cmb_Barprojeler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmb_Barprojeler.Items.AddRange(new object[] {
            "910.20",
            "910.23",
            "910.10"});
            this.cmb_Barprojeler.Name = "cmb_Barprojeler";
            this.cmb_Barprojeler.Size = new System.Drawing.Size(121, 25);
            this.cmb_Barprojeler.SelectedIndexChanged += new System.EventHandler(this.cmb_Barprojeler_SelectedIndexChanged);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(543, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(546, 25);
            this.miniToolStrip.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flw_tarih);
            this.groupBox1.Controls.Add(this.flw_fatura);
            this.groupBox1.Controls.Add(this.flw_butce);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1482, 183);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROJE BAR :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.flw_tarih2);
            this.groupBox2.Controls.Add(this.flw_fatura2);
            this.groupBox2.Controls.Add(this.flw_butce2);
            this.groupBox2.Location = new System.Drawing.Point(3, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1482, 183);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PROJE BAR :";
            // 
            // flw_tarih2
            // 
            this.flw_tarih2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_tarih2.Location = new System.Drawing.Point(0, 19);
            this.flw_tarih2.Name = "flw_tarih2";
            this.flw_tarih2.Size = new System.Drawing.Size(1476, 47);
            this.flw_tarih2.TabIndex = 6;
            // 
            // flw_fatura2
            // 
            this.flw_fatura2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_fatura2.Location = new System.Drawing.Point(0, 125);
            this.flw_fatura2.Name = "flw_fatura2";
            this.flw_fatura2.Size = new System.Drawing.Size(1476, 47);
            this.flw_fatura2.TabIndex = 8;
            // 
            // flw_butce2
            // 
            this.flw_butce2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flw_butce2.Location = new System.Drawing.Point(0, 72);
            this.flw_butce2.Name = "flw_butce2";
            this.flw_butce2.Size = new System.Drawing.Size(1476, 47);
            this.flw_butce2.TabIndex = 7;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1580, 824);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaEkran";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lbl_usd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel lbl_eur;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel lbl_gbp;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.FlowLayoutPanel flw_fatura;
        private System.Windows.Forms.FlowLayoutPanel flw_tarih;
        private System.Windows.Forms.FlowLayoutPanel flw_butce;
        private System.Windows.Forms.ToolStripComboBox cmb_Barprojeler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flw_tarih2;
        private System.Windows.Forms.FlowLayoutPanel flw_fatura2;
        private System.Windows.Forms.FlowLayoutPanel flw_butce2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

