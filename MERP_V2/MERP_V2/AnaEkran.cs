using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace MERP_V2
{
    public partial class AnaEkran : MetroFramework.Forms.MetroForm
    {
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader myReader;

        HarrProgressBar pgb1 = new HarrProgressBar();
        HarrProgressBar pgb2 = new HarrProgressBar();
        HarrProgressBar pgb3 = new HarrProgressBar();
        HarrProgressBar pgb4 = new HarrProgressBar();
        HarrProgressBar pgb5 = new HarrProgressBar();
        HarrProgressBar pgb6 = new HarrProgressBar();

        int index = 0;

        int btn1_Flag = 0;
        int btn2_Flag = 0;
        int btn3_Flag = 0;

        int elemanSayisiG = 0;
        int elemanSayisiK = 0;

        int elemanSayisiYap = 0;
        int elemanSayisiAl = 0;

        string proje_butce;
        string harcama_toplam;
        string gelenFtr;
        string kesilenFtr;

        int BarKesilenftr;
        int BarZaman;
        int BarButce;

        public static float[] sumG = new float[2000];
        public static DateTime[] monthG = new DateTime[2000];

        public static float[] sumK = new float[2000];
        public static DateTime[] monthK = new DateTime[2000];

        public static float[] alOdemeler = new float[2000];
        public static DateTime[] monthAlOdemeler = new DateTime[2000];

        public static float[] yapOdemeler = new float[2000];
        public static DateTime[] monthYapOdemeler = new DateTime[2000];

        public static float[] odemeler = new float[7];
        public static DateTime[] monthOdemeler = new DateTime[7];

        public static float[] NewsumG = new float[12];
        public static float[] NewsumK = new float[12];
        public static float[] Newodemeler = new float[12];
        public static float[] NewAlOdemeler = new float[12];
        public static float[] NewYapOdemeler = new float[12];

        public AnaEkran()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------PROJE NO----------------------------------------------------------
            mySqlCommand.CommandText = "SELECT DISTINCT proje_no FROM db_projeler";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                cmb_proje_no.Items.Add(myReader["proje_no"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            cmb_yil.Text = "2017";
            cmb_proje_no.Text = "910.20";
            //-----------------------------------------------------------------------------------------------------------------
        }

        private void faturaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaGiris frmFaturaGiris = new FaturaGiris();
            frmFaturaGiris.Show();
        }

        private void faturalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Faturalar frmFaturalar = new Faturalar();
            frmFaturalar.Show();
        }

        private void projeGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeGiris frmProjeGiris = new ProjeGiris();
            frmProjeGiris.Show();
        }

        private void projelerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Projeler frmProjeler = new Projeler();
            frmProjeler.Show();
        }

        private void siparişEmriGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisEmriGiris frmSiparisEmriGiris = new SiparisEmriGiris();
            frmSiparisEmriGiris.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisEmirleri frmSiparisEmirleri = new SiparisEmirleri();
            frmSiparisEmirleri.Show();
        }

        private void projeyeGöreRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeyeGoreRapor frmProjeyeGoreRapor = new ProjeyeGoreRapor();
            frmProjeyeGoreRapor.Show();
        }

        private void btn_grafik_Click(object sender, EventArgs e)
        {
            if (btn3_Flag == 0)
            {
                pnlGrafik.Dock = DockStyle.Fill;
                pnlGrafik.Visible = true;
                btn3_Flag = 1;
            }
            else
            {
                pnlGrafik.Visible = false;
                btn3_Flag = 0;
            }
            //if (pnlAcil.Visible == true)
            //{
            //    pnlAcil.Visible = false;
            //    btn2_Flag = 0;
            //}
            if (pnlDGW.Visible == true)
            {
                pnlDGW.Visible = false;
                btn1_Flag = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn1_Flag == 0)
            {
                maliyet_hesapla();
                pnlDGW.Dock = DockStyle.Fill;
                pnlDGW.Visible = true;

                btn1_Flag = 1;
            }
            else
            {
                pnlDGW.Visible = false;
                btn1_Flag = 0;
            }

            //if (pnlAcil.Visible == true)
            //{
            //    pnlAcil.Visible = false;
            //    btn2_Flag = 0;
            //}
            if (pnlGrafik.Visible == true)
            {
                pnlGrafik.Visible = false;
                btn3_Flag = 0;
            }
        }

        public void maliyet_hesapla()
        {
           mySqlCommand.CommandText  = "select fatura_proje_no as PROJE_NO, sum(case when fatura_birim = 'TRY' then fatura_tutari else 0 end) as TRY, " +
                                       "sum(case when fatura_birim = 'EUR' then fatura_tutari else 0 end) as EUR ," +
                                       "sum(case when fatura_birim = 'USD' then fatura_tutari else 0 end) as USD , " +
                                       "sum(case when fatura_birim = 'GBP' then fatura_tutari else 0 end) as GBP , " +
                                       "sum(fatura_euro) as Toplam_Euro " +
                                       "from db_faturalar where fatura_tipi = 'G' group by fatura_proje_no";
            da = new MySqlDataAdapter(mySqlCommand);
            dt = new DataTable();
            da.Fill(dt);
            dg_maliyet.DataSource = dt;
            dg_maliyet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_maliyet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dg_maliyet.Columns[1].DefaultCellStyle.Format = "c2";
            dg_maliyet.Columns[2].DefaultCellStyle.Format = "c2";
            dg_maliyet.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");
            dg_maliyet.Columns[3].DefaultCellStyle.Format = "c2";
            dg_maliyet.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            dg_maliyet.Columns[4].DefaultCellStyle.Format = "c2";
            dg_maliyet.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
            dg_maliyet.Columns[5].DefaultCellStyle.Format = "c2";
            dg_maliyet.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");

            mySqlCommand.CommandText = "select fatura_proje_no as PROJE_NO, sum(case when fatura_birim = 'TRY' then fatura_tutari else 0 end) as TRY, " +
                                       "sum(case when fatura_birim = 'EUR' then fatura_tutari else 0 end) as EUR ," +
                                       "sum(case when fatura_birim = 'USD' then fatura_tutari else 0 end) as USD , " +
                                       "sum(case when fatura_birim = 'GBP' then fatura_tutari else 0 end) as GBP , " +
                                       "sum(fatura_euro) as Toplam_Euro " +
                                       "from db_faturalar where fatura_tipi = 'K' group by fatura_proje_no";
            da = new MySqlDataAdapter(mySqlCommand);
            dt = new DataTable();
            da.Fill(dt);
            dgw_faturalar.DataSource = dt;
            dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_faturalar.AutoSizeColumnsMode =  DataGridViewAutoSizeColumnsMode.Fill;
            dgw_faturalar.Columns[1].DefaultCellStyle.Format = "c2";
            dgw_faturalar.Columns[2].DefaultCellStyle.Format = "c2";
            dgw_faturalar.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");
            dgw_faturalar.Columns[3].DefaultCellStyle.Format = "c2";
            dgw_faturalar.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            dgw_faturalar.Columns[4].DefaultCellStyle.Format = "c2";
            dgw_faturalar.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
            dgw_faturalar.Columns[5].DefaultCellStyle.Format = "c2";
            dgw_faturalar.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");

            dgw_faturalar.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman",12,FontStyle.Bold);
            dg_maliyet.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold);
        }

        public void ChartControl()
        {
            Array.Clear(monthG, 0, 2000);
            Array.Clear(sumG, 0, 2000);
            Array.Clear(monthK, 0, 2000);
            Array.Clear(sumK, 0, 2000);
            Array.Clear(odemeler, 0, 7);
            Array.Clear(monthOdemeler, 0, 7);
            Array.Clear(NewsumG, 0, 12);
            Array.Clear(NewsumK, 0, 12);
            Array.Clear(Newodemeler, 0, 12);

            Array.Clear(NewAlOdemeler, 0, 12);
            Array.Clear(NewYapOdemeler, 0, 12);
            Array.Clear(alOdemeler, 0, 2000);
            Array.Clear(yapOdemeler, 0, 2000);
            Array.Clear(monthAlOdemeler, 0, 2000);
            Array.Clear(monthYapOdemeler, 0, 2000);

            index = 0;
            elemanSayisiG = 0;
            elemanSayisiK = 0;
            elemanSayisiYap = 0;
            elemanSayisiAl = 0;

            mySqlConnection.Close();
            mySqlConnection.Open();

            try
            {
                mySqlCommand.CommandText = "SELECT fatura_tarih AS Month, fatura_euro AS EURO FROM db_faturalar WHERE fatura_tipi='G' and fatura_proje_no ='" + cmb_proje_no.Text + "'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    monthG[index] = Convert.ToDateTime(myReader.GetString(0));
                    sumG[index] = (float)Convert.ToDouble(myReader.GetString(1));
                    index++;
                    elemanSayisiG++;
                }
                myReader.Close();
            }
            catch
            {
                myReader.Close();
            }

            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT fatura_tarih AS Month, fatura_euro AS EURO FROM db_faturalar WHERE fatura_tipi='K' and fatura_proje_no ='" + cmb_proje_no.Text + "'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    monthK[index] = Convert.ToDateTime(myReader.GetString(0));
                    sumK[index] = (float)Convert.ToDouble(myReader.GetString(1));
                    index++;
                    elemanSayisiK++;
                }
                myReader.Close();
            }
            catch
            {
                myReader.Close();
            }

            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT fatura_tarih AS Month, fatura_euro AS EURO FROM db_faturalar WHERE fatura_tipi='G' and fatura_proje_no ='" + cmb_proje_no.Text + "' and fatura_durum='ODENMEDI'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    monthYapOdemeler[index] = Convert.ToDateTime(myReader.GetString(0));
                    yapOdemeler[index] = (float)Convert.ToDouble(myReader.GetString(1));
                    index++;
                    elemanSayisiYap++;
                }
                myReader.Close();
            }
            catch
            {
                myReader.Close();
            }

            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT fatura_tarih AS Month, fatura_euro AS EURO FROM db_faturalar WHERE fatura_tipi='K' and fatura_proje_no ='" + cmb_proje_no.Text + "' and fatura_durum='ODENMEDI'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    monthAlOdemeler[index] = Convert.ToDateTime(myReader.GetString(0));
                    alOdemeler[index] = (float)Convert.ToDouble(myReader.GetString(1));
                    index++;
                    elemanSayisiAl++;
                }
                myReader.Close();
            }
            catch
            {
                myReader.Close();
            }

            try
            {
                mySqlCommand.CommandText = "SELECT * FROM db_projeler WHERE proje_no='" + cmb_proje_no.Text + "'";
                myReader = mySqlCommand.ExecuteReader();

                while (myReader.Read())
                {
                    odemeler[0] = (float)Convert.ToDouble(myReader.GetString(17));
                    monthOdemeler[0] = Convert.ToDateTime(myReader.GetString(18));
                    odemeler[1] = (float)Convert.ToDouble(myReader.GetString(19));
                    monthOdemeler[1] = Convert.ToDateTime(myReader.GetString(20));
                    odemeler[2] = (float)Convert.ToDouble(myReader.GetString(21));
                    monthOdemeler[2] = Convert.ToDateTime(myReader.GetString(22));
                    odemeler[3] = (float)Convert.ToDouble(myReader.GetString(23));
                    monthOdemeler[3] = Convert.ToDateTime(myReader.GetString(24));
                    odemeler[4] = (float)Convert.ToDouble(myReader.GetString(25));
                    monthOdemeler[4] = Convert.ToDateTime(myReader.GetString(26));
                    odemeler[5] = (float)Convert.ToDouble(myReader.GetString(27));
                    monthOdemeler[5] = Convert.ToDateTime(myReader.GetString(28));
                    odemeler[6] = (float)Convert.ToDouble(myReader.GetString(29));
                    monthOdemeler[6] = Convert.ToDateTime(myReader.GetString(30));
                }


                myReader.Close();

                /*
                 * Bubble Sort
                 */
                UInt32 row = 0, column = 0;
                DateTime tempDate = new DateTime();
                float tempBill = 0;
                for (row = 0; row < elemanSayisiG; row++)
                    for (column = 0; column < elemanSayisiG - 1; column++)
                    {
                        if (Int32.Parse(monthG[column].ToString("yyyyMMdd")) > Int32.Parse(monthG[column + 1].ToString("yyyyMMdd")))
                        {
                            tempDate = monthG[column];
                            tempBill = sumG[column];

                            monthG[column] = monthG[column + 1];
                            monthG[column + 1] = tempDate;

                            sumG[column] = sumG[column + 1];
                            sumG[column + 1] = tempBill;
                        }
                    }
                tempBill = 0;
                for (row = 0; row < elemanSayisiK; row++)
                    for (column = 0; column < elemanSayisiK - 1; column++)
                    {
                        if (Int32.Parse(monthK[column].ToString("yyyyMMdd")) > Int32.Parse(monthK[column + 1].ToString("yyyyMMdd")))
                        {
                            tempDate = monthK[column];
                            tempBill = sumK[column];

                            monthK[column] = monthK[column + 1];
                            monthK[column + 1] = tempDate;

                            sumK[column] = sumK[column + 1];
                            sumK[column + 1] = tempBill;
                        }
                    }



                tempDate = new DateTime();
                tempBill = 0;

                for (row = 0; row < odemeler.Length; row++)
                    for (column = 0; column < odemeler.Length - 1; column++)
                    {
                        if (Int32.Parse(monthOdemeler[column].ToString("yyyyMMdd")) > Int32.Parse(monthOdemeler[column + 1].ToString("yyyyMMdd")))
                        {
                            tempDate = monthOdemeler[column];
                            tempBill = odemeler[column];

                            monthOdemeler[column] = monthOdemeler[column + 1];
                            monthOdemeler[column + 1] = tempDate;

                            odemeler[column] = odemeler[column + 1];
                            odemeler[column + 1] = tempBill;
                        }
                    }
            }
            catch
            {
                myReader.Close();
            }

            Int32 month;
            for (month = 0; month < elemanSayisiG; month++)
            {
                if (Int32.Parse(monthG[month].ToString("yyyy")) == Int32.Parse(cmb_yil.Text))
                    NewsumG[Int32.Parse(monthG[month].ToString("MM")) - 1] += sumG[month];
            }

            for (month = 0; month < elemanSayisiK; month++)
            {
                if (Int32.Parse(monthK[month].ToString("yyyy")) == Convert.ToInt32(cmb_yil.Text))
                    NewsumK[Int32.Parse(monthK[month].ToString("MM")) - 1] += sumK[month];
            }

            for (month = 0; month < odemeler.Length; month++)
            {
                if (Int32.Parse(monthOdemeler[month].ToString("yyyy")) == Convert.ToInt32(cmb_yil.Text))
                    Newodemeler[Int32.Parse(monthOdemeler[month].ToString("MM")) - 1] += odemeler[month];
            }

            for (month = 0; month < elemanSayisiYap; month++)
            {
                if (Int32.Parse(monthYapOdemeler[month].ToString("yyyy")) == Convert.ToInt32(cmb_yil.Text))
                    NewYapOdemeler[Int32.Parse(monthYapOdemeler[month].ToString("MM")) - 1] += yapOdemeler[month];
            }

            for (month = 0; month < elemanSayisiAl; month++)
            {
                if (Int32.Parse(monthAlOdemeler[month].ToString("yyyy")) == Convert.ToInt32(cmb_yil.Text))
                    NewAlOdemeler[Int32.Parse(monthAlOdemeler[month].ToString("MM")) - 1] += alOdemeler[month];
            }

            mySqlConnection.Close();

            chart1.Series["Gelen Faturalar"].Points.Clear();
            chart1.Series["Kesilen Faturalar"].Points.Clear();
            chart1.Series["Öngörülen Ödemeler"].Points.Clear();
            chart1.Series["Alınan Ödemeler"].Points.Clear();
            chart1.Series["Yapılan Ödemeler"].Points.Clear();



            for (int Month = 0; Month < 12; Month++)
            {
                if (NewsumG[Month] == 0)
                {
                    chart1.Series["Gelen Faturalar"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), NewsumG[Month]);
                }
                else
                {
                    chart1.Series["Gelen Faturalar"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), NewsumG[Month]);
                    chart1.Series["Gelen Faturalar"].Points[Month].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(NewsumG[Month]));
                }


            }
            for (int Month = 0; Month < 12; Month++)
            {
                if (NewsumK[Month] == 0)
                {
                    chart1.Series["Kesilen Faturalar"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), NewsumK[Month]);
                }
                else
                {
                    chart1.Series["Kesilen Faturalar"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), NewsumK[Month]);
                    chart1.Series["Kesilen Faturalar"].Points[Month].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(NewsumK[Month]));
                }


            }
            for (int Month = 0; Month < 12; Month++)
            {
                if (Newodemeler[Month] == 0)
                {
                    chart1.Series["Öngörülen Ödemeler"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), Newodemeler[Month]);
                }
                else
                {
                    chart1.Series["Öngörülen Ödemeler"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), Newodemeler[Month]);
                    chart1.Series["Öngörülen Ödemeler"].Points[Month].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(Newodemeler[Month]));
                }


            }
            for (int Month = 0; Month < 12; Month++)
            {
                if (NewYapOdemeler[Month] == 0)
                {
                    chart1.Series["Yapılan Ödemeler"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), NewYapOdemeler[Month]);
                }
                else
                {
                    chart1.Series["Yapılan Ödemeler"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), NewYapOdemeler[Month]);
                    chart1.Series["Yapılan Ödemeler"].Points[Month].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(NewYapOdemeler[Month]));
                }


            }
            for (int Month = 0; Month < 12; Month++)
            {
                if (NewAlOdemeler[Month] == 0)
                {
                    chart1.Series["Alınan Ödemeler"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), NewAlOdemeler[Month]);
                }
                else
                {
                    chart1.Series["Alınan Ödemeler"].Points.AddXY(Convert.ToString((Month + 1) + ". ay"), NewAlOdemeler[Month]);
                    chart1.Series["Alınan Ödemeler"].Points[Month].Label = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(NewAlOdemeler[Month]));
                }
            }
        }

        private void cmb_proje_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartControl();
        }

        private void cmb_yil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartControl();
        }

        public void ProgressBarlar()
        {
            mySqlConnection.Open();
            mySqlCommand.CommandText = "SELECT proje_baslangic,proje_bitis,proje_butce,harcama_toplam FROM db_projeler where proje_no='" + cmb_bar1.Text + "'";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                var start = Convert.ToDateTime(myReader.GetString(0));
                var end = Convert.ToDateTime(myReader.GetString(1));
                proje_butce = myReader.GetString(2);
                harcama_toplam = myReader.GetString(3);
                var total = (end - start).TotalDays;
                BarZaman = Convert.ToInt32(Math.Truncate((DateTime.Now - start).TotalDays * 100 / total));

                pgb1.Padding = new Padding(5);
                pgb1.LeftText = "1";
                pgb1.MainText = "PROJE TAKVİM DURUMU";
                pgb1.FillDegree = BarZaman;
                pgb1.RightText = "1";
                pgb1.StatusText = BarZaman.ToString();
                pgb1.StatusBarColor = 0;
                pgb1.Size = flp1_tarih.Size;
                pgb1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                this.flp1_tarih.Controls.Clear();
                this.flp1_tarih.Controls.Add(pgb1);
            }
            myReader.Close();

            try
            {
                mySqlCommand.CommandText = "SELECT sum(fatura_euro) FROM db_faturalar where fatura_tipi='G' and fatura_proje_no='" + cmb_bar1.Text + "'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    gelenFtr = myReader.GetString(0);
                }
                myReader.Close();
            }
            catch
            {
                gelenFtr = "0";
                myReader.Close();
            }
            try
            {
                mySqlCommand.CommandText = "SELECT sum(fatura_euro) FROM db_faturalar where fatura_tipi='K' and fatura_proje_no='" + cmb_bar1.Text + "'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    kesilenFtr = myReader.GetString(0);
                }
                myReader.Close();
            }
            catch
            {
                kesilenFtr = "0";
                myReader.Close();
            }

            try
            {
                BarButce = Convert.ToInt32(Math.Truncate(((100) * (Convert.ToDecimal(gelenFtr)) / (Convert.ToDecimal(harcama_toplam)))));

                pgb2.Padding = new Padding(5);
                pgb2.LeftText = "2";
                pgb2.MainText = "PROJE BÜTÇE DURUMU";
                if (BarButce == 0)
                { pgb2.FillDegree = 1; }
                else
                { pgb2.FillDegree = BarButce; }
                pgb2.RightText = "2";
                pgb2.StatusText = BarButce.ToString();
                pgb2.StatusBarColor = 0;
                pgb2.Size = flp1_butce.Size;
                pgb2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                this.flp1_butce.Controls.Clear();
                this.flp1_butce.Controls.Add(pgb2);
            }
            catch { }

            try
            {
                BarKesilenftr = Convert.ToInt32(Math.Truncate(((100 - 0) * (Convert.ToDecimal(kesilenFtr) - 0) / (Convert.ToDecimal(proje_butce) - 0)) + 0));

                pgb3.Padding = new Padding(5);
                pgb3.LeftText = "3";
                pgb3.MainText = "PROJE FATURA DURUMU";
                if (BarKesilenftr == 0)
                { pgb3.FillDegree = 1; }
                else
                { pgb3.FillDegree = BarKesilenftr; }
                pgb3.RightText = "3";
                pgb3.StatusText = BarKesilenftr.ToString();
                pgb3.StatusBarColor = 0;
                pgb3.Size = flp1_fatura.Size;
                pgb3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                this.flp1_fatura.Controls.Clear();
                this.flp1_fatura.Controls.Add(pgb3);
            }
            catch { }

            mySqlConnection.Close();
        }
    }
}
