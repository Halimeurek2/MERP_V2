namespace MERP_V2
{
    partial class FaturaDuzenle
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
            this.cmb_durum = new MetroFramework.Controls.MetroCheckBox();
            this.rbKesilen = new MetroFramework.Controls.MetroRadioButton();
            this.rbGelen = new MetroFramework.Controls.MetroRadioButton();
            this.cmb_se = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.rcb_aciklama = new System.Windows.Forms.RichTextBox();
            this.lbl_ftr_tipi = new MetroFramework.Controls.MetroLabel();
            this.cmb_ftr_tip = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_avans = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmb_birim = new MetroFramework.Controls.MetroComboBox();
            this.lbl_tutar = new MetroFramework.Controls.MetroLabel();
            this.txt_ftr_tutar = new MetroFramework.Controls.MetroTextBox();
            this.date_alarm = new MetroFramework.Controls.MetroDateTime();
            this.ck_alarm = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_ftr_vade = new MetroFramework.Controls.MetroTextBox();
            this.lbl_tarih = new MetroFramework.Controls.MetroLabel();
            this.cmb_firma = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_fatura_no = new MetroFramework.Controls.MetroTextBox();
            this.btn_duzenle = new MetroFramework.Controls.MetroButton();
            this.lbl_tip = new MetroFramework.Controls.MetroLabel();
            this.lbl_id = new MetroFramework.Controls.MetroLabel();
            this.date_odendi = new MetroFramework.Controls.MetroDateTime();
            this.date_ftr_tarih = new MetroFramework.Controls.MetroDateTime();
            this.mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
            this.cmb_gelense = new MetroFramework.Controls.MetroComboBox();
            this.cmb_projeNo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_durum
            // 
            this.cmb_durum.AutoSize = true;
            this.cmb_durum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_durum.Location = new System.Drawing.Point(17, 71);
            this.cmb_durum.Name = "cmb_durum";
            this.cmb_durum.Size = new System.Drawing.Size(66, 15);
            this.cmb_durum.Style = MetroFramework.MetroColorStyle.Red;
            this.cmb_durum.TabIndex = 74;
            this.cmb_durum.Text = "ÖDENDİ";
            this.cmb_durum.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmb_durum.UseCustomBackColor = true;
            this.cmb_durum.UseCustomForeColor = true;
            this.cmb_durum.UseSelectable = true;
            this.cmb_durum.UseStyleColors = true;
            this.cmb_durum.CheckedChanged += new System.EventHandler(this.cmb_durum_CheckedChanged);
            // 
            // rbKesilen
            // 
            this.rbKesilen.AutoSize = true;
            this.rbKesilen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbKesilen.Location = new System.Drawing.Point(132, 111);
            this.rbKesilen.Name = "rbKesilen";
            this.rbKesilen.Size = new System.Drawing.Size(96, 15);
            this.rbKesilen.Style = MetroFramework.MetroColorStyle.Red;
            this.rbKesilen.TabIndex = 76;
            this.rbKesilen.Text = "Kesilen Fatura";
            this.rbKesilen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbKesilen.UseCustomBackColor = true;
            this.rbKesilen.UseCustomForeColor = true;
            this.rbKesilen.UseSelectable = true;
            this.rbKesilen.UseStyleColors = true;
            this.rbKesilen.CheckedChanged += new System.EventHandler(this.rbKesilen_CheckedChanged);
            // 
            // rbGelen
            // 
            this.rbGelen.AutoSize = true;
            this.rbGelen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbGelen.Location = new System.Drawing.Point(17, 111);
            this.rbGelen.Name = "rbGelen";
            this.rbGelen.Size = new System.Drawing.Size(89, 15);
            this.rbGelen.Style = MetroFramework.MetroColorStyle.Red;
            this.rbGelen.TabIndex = 75;
            this.rbGelen.Text = "Gelen Fatura";
            this.rbGelen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbGelen.UseCustomBackColor = true;
            this.rbGelen.UseCustomForeColor = true;
            this.rbGelen.UseSelectable = true;
            this.rbGelen.UseStyleColors = true;
            // 
            // cmb_se
            // 
            this.cmb_se.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_se.FormattingEnabled = true;
            this.cmb_se.ItemHeight = 23;
            this.cmb_se.Items.AddRange(new object[] {
            ""});
            this.cmb_se.Location = new System.Drawing.Point(245, 106);
            this.cmb_se.Name = "cmb_se";
            this.cmb_se.Size = new System.Drawing.Size(156, 29);
            this.cmb_se.Style = MetroFramework.MetroColorStyle.Red;
            this.cmb_se.TabIndex = 78;
            this.cmb_se.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmb_se.UseCustomBackColor = true;
            this.cmb_se.UseCustomForeColor = true;
            this.cmb_se.UseSelectable = true;
            this.cmb_se.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel8.Location = new System.Drawing.Point(34, 528);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel8.TabIndex = 122;
            this.metroLabel8.Text = "Açıklama :";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // rcb_aciklama
            // 
            this.rcb_aciklama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rcb_aciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rcb_aciklama.Location = new System.Drawing.Point(132, 536);
            this.rcb_aciklama.Name = "rcb_aciklama";
            this.rcb_aciklama.Size = new System.Drawing.Size(219, 87);
            this.rcb_aciklama.TabIndex = 121;
            this.rcb_aciklama.Text = "";
            // 
            // lbl_ftr_tipi
            // 
            this.lbl_ftr_tipi.AutoSize = true;
            this.lbl_ftr_tipi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ftr_tipi.Location = new System.Drawing.Point(25, 498);
            this.lbl_ftr_tipi.Name = "lbl_ftr_tipi";
            this.lbl_ftr_tipi.Size = new System.Drawing.Size(78, 19);
            this.lbl_ftr_tipi.Style = MetroFramework.MetroColorStyle.Red;
            this.lbl_ftr_tipi.TabIndex = 120;
            this.lbl_ftr_tipi.Text = "Fatura Tipi :";
            this.lbl_ftr_tipi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_ftr_tipi.UseCustomBackColor = true;
            this.lbl_ftr_tipi.UseCustomForeColor = true;
            this.lbl_ftr_tipi.UseStyleColors = true;
            // 
            // cmb_ftr_tip
            // 
            this.cmb_ftr_tip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_ftr_tip.FormattingEnabled = true;
            this.cmb_ftr_tip.ItemHeight = 23;
            this.cmb_ftr_tip.Items.AddRange(new object[] {
            "",
            "Mekanik",
            "Elektronik",
            "Genel Giderler",
            "Kesilen"});
            this.cmb_ftr_tip.Location = new System.Drawing.Point(132, 493);
            this.cmb_ftr_tip.Name = "cmb_ftr_tip";
            this.cmb_ftr_tip.Size = new System.Drawing.Size(184, 29);
            this.cmb_ftr_tip.Style = MetroFramework.MetroColorStyle.Red;
            this.cmb_ftr_tip.TabIndex = 119;
            this.cmb_ftr_tip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmb_ftr_tip.UseCustomBackColor = true;
            this.cmb_ftr_tip.UseCustomForeColor = true;
            this.cmb_ftr_tip.UseSelectable = true;
            this.cmb_ftr_tip.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel5.Location = new System.Drawing.Point(12, 460);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 118;
            this.metroLabel5.Text = "Fatura Avans :";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // txt_avans
            // 
            // 
            // 
            // 
            this.txt_avans.CustomButton.Image = null;
            this.txt_avans.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txt_avans.CustomButton.Name = "";
            this.txt_avans.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_avans.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_avans.CustomButton.TabIndex = 1;
            this.txt_avans.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_avans.CustomButton.UseSelectable = true;
            this.txt_avans.CustomButton.Visible = false;
            this.txt_avans.Lines = new string[0];
            this.txt_avans.Location = new System.Drawing.Point(132, 458);
            this.txt_avans.MaxLength = 32767;
            this.txt_avans.Name = "txt_avans";
            this.txt_avans.PasswordChar = '\0';
            this.txt_avans.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_avans.SelectedText = "";
            this.txt_avans.SelectionLength = 0;
            this.txt_avans.SelectionStart = 0;
            this.txt_avans.ShortcutsEnabled = true;
            this.txt_avans.Size = new System.Drawing.Size(184, 23);
            this.txt_avans.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_avans.TabIndex = 117;
            this.txt_avans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_avans.UseCustomBackColor = true;
            this.txt_avans.UseCustomForeColor = true;
            this.txt_avans.UseSelectable = true;
            this.txt_avans.UseStyleColors = true;
            this.txt_avans.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_avans.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel9.Location = new System.Drawing.Point(56, 422);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(47, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel9.TabIndex = 116;
            this.metroLabel9.Text = "Birim :";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            this.metroLabel9.UseStyleColors = true;
            // 
            // cmb_birim
            // 
            this.cmb_birim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_birim.FormattingEnabled = true;
            this.cmb_birim.ItemHeight = 23;
            this.cmb_birim.Items.AddRange(new object[] {
            "",
            "USD",
            "EUR",
            "TRY",
            "CHF",
            "GBP"});
            this.cmb_birim.Location = new System.Drawing.Point(132, 417);
            this.cmb_birim.Name = "cmb_birim";
            this.cmb_birim.Size = new System.Drawing.Size(184, 29);
            this.cmb_birim.Style = MetroFramework.MetroColorStyle.Red;
            this.cmb_birim.TabIndex = 115;
            this.cmb_birim.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmb_birim.UseCustomBackColor = true;
            this.cmb_birim.UseCustomForeColor = true;
            this.cmb_birim.UseSelectable = true;
            this.cmb_birim.UseStyleColors = true;
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_tutar.Location = new System.Drawing.Point(13, 384);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(90, 19);
            this.lbl_tutar.Style = MetroFramework.MetroColorStyle.Red;
            this.lbl_tutar.TabIndex = 114;
            this.lbl_tutar.Text = "Fatura Tutarı :";
            this.lbl_tutar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_tutar.UseCustomBackColor = true;
            this.lbl_tutar.UseCustomForeColor = true;
            this.lbl_tutar.UseStyleColors = true;
            // 
            // txt_ftr_tutar
            // 
            // 
            // 
            // 
            this.txt_ftr_tutar.CustomButton.Image = null;
            this.txt_ftr_tutar.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txt_ftr_tutar.CustomButton.Name = "";
            this.txt_ftr_tutar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ftr_tutar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ftr_tutar.CustomButton.TabIndex = 1;
            this.txt_ftr_tutar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ftr_tutar.CustomButton.UseSelectable = true;
            this.txt_ftr_tutar.CustomButton.Visible = false;
            this.txt_ftr_tutar.Lines = new string[0];
            this.txt_ftr_tutar.Location = new System.Drawing.Point(132, 382);
            this.txt_ftr_tutar.MaxLength = 32767;
            this.txt_ftr_tutar.Name = "txt_ftr_tutar";
            this.txt_ftr_tutar.PasswordChar = '\0';
            this.txt_ftr_tutar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ftr_tutar.SelectedText = "";
            this.txt_ftr_tutar.SelectionLength = 0;
            this.txt_ftr_tutar.SelectionStart = 0;
            this.txt_ftr_tutar.ShortcutsEnabled = true;
            this.txt_ftr_tutar.Size = new System.Drawing.Size(184, 23);
            this.txt_ftr_tutar.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_ftr_tutar.TabIndex = 113;
            this.txt_ftr_tutar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_ftr_tutar.UseCustomBackColor = true;
            this.txt_ftr_tutar.UseCustomForeColor = true;
            this.txt_ftr_tutar.UseSelectable = true;
            this.txt_ftr_tutar.UseStyleColors = true;
            this.txt_ftr_tutar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ftr_tutar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // date_alarm
            // 
            this.date_alarm.Location = new System.Drawing.Point(132, 341);
            this.date_alarm.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_alarm.Name = "date_alarm";
            this.date_alarm.Size = new System.Drawing.Size(184, 29);
            this.date_alarm.TabIndex = 112;
            // 
            // ck_alarm
            // 
            this.ck_alarm.AutoSize = true;
            this.ck_alarm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ck_alarm.Location = new System.Drawing.Point(338, 349);
            this.ck_alarm.Name = "ck_alarm";
            this.ck_alarm.Size = new System.Drawing.Size(63, 15);
            this.ck_alarm.Style = MetroFramework.MetroColorStyle.Red;
            this.ck_alarm.TabIndex = 111;
            this.ck_alarm.Text = "ALARM";
            this.ck_alarm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ck_alarm.UseCustomBackColor = true;
            this.ck_alarm.UseCustomForeColor = true;
            this.ck_alarm.UseSelectable = true;
            this.ck_alarm.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel3.Location = new System.Drawing.Point(57, 305);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 110;
            this.metroLabel3.Text = "Vade :";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // txt_ftr_vade
            // 
            // 
            // 
            // 
            this.txt_ftr_vade.CustomButton.Image = null;
            this.txt_ftr_vade.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txt_ftr_vade.CustomButton.Name = "";
            this.txt_ftr_vade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ftr_vade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ftr_vade.CustomButton.TabIndex = 1;
            this.txt_ftr_vade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ftr_vade.CustomButton.UseSelectable = true;
            this.txt_ftr_vade.CustomButton.Visible = false;
            this.txt_ftr_vade.Lines = new string[0];
            this.txt_ftr_vade.Location = new System.Drawing.Point(132, 306);
            this.txt_ftr_vade.MaxLength = 32767;
            this.txt_ftr_vade.Name = "txt_ftr_vade";
            this.txt_ftr_vade.PasswordChar = '\0';
            this.txt_ftr_vade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ftr_vade.SelectedText = "";
            this.txt_ftr_vade.SelectionLength = 0;
            this.txt_ftr_vade.SelectionStart = 0;
            this.txt_ftr_vade.ShortcutsEnabled = true;
            this.txt_ftr_vade.Size = new System.Drawing.Size(184, 23);
            this.txt_ftr_vade.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_ftr_vade.TabIndex = 109;
            this.txt_ftr_vade.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_ftr_vade.UseCustomBackColor = true;
            this.txt_ftr_vade.UseCustomForeColor = true;
            this.txt_ftr_vade.UseSelectable = true;
            this.txt_ftr_vade.UseStyleColors = true;
            this.txt_ftr_vade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ftr_vade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ftr_vade.TextChanged += new System.EventHandler(this.txt_ftr_vade_TextChanged);
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_tarih.Location = new System.Drawing.Point(14, 267);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(89, 19);
            this.lbl_tarih.Style = MetroFramework.MetroColorStyle.Red;
            this.lbl_tarih.TabIndex = 108;
            this.lbl_tarih.Text = "Fatura Tarihi :";
            this.lbl_tarih.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_tarih.UseCustomBackColor = true;
            this.lbl_tarih.UseCustomForeColor = true;
            this.lbl_tarih.UseStyleColors = true;
            // 
            // cmb_firma
            // 
            this.cmb_firma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_firma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_firma.BackColor = System.Drawing.Color.White;
            this.cmb_firma.FormattingEnabled = true;
            this.cmb_firma.Location = new System.Drawing.Point(132, 232);
            this.cmb_firma.Name = "cmb_firma";
            this.cmb_firma.Size = new System.Drawing.Size(184, 21);
            this.cmb_firma.TabIndex = 106;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel6.Location = new System.Drawing.Point(26, 231);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 105;
            this.metroLabel6.Text = "Firma İsmi :";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel2.Location = new System.Drawing.Point(28, 195);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 104;
            this.metroLabel2.Text = "Fatura No :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(34, 157);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 103;
            this.metroLabel1.Text = "Proje No :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_fatura_no
            // 
            // 
            // 
            // 
            this.txt_fatura_no.CustomButton.Image = null;
            this.txt_fatura_no.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txt_fatura_no.CustomButton.Name = "";
            this.txt_fatura_no.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fatura_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fatura_no.CustomButton.TabIndex = 1;
            this.txt_fatura_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fatura_no.CustomButton.UseSelectable = true;
            this.txt_fatura_no.CustomButton.Visible = false;
            this.txt_fatura_no.Lines = new string[0];
            this.txt_fatura_no.Location = new System.Drawing.Point(132, 197);
            this.txt_fatura_no.MaxLength = 32767;
            this.txt_fatura_no.Name = "txt_fatura_no";
            this.txt_fatura_no.PasswordChar = '\0';
            this.txt_fatura_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fatura_no.SelectedText = "";
            this.txt_fatura_no.SelectionLength = 0;
            this.txt_fatura_no.SelectionStart = 0;
            this.txt_fatura_no.ShortcutsEnabled = true;
            this.txt_fatura_no.Size = new System.Drawing.Size(184, 23);
            this.txt_fatura_no.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_fatura_no.TabIndex = 102;
            this.txt_fatura_no.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_fatura_no.UseCustomBackColor = true;
            this.txt_fatura_no.UseCustomForeColor = true;
            this.txt_fatura_no.UseSelectable = true;
            this.txt_fatura_no.UseStyleColors = true;
            this.txt_fatura_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fatura_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Highlight = true;
            this.btn_duzenle.Location = new System.Drawing.Point(285, 636);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(116, 43);
            this.btn_duzenle.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_duzenle.TabIndex = 123;
            this.btn_duzenle.Text = "DÜZENLE";
            this.btn_duzenle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_duzenle.UseCustomBackColor = true;
            this.btn_duzenle.UseCustomForeColor = true;
            this.btn_duzenle.UseSelectable = true;
            this.btn_duzenle.UseStyleColors = true;
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_tip.Location = new System.Drawing.Point(374, 79);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(27, 19);
            this.lbl_tip.Style = MetroFramework.MetroColorStyle.Red;
            this.lbl_tip.TabIndex = 127;
            this.lbl_tip.Text = "Tip";
            this.lbl_tip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_tip.UseCustomBackColor = true;
            this.lbl_tip.UseCustomForeColor = true;
            this.lbl_tip.UseStyleColors = true;
            this.lbl_tip.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_id.Location = new System.Drawing.Point(380, 60);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 19);
            this.lbl_id.Style = MetroFramework.MetroColorStyle.Red;
            this.lbl_id.TabIndex = 126;
            this.lbl_id.Text = "ID";
            this.lbl_id.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_id.UseCustomBackColor = true;
            this.lbl_id.UseCustomForeColor = true;
            this.lbl_id.UseStyleColors = true;
            this.lbl_id.Visible = false;
            // 
            // date_odendi
            // 
            this.date_odendi.Location = new System.Drawing.Point(132, 69);
            this.date_odendi.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_odendi.Name = "date_odendi";
            this.date_odendi.Size = new System.Drawing.Size(156, 29);
            this.date_odendi.Style = MetroFramework.MetroColorStyle.Red;
            this.date_odendi.TabIndex = 128;
            this.date_odendi.UseCustomBackColor = true;
            this.date_odendi.UseCustomForeColor = true;
            this.date_odendi.UseStyleColors = true;
            this.date_odendi.Visible = false;
            // 
            // date_ftr_tarih
            // 
            this.date_ftr_tarih.Location = new System.Drawing.Point(132, 267);
            this.date_ftr_tarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_ftr_tarih.Name = "date_ftr_tarih";
            this.date_ftr_tarih.Size = new System.Drawing.Size(184, 29);
            this.date_ftr_tarih.Style = MetroFramework.MetroColorStyle.Red;
            this.date_ftr_tarih.TabIndex = 129;
            this.date_ftr_tarih.UseCustomBackColor = true;
            this.date_ftr_tarih.UseCustomForeColor = true;
            this.date_ftr_tarih.UseStyleColors = true;
            // 
            // mySqlCommand
            // 
            this.mySqlCommand.CacheAge = 60;
            this.mySqlCommand.Connection = this.mySqlConnection;
            this.mySqlCommand.EnableCaching = false;
            this.mySqlCommand.Transaction = null;
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "server=localhost;database=merp_dbv1;user id=root;password=root";
            // 
            // cmb_gelense
            // 
            this.cmb_gelense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_gelense.FormattingEnabled = true;
            this.cmb_gelense.ItemHeight = 23;
            this.cmb_gelense.Items.AddRange(new object[] {
            ""});
            this.cmb_gelense.Location = new System.Drawing.Point(245, 106);
            this.cmb_gelense.Name = "cmb_gelense";
            this.cmb_gelense.Size = new System.Drawing.Size(156, 29);
            this.cmb_gelense.Style = MetroFramework.MetroColorStyle.Red;
            this.cmb_gelense.TabIndex = 130;
            this.cmb_gelense.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmb_gelense.UseCustomBackColor = true;
            this.cmb_gelense.UseCustomForeColor = true;
            this.cmb_gelense.UseSelectable = true;
            this.cmb_gelense.UseStyleColors = true;
            this.cmb_gelense.Visible = false;
            // 
            // cmb_projeNo
            // 
            this.cmb_projeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_projeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_projeNo.BackColor = System.Drawing.Color.White;
            this.cmb_projeNo.FormattingEnabled = true;
            this.cmb_projeNo.Location = new System.Drawing.Point(132, 157);
            this.cmb_projeNo.Name = "cmb_projeNo";
            this.cmb_projeNo.Size = new System.Drawing.Size(184, 21);
            this.cmb_projeNo.TabIndex = 131;
            // 
            // FaturaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 693);
            this.Controls.Add(this.cmb_projeNo);
            this.Controls.Add(this.cmb_gelense);
            this.Controls.Add(this.date_ftr_tarih);
            this.Controls.Add(this.date_odendi);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.rcb_aciklama);
            this.Controls.Add(this.lbl_ftr_tipi);
            this.Controls.Add(this.cmb_ftr_tip);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_avans);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.cmb_birim);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.txt_ftr_tutar);
            this.Controls.Add(this.date_alarm);
            this.Controls.Add(this.ck_alarm);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_ftr_vade);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.cmb_firma);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_fatura_no);
            this.Controls.Add(this.cmb_se);
            this.Controls.Add(this.rbKesilen);
            this.Controls.Add(this.rbGelen);
            this.Controls.Add(this.cmb_durum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaturaDuzenle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Fatura Düzenle";
            this.Load += new System.EventHandler(this.FaturaDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroCheckBox cmb_durum;
        public System.Windows.Forms.ComboBox cmb_firma;
        public MetroFramework.Controls.MetroButton btn_duzenle;
        public MetroFramework.Controls.MetroLabel lbl_tip;
        public MetroFramework.Controls.MetroLabel lbl_id;
        public MetroFramework.Controls.MetroRadioButton rbKesilen;
        public MetroFramework.Controls.MetroRadioButton rbGelen;
        public MetroFramework.Controls.MetroComboBox cmb_se;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        public System.Windows.Forms.RichTextBox rcb_aciklama;
        public MetroFramework.Controls.MetroLabel lbl_ftr_tipi;
        public MetroFramework.Controls.MetroComboBox cmb_ftr_tip;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroTextBox txt_avans;
        public MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroComboBox cmb_birim;
        public MetroFramework.Controls.MetroLabel lbl_tutar;
        public MetroFramework.Controls.MetroTextBox txt_ftr_tutar;
        public MetroFramework.Controls.MetroDateTime date_alarm;
        public MetroFramework.Controls.MetroCheckBox ck_alarm;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox txt_ftr_vade;
        public MetroFramework.Controls.MetroLabel lbl_tarih;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox txt_fatura_no;
        public MetroFramework.Controls.MetroDateTime date_odendi;
        public MetroFramework.Controls.MetroDateTime date_ftr_tarih;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection;
        public MetroFramework.Controls.MetroComboBox cmb_gelense;
        public System.Windows.Forms.ComboBox cmb_projeNo;
    }
}