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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pnlDGW = new System.Windows.Forms.Panel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_maliyet = new MetroFramework.Controls.MetroGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgw_faturalar = new MetroFramework.Controls.MetroGrid();
            this.pnlGrafik = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_proje_no = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_yil = new System.Windows.Forms.ToolStripComboBox();
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
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_ayar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_maliyetler = new System.Windows.Forms.Button();
            this.btn_acil = new System.Windows.Forms.Button();
            this.btn_grafik = new System.Windows.Forms.Button();
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
            this.kullanıcıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEmriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_bar2 = new System.Windows.Forms.ToolStripComboBox();
            this.cmb_bar1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flp1_tarih = new System.Windows.Forms.FlowLayoutPanel();
            this.flp1_butce = new System.Windows.Forms.FlowLayoutPanel();
            this.flp1_fatura = new System.Windows.Forms.FlowLayoutPanel();
            this.flp2_fatura = new System.Windows.Forms.FlowLayoutPanel();
            this.flp2_butce = new System.Windows.Forms.FlowLayoutPanel();
            this.flp2_tarih = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.pnlDGW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_maliyet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_faturalar)).BeginInit();
            this.pnlGrafik.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.hakkındaToolStripMenuItem,
            this.btn_ayar});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(23, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1231, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.pnlDGW);
            this.splitContainer1.Panel2.Controls.Add(this.pnlGrafik);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1231, 612);
            this.splitContainer1.SplitterDistance = 67;
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
            this.splitContainer2.Panel1.Controls.Add(this.btn_maliyetler);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(67, 612);
            this.splitContainer2.SplitterDistance = 202;
            this.splitContainer2.TabIndex = 0;
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
            this.splitContainer3.Panel1.Controls.Add(this.btn_acil);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btn_grafik);
            this.splitContainer3.Size = new System.Drawing.Size(67, 406);
            this.splitContainer3.SplitterDistance = 203;
            this.splitContainer3.TabIndex = 0;
            // 
            // pnlDGW
            // 
            this.pnlDGW.Controls.Add(this.splitContainer5);
            this.pnlDGW.Location = new System.Drawing.Point(3, 314);
            this.pnlDGW.Name = "pnlDGW";
            this.pnlDGW.Size = new System.Drawing.Size(271, 113);
            this.pnlDGW.TabIndex = 9;
            this.pnlDGW.Visible = false;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer5.Size = new System.Drawing.Size(271, 113);
            this.splitContainer5.SplitterDistance = 58;
            this.splitContainer5.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_maliyet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Maliyetleri";
            // 
            // dg_maliyet
            // 
            this.dg_maliyet.AllowUserToResizeRows = false;
            this.dg_maliyet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dg_maliyet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_maliyet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_maliyet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_maliyet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dg_maliyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_maliyet.DefaultCellStyle = dataGridViewCellStyle8;
            this.dg_maliyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_maliyet.EnableHeadersVisualStyles = false;
            this.dg_maliyet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dg_maliyet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dg_maliyet.Location = new System.Drawing.Point(3, 16);
            this.dg_maliyet.Name = "dg_maliyet";
            this.dg_maliyet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_maliyet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dg_maliyet.RowHeadersVisible = false;
            this.dg_maliyet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_maliyet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_maliyet.Size = new System.Drawing.Size(265, 39);
            this.dg_maliyet.Style = MetroFramework.MetroColorStyle.Red;
            this.dg_maliyet.TabIndex = 0;
            this.dg_maliyet.UseCustomBackColor = true;
            this.dg_maliyet.UseCustomForeColor = true;
            this.dg_maliyet.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgw_faturalar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projeye Kesilen Faturalar";
            // 
            // dgw_faturalar
            // 
            this.dgw_faturalar.AllowUserToResizeRows = false;
            this.dgw_faturalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgw_faturalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_faturalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw_faturalar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_faturalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgw_faturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_faturalar.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgw_faturalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_faturalar.EnableHeadersVisualStyles = false;
            this.dgw_faturalar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgw_faturalar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgw_faturalar.Location = new System.Drawing.Point(3, 16);
            this.dgw_faturalar.Name = "dgw_faturalar";
            this.dgw_faturalar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_faturalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgw_faturalar.RowHeadersVisible = false;
            this.dgw_faturalar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgw_faturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_faturalar.Size = new System.Drawing.Size(265, 32);
            this.dgw_faturalar.Style = MetroFramework.MetroColorStyle.Silver;
            this.dgw_faturalar.TabIndex = 1;
            this.dgw_faturalar.UseCustomBackColor = true;
            this.dgw_faturalar.UseCustomForeColor = true;
            this.dgw_faturalar.UseStyleColors = true;
            // 
            // pnlGrafik
            // 
            this.pnlGrafik.Controls.Add(this.panel1);
            this.pnlGrafik.Controls.Add(this.toolStrip2);
            this.pnlGrafik.Location = new System.Drawing.Point(298, 314);
            this.pnlGrafik.Name = "pnlGrafik";
            this.pnlGrafik.Size = new System.Drawing.Size(226, 194);
            this.pnlGrafik.TabIndex = 8;
            this.pnlGrafik.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 167);
            this.panel1.TabIndex = 8;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripLabel5,
            this.cmb_proje_no,
            this.toolStripSeparator3,
            this.toolStripLabel8,
            this.cmb_yil});
            this.toolStrip2.Location = new System.Drawing.Point(0, 167);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(226, 27);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(109, 24);
            this.toolStripLabel3.Text = "GRAFİK FİLTRE";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel5.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(62, 24);
            this.toolStripLabel5.Text = "Proje No :";
            // 
            // cmb_proje_no
            // 
            this.cmb_proje_no.Name = "cmb_proje_no";
            this.cmb_proje_no.Size = new System.Drawing.Size(121, 23);
            this.cmb_proje_no.SelectedIndexChanged += new System.EventHandler(this.cmb_proje_no_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(30, 15);
            this.toolStripLabel8.Text = "Yıl :";
            // 
            // cmb_yil
            // 
            this.cmb_yil.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018"});
            this.cmb_yil.Name = "cmb_yil";
            this.cmb_yil.Size = new System.Drawing.Size(121, 23);
            this.cmb_yil.SelectedIndexChanged += new System.EventHandler(this.cmb_yil_SelectedIndexChanged);
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
            this.cmb_bar2,
            this.toolStripLabel7,
            this.cmb_bar1,
            this.toolStripLabel9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 587);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1160, 25);
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
            // mySqlCommand
            // 
            this.mySqlCommand.CacheAge = 60;
            this.mySqlCommand.Connection = this.mySqlConnection;
            this.mySqlCommand.EnableCaching = false;
            this.mySqlCommand.Transaction = null;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 92F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 5F;
            legend2.Position.Width = 50F;
            legend2.Position.X = 50F;
            legend2.Position.Y = 93F;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.Silver,
        System.Drawing.Color.DarkSeaGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))))};
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Gelen Faturalar";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Kesilen Faturalar";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series8.ChartArea = "ChartArea1";
            series8.LabelAngle = 45;
            series8.Legend = "Legend1";
            series8.Name = "Öngörülen Ödemeler";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Alınan Ödemeler";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Yapılan Ödemeler";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(226, 167);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // btn_ayar
            // 
            this.btn_ayar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_ayar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıAyarlarıToolStripMenuItem,
            this.projeAyarlarıToolStripMenuItem,
            this.excelToToolStripMenuItem});
            this.btn_ayar.Image = global::MERP_V2.Properties.Resources.appbar_cog;
            this.btn_ayar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ayar.Name = "btn_ayar";
            this.btn_ayar.Size = new System.Drawing.Size(105, 36);
            this.btn_ayar.Text = "Kullanıcı";
            // 
            // btn_maliyetler
            // 
            this.btn_maliyetler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_maliyetler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_maliyetler.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maliyetler.ForeColor = System.Drawing.Color.Red;
            this.btn_maliyetler.Image = ((System.Drawing.Image)(resources.GetObject("btn_maliyetler.Image")));
            this.btn_maliyetler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_maliyetler.Location = new System.Drawing.Point(0, 0);
            this.btn_maliyetler.Name = "btn_maliyetler";
            this.btn_maliyetler.Size = new System.Drawing.Size(67, 202);
            this.btn_maliyetler.TabIndex = 0;
            this.btn_maliyetler.Text = "Maliyet \r\nve\r\nFaturalar\r\n";
            this.btn_maliyetler.UseVisualStyleBackColor = true;
            this.btn_maliyetler.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_acil
            // 
            this.btn_acil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_acil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_acil.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acil.ForeColor = System.Drawing.Color.Red;
            this.btn_acil.Image = ((System.Drawing.Image)(resources.GetObject("btn_acil.Image")));
            this.btn_acil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_acil.Location = new System.Drawing.Point(0, 0);
            this.btn_acil.Name = "btn_acil";
            this.btn_acil.Size = new System.Drawing.Size(67, 203);
            this.btn_acil.TabIndex = 1;
            this.btn_acil.Text = "Çok Acil\r\nİşler";
            this.btn_acil.UseVisualStyleBackColor = true;
            // 
            // btn_grafik
            // 
            this.btn_grafik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_grafik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_grafik.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grafik.ForeColor = System.Drawing.Color.Red;
            this.btn_grafik.Image = ((System.Drawing.Image)(resources.GetObject("btn_grafik.Image")));
            this.btn_grafik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_grafik.Location = new System.Drawing.Point(0, 0);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(67, 199);
            this.btn_grafik.TabIndex = 1;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.UseVisualStyleBackColor = true;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
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
            // kullanıcıAyarlarıToolStripMenuItem
            // 
            this.kullanıcıAyarlarıToolStripMenuItem.Name = "kullanıcıAyarlarıToolStripMenuItem";
            this.kullanıcıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıAyarlarıToolStripMenuItem.Text = "Kullanıcı Ayarları";
            // 
            // projeAyarlarıToolStripMenuItem
            // 
            this.projeAyarlarıToolStripMenuItem.Name = "projeAyarlarıToolStripMenuItem";
            this.projeAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projeAyarlarıToolStripMenuItem.Text = "Proje Ayarları";
            // 
            // excelToToolStripMenuItem
            // 
            this.excelToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEmriToolStripMenuItem1,
            this.faturaToolStripMenuItem});
            this.excelToToolStripMenuItem.Name = "excelToToolStripMenuItem";
            this.excelToToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excelToToolStripMenuItem.Text = "Excel To";
            // 
            // siparişEmriToolStripMenuItem1
            // 
            this.siparişEmriToolStripMenuItem1.Name = "siparişEmriToolStripMenuItem1";
            this.siparişEmriToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.siparişEmriToolStripMenuItem1.Text = "Sipariş Emri";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.faturaToolStripMenuItem.Text = "Fatura";
            // 
            // cmb_bar2
            // 
            this.cmb_bar2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmb_bar2.Name = "cmb_bar2";
            this.cmb_bar2.Size = new System.Drawing.Size(121, 25);
            // 
            // cmb_bar1
            // 
            this.cmb_bar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmb_bar1.Name = "cmb_bar1";
            this.cmb_bar1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel7.Text = "Bar 2 :";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel9.Text = "Bar 1 :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 290);
            this.panel2.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flp1_fatura);
            this.groupBox3.Controls.Add(this.flp1_butce);
            this.groupBox3.Controls.Add(this.flp1_tarih);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1150, 140);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PROJE 1 :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flp2_fatura);
            this.groupBox4.Controls.Add(this.flp2_butce);
            this.groupBox4.Controls.Add(this.flp2_tarih);
            this.groupBox4.Location = new System.Drawing.Point(3, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1150, 140);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PROJE 2 :";
            // 
            // flp1_tarih
            // 
            this.flp1_tarih.Location = new System.Drawing.Point(7, 20);
            this.flp1_tarih.Name = "flp1_tarih";
            this.flp1_tarih.Size = new System.Drawing.Size(1137, 32);
            this.flp1_tarih.TabIndex = 0;
            // 
            // flp1_butce
            // 
            this.flp1_butce.Location = new System.Drawing.Point(7, 56);
            this.flp1_butce.Name = "flp1_butce";
            this.flp1_butce.Size = new System.Drawing.Size(1137, 32);
            this.flp1_butce.TabIndex = 1;
            // 
            // flp1_fatura
            // 
            this.flp1_fatura.Location = new System.Drawing.Point(7, 92);
            this.flp1_fatura.Name = "flp1_fatura";
            this.flp1_fatura.Size = new System.Drawing.Size(1137, 32);
            this.flp1_fatura.TabIndex = 2;
            // 
            // flp2_fatura
            // 
            this.flp2_fatura.Location = new System.Drawing.Point(7, 90);
            this.flp2_fatura.Name = "flp2_fatura";
            this.flp2_fatura.Size = new System.Drawing.Size(1137, 32);
            this.flp2_fatura.TabIndex = 5;
            // 
            // flp2_butce
            // 
            this.flp2_butce.Location = new System.Drawing.Point(7, 54);
            this.flp2_butce.Name = "flp2_butce";
            this.flp2_butce.Size = new System.Drawing.Size(1137, 32);
            this.flp2_butce.TabIndex = 4;
            // 
            // flp2_tarih
            // 
            this.flp2_tarih.Location = new System.Drawing.Point(7, 18);
            this.flp2_tarih.Name = "flp2_tarih";
            this.flp2_tarih.Size = new System.Drawing.Size(1137, 32);
            this.flp2_tarih.TabIndex = 3;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 732);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaEkran";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Manuel ERP";
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
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.pnlDGW.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_maliyet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_faturalar)).EndInit();
            this.pnlGrafik.ResumeLayout(false);
            this.pnlGrafik.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_maliyetler;
        private System.Windows.Forms.Button btn_acil;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.Panel pnlGrafik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmb_proje_no;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripComboBox cmb_yil;
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
        private System.Windows.Forms.Panel pnlDGW;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dg_maliyet;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid dgw_faturalar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem btn_ayar;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişEmriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flp2_fatura;
        private System.Windows.Forms.FlowLayoutPanel flp2_butce;
        private System.Windows.Forms.FlowLayoutPanel flp2_tarih;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flp1_fatura;
        private System.Windows.Forms.FlowLayoutPanel flp1_butce;
        private System.Windows.Forms.FlowLayoutPanel flp1_tarih;
        private System.Windows.Forms.ToolStripComboBox cmb_bar2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox cmb_bar1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
    }
}

