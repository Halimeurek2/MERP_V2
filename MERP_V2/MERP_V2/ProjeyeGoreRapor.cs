using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class ProjeyeGoreRapor : MetroFramework.Forms.MetroForm
    {
        MySqlDataReader myReader;
        DBConnect db;
        HelperFunctions hf;
        Sorgular sorgular;
        DataTable dt;
        MySqlDataAdapter da;

        int index = 0;

        string el_mal;
        string mek_mal;
        string genel_mal;

        string el_mal2;
        string mek_mal2;
        string genel_mal2;

        string el_ongorulen;
        string el_harcanan;
        string el_kalan;

        string mek_ongorulen;
        string mek_harcanan;
        string mek_kalan;

        string genel_ongorulen;
        string genel_harcanan;
        string genel_kalan;

        public decimal TOPLAM = 0;
        public decimal TOPLAMsiparis = 0;
        public decimal TOPLAMavans = 0;
        public decimal TOPLAM_odeme = 0;
        public decimal avans = 0;
        public string BIRIM;

        public float[] month_sumG = new float[12];
        public DateTime[] monthG = new DateTime[12];

        public float[] month_sumK = new float[12];
        public DateTime[] monthK = new DateTime[12];

        public ProjeyeGoreRapor()
        {
            InitializeComponent();
            hf = new HelperFunctions();
            db = new DBConnect();
            sorgular = new Sorgular();
            dt = new DataTable();
            da = new MySqlDataAdapter();
        }

        private void ProjeyeGoreRapor_Load(object sender, EventArgs e)
        {
            //----------------------------------------------- BAĞLANTI --------------------------------------------------------
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
            chart2.Titles.Add("ELEKTRONİK");
            chart3.Titles.Add("MEKANİK");
            chart4.Titles.Add("GENEL GİDERLER");
        }

        private void btn_frmRapor_Click(object sender, EventArgs e)
        {
            FirmaRapor frmFirmaRapor = new FirmaRapor();
            frmFirmaRapor.lbl_proje_no.Text = cmb_proje_no.Text;
            frmFirmaRapor.Show();
        }

        private void btn_ozetRapor_Click(object sender, EventArgs e)
        {
            OdenecekFaturalar frmOdecekFaturalar = new OdenecekFaturalar();

            Array.Clear(frmOdecekFaturalar.monthG, 0, 12);
            Array.Clear(frmOdecekFaturalar.month_sumG, 0, 12);
            Array.Clear(frmOdecekFaturalar.monthK, 0, 12);
            Array.Clear(frmOdecekFaturalar.month_sumK, 0, 12);

            for (int i = 0; i < 12; i++)
            {
                frmOdecekFaturalar.monthG[i] = monthG[i];
                frmOdecekFaturalar.month_sumG[i] = month_sumG[i];
                frmOdecekFaturalar.monthK[i] = monthK[i];
                frmOdecekFaturalar.month_sumK[i] = month_sumK[i];
            }
            frmOdecekFaturalar.lbl_proje_no.Text = cmb_proje_no.Text;

            frmOdecekFaturalar.Show();
        }

        private void cmb_proje_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array.Clear(monthG, 0, 12);
            Array.Clear(month_sumG, 0, 12);
            Array.Clear(monthK, 0, 12);
            Array.Clear(month_sumK, 0, 12);

            sorgular = new Sorgular();

            //--------------------------------------TOPLAM MALİYET----------------------------------------------------
            try
            {
                TOPLAM = Convert.ToDecimal(sorgular.FaturaTutar(cmb_proje_no.Text, "G", TOPLAM));
                lbl_topMaliyet.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
            }
            catch
            {
                lbl_topMaliyet.Text = "0";
            }
            //--------------------------------------------------------------------------------------------------------

            //-------------------------------------ÖDENMİŞ GELEN FATURA-----------------------------------------------
            try
            {
                TOPLAM = Convert.ToDecimal(sorgular.FaturaTutar(cmb_proje_no.Text, "G", "ODENDI", TOPLAM));
                lbl_odenmisG.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
            }
            catch
            {
                lbl_odenmisG.Text = "0";
            }
            //--------------------------------------------------------------------------------------------------------

            //-----------------------------------------PROJE EURO-----------------------------------------------------
            try
            {
                TOPLAM = 0;
                lbl_projeEuro.Text = Convert.ToString(sorgular.ProjeButce(cmb_proje_no.Text, TOPLAM));
                lbl_projeEuro.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(lbl_projeEuro.Text));
            }
            catch
            {
                lbl_projeEuro.Text = "0";
            }
            //--------------------------------------------------------------------------------------------------------

            //--------------------------------------ALINAN ÖDEME------------------------------------------------------
            try
            {
                TOPLAM = Convert.ToDecimal(sorgular.FaturaTutar(cmb_proje_no.Text, "K", "ODENDI", TOPLAM));
                avans = Convert.ToDecimal(sorgular.FaturaAvans(cmb_proje_no.Text, "K", "ODENDI", avans));
                TOPLAM = TOPLAM - avans;
                lbl_alOdeme.Text = string.Format(new CultureInfo("en-US"), "{0:C2}", Convert.ToDecimal(TOPLAM));
            }
            catch
            {
                lbl_alOdeme.Text = "0";
            }
            //--------------------------------------------------------------------------------------------------------

            //------------------------------------TOPLAM SİPARİŞ------------------------------------------------------
            try
            {
                TOPLAMsiparis = sorgular.SiparisToplam(cmb_proje_no.Text, TOPLAM);
                lbl_siparis.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAMsiparis));
            }
            catch
            {
                lbl_siparis.Text = "0";
            }
            //--------------------------------------------------------------------------------------------------------

            //---------------------------------------PROJE BÜTÇE------------------------------------------------------
            try
            {
                lbl_projeButce.Text = sorgular.ProjeButceConvert(cmb_proje_no.Text, Convert.ToString(TOPLAM));
            }
            catch
            {
                lbl_projeButce.Text = "0";
            }
            //--------------------------------------------------------------------------------------------------------

            //-----------------------------------------AÇIK AVANS-----------------------------------------------------
            try
            {
                TOPLAMavans = Convert.ToDecimal(sorgular.ToplamAvans(cmb_proje_no.Text, "A", "ODENDI", "A111", TOPLAMavans));
                TOPLAMavans = TOPLAMavans - avans;
                lbl_avans.Text = string.Format(new CultureInfo("en-US"), "{0:C2}", Convert.ToDecimal(TOPLAMavans));
            }
            catch
            {
                lbl_avans.Text = "0";
            }
            //---------------------------------------------------------------------------------------------------------

            //------------------------------------ÖDENMİŞ KESİLEN FATURA-----------------------------------------------
            TOPLAM_odeme = TOPLAM + TOPLAMavans;
            lbl_odenmisK.Text = string.Format(new CultureInfo("en-US"), "{0:C2}", Convert.ToDecimal(TOPLAM_odeme));
            //---------------------------------------------------------------------------------------------------------


            mySqlConnection.Close();
            mySqlConnection.Open();

            //-------------------------------------ÖDENMEMİŞ GELEN FATURALAR-------------------------------------------
            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT DATE_FORMAT(fatura_vade_tarih,'%m-%Y') AS Month, SUM(fatura_euro) FROM db_faturalar WHERE fatura_durum='ODENMEDI' and fatura_tipi='G' and fatura_proje_no ='" + cmb_proje_no.Text + "' GROUP BY DATE_FORMAT(fatura_vade_tarih, '%m-%Y')";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (Convert.ToDateTime(myReader.GetString(0)).Year == DateTime.Now.Year)
                    {
                        monthG[index] = Convert.ToDateTime(myReader.GetString(0));
                        month_sumG[index] = (float)Convert.ToDouble(myReader.GetString(1));
                        index++;
                    }
                }
                myReader.Close();
            }
            catch
            {
                myReader.Close();
            }
            //---------------------------------------------------------------------------------------------------------

            //-------------------------------------ÖDENMEMİŞ KESİLEN FATURALAR-----------------------------------------
            try
            {
                index = 0;
                mySqlCommand.CommandText = "SELECT DATE_FORMAT(fatura_vade_tarih,'%m-%Y') AS Month, SUM(fatura_euro) FROM db_faturalar WHERE fatura_durum='ODENMEDI' and fatura_tipi='K' and fatura_proje_no ='" + cmb_proje_no.Text + "' GROUP BY DATE_FORMAT(fatura_vade_tarih, '%m-%Y')";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (Convert.ToDateTime(myReader.GetString(0)).Year == DateTime.Now.Year)
                    {
                        monthK[index] = Convert.ToDateTime(myReader.GetString(0));
                        month_sumK[index] = (float)Convert.ToDouble(myReader.GetString(1));
                        index++;
                    }
                }
                myReader.Close();
            }
            catch
            {
                myReader.Close();
            }
            //---------------------------------------------------------------------------------------------------------
            mySqlConnection.Close();

            FillDGW();
            DGWToplam();
            DrawChart1();
            DrawChart2();
            DrawChart3();
            DrawChart4();
        }

        public void FillDGW()
        {
            mySqlCommand.CommandText = "SELECT fatura_no as FaturaNo," +
                                       "fatura_firma as Firma," +
                                       "fatura_vade as Vade," +
                                       "fatura_vade_tarih as VadeTarih," +
                                       "fatura_aciklama as Açıklama," +
                                       "fatura_euro as Euro FROM db_faturalar WHERE fatura_durum='ODENMEDI' AND fatura_proje_no ='" + cmb_proje_no.Text + "' AND fatura_tipi='G'";
            da = new MySqlDataAdapter(mySqlCommand);
            dt = new DataTable();
            da.Fill(dt);
            dgw_odenmemisG.DataSource = dt;
            dgw_odenmemisG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_odenmemisG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            mySqlCommand.CommandText = "SELECT fatura_no as FaturaNo," +
                                       "fatura_firma as Firma," +
                                       "fatura_vade as Vade," +
                                       "fatura_vade_tarih as VadeTarih," +
                                       "fatura_aciklama as Açıklama," +
                                       "fatura_euro as Euro FROM db_faturalar WHERE fatura_durum='ODENMEDI' AND fatura_proje_no ='" + cmb_proje_no.Text + "' AND fatura_tipi='K'";
            da = new MySqlDataAdapter(mySqlCommand);
            dt = new DataTable();
            da.Fill(dt);
            dgw_odenmemisK.DataSource = dt;
            dgw_odenmemisK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_odenmemisK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgw_odenmemisK.Columns[5].DefaultCellStyle.Format = "c2";
            dgw_odenmemisK.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");
            dgw_odenmemisG.Columns[5].DefaultCellStyle.Format = "c2";
            dgw_odenmemisG.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");

            //-------------------------------------------VADESİ YAKLAŞANLARI RENKLENDİRME--------------------------------------------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < dgw_odenmemisG.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dgw_odenmemisG.Rows[i].Cells[3].Value).Date < DateTime.Now)
                    {
                        dgw_odenmemisG.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                    }
                    else if (Convert.ToDateTime(dgw_odenmemisG.Rows[i].Cells[3].Value).Date > DateTime.Now && Convert.ToDateTime(dgw_odenmemisG.Rows[i].Cells[3].Value).Date < DateTime.Now.AddDays(5))
                    {
                        dgw_odenmemisG.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                    }
                }
            }
            catch { }

            try
            {
                for (int i = 0; i < dgw_odenmemisK.Rows.Count; i++)
                {
                    dgw_odenmemisK.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                for (int i = 0; i < dgw_odenmemisG.Rows.Count; i++)
                {
                    dgw_odenmemisG.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch { }

            try
            {
                for (int i = 0; i < dgw_odenmemisK.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dgw_odenmemisK.Rows[i].Cells[3].Value).Date < DateTime.Now)
                    {
                        dgw_odenmemisK.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                    }
                    else if (Convert.ToDateTime(dgw_odenmemisK.Rows[i].Cells[3].Value).Date > DateTime.Now && Convert.ToDateTime(dgw_odenmemisK.Rows[i].Cells[3].Value).Date < DateTime.Now.AddDays(5))
                    {
                        dgw_odenmemisK.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                    }
                }
            }
            catch { }
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }

        public void DGWToplam()
        {
            sorgular = new Sorgular();

            try
            {
                TOPLAM = sorgular.FaturaTutar(cmb_proje_no.Text, "G", "ODENMEDI", TOPLAM);
                lbl_toplamG.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                lbl_odenmemisG.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
            }
            catch
            {
                lbl_toplamG.Text = "0";
                lbl_odenmemisG.Text = "0";
            }

            try
            {
                TOPLAM = sorgular.FaturaTutar(cmb_proje_no.Text, "K", "ODENMEDI", TOPLAM);
                lbl_toplamK.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                lbl_odenmemisK.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
            }
            catch
            {
                lbl_toplamK.Text = "0";
                lbl_odenmemisK.Text = "0";
            }
        }

        public void DrawChart1()
        {
            sorgular = new Sorgular();

            el_mal = Convert.ToString(sorgular.SumFatura(cmb_proje_no.Text, "G", "Elektronik", Convert.ToDecimal(el_mal)));
            el_mal2 = el_mal;

            mek_mal = Convert.ToString(sorgular.SumFatura(cmb_proje_no.Text, "G", "Mekanik", Convert.ToDecimal(mek_mal)));
            mek_mal2 = mek_mal;

            genel_mal = Convert.ToString(sorgular.SumFatura(cmb_proje_no.Text, "G", "Genel Giderler", Convert.ToDecimal(genel_mal)));
            genel_mal2 = genel_mal;

            chart1.Series["pieChart"].Points.Clear();
            chart1.Series["pieChart"].Points.Add(Convert.ToDouble(el_mal));
            chart1.Series["pieChart"].Points.Add(Convert.ToDouble(mek_mal));
            chart1.Series["pieChart"].Points.Add(Convert.ToDouble(genel_mal));

            el_mal2 = hf.DecimalToCurrency(Convert.ToDecimal(el_mal2), el_mal2);
            mek_mal2 = hf.DecimalToCurrency(Convert.ToDecimal(mek_mal2), mek_mal2);
            genel_mal2 = hf.DecimalToCurrency(Convert.ToDecimal(genel_mal2), genel_mal2);

            var p1 = chart1.Series["pieChart"].Points[0];
            p1.AxisLabel = Convert.ToString("#PERCENT");
            p1.LegendText = "E : " + el_mal2;

            var p2 = chart1.Series["pieChart"].Points[1];
            p2.AxisLabel = Convert.ToString("#PERCENT");
            p2.LegendText = "M : " + mek_mal2;

            var p3 = chart1.Series["pieChart"].Points[2];
            p3.AxisLabel = Convert.ToString("#PERCENT");
            p3.LegendText = "G : " + genel_mal2;

            chart1.Series[0]["PieLabelStyle"] = "Outside";

            chart1.Series[0].BorderWidth = 1;
            chart1.Series[0].BorderColor = Color.FromArgb(224, 224, 224);
        }

        public void DrawChart2()
        {
            sorgular = new Sorgular();

            el_ongorulen = "0";
            el_ongorulen = Convert.ToString(sorgular.HarcamaOngoruSum(cmb_proje_no.Text, "Elektronik Std", "Yedek Malz. Elek", Convert.ToDecimal(el_ongorulen)));

            try
            {
                el_harcanan = el_mal;
            }
            catch
            {
                el_harcanan = "0";
            }
            try
            {
                el_kalan = Convert.ToString((Convert.ToDecimal(el_ongorulen) - Convert.ToDecimal(el_harcanan)));
            }
            catch
            {
                el_kalan = "0";
            }

            chart2.Series["Series1"].Points.Clear();

            if (el_ongorulen != null || el_ongorulen != "0")
            {
                el_ongorulen = hf.DecimalToCurrency(Convert.ToDecimal(el_ongorulen), el_ongorulen);
                chart2.Legends[0].Title = "Öngörülen Toplam" + " " + el_ongorulen;
            }
            else
            {
                chart2.Legends[0].Title = "Öngörülen Toplam : 0";
            }

            chart2.Series["Series1"].Points.Add(Convert.ToDouble(el_harcanan));        
            chart2.Series["Series1"].Points.Add(Convert.ToDouble(el_kalan)); 

            el_harcanan = hf.DecimalToCurrency(Convert.ToDecimal(el_harcanan), el_harcanan);
            el_kalan = hf.DecimalToCurrency(Convert.ToDecimal(el_kalan), el_kalan);

            var p1 = chart2.Series["Series1"].Points[0];
            p1.AxisLabel = Convert.ToString("#PERCENT");
            p1.LegendText = "Harcanan " + el_harcanan;

            var p2 = chart2.Series["Series1"].Points[1];
            p2.AxisLabel = Convert.ToString("#PERCENT");
            p2.LegendText = "Kalan " + el_kalan;

            chart2.Series[0]["PieLabelStyle"] = "Outside";

            chart2.Series[0].BorderWidth = 1;
            chart2.Series[0].BorderColor = Color.FromArgb(224, 224, 224);
        }

        public void DrawChart3()
        {
            sorgular = new Sorgular();

            mek_ongorulen = "0";
            mek_ongorulen = Convert.ToString(sorgular.HarcamaOngoruSum(cmb_proje_no.Text, "Mekanik Std", "Yedek Malz. Mek", "Imalat", Convert.ToDecimal(mek_ongorulen)));

            try
            {
                mek_harcanan = mek_mal;
            }
            catch
            {
                mek_harcanan = "0";
                myReader.Close();
            }
            try
            {
                mek_kalan = Convert.ToString((Convert.ToDecimal(mek_ongorulen) - Convert.ToDecimal(mek_harcanan)));
            }
            catch
            {
                mek_kalan = "0";
            }

            chart3.Series["Series1"].Points.Clear();

            if (mek_ongorulen != null || mek_ongorulen != "0")
            {
                mek_ongorulen = hf.DecimalToCurrency(Convert.ToDecimal(mek_ongorulen), mek_ongorulen);
                chart3.Legends[0].Title = "Öngörülen Toplam" + " " + mek_ongorulen;
            }
            else
            {
                chart3.Legends[0].Title = "Öngörülen Toplam : 0";
            }

            chart3.Series["Series1"].Points.Add(Convert.ToDouble(mek_harcanan));
            chart3.Series["Series1"].Points.Add(Convert.ToDouble(mek_kalan));

            mek_harcanan = hf.DecimalToCurrency(Convert.ToDecimal(mek_harcanan), mek_harcanan);
            mek_kalan = hf.DecimalToCurrency(Convert.ToDecimal(mek_kalan), mek_kalan);

            var p1 = chart3.Series["Series1"].Points[0];
            p1.AxisLabel = Convert.ToString("#PERCENT");
            p1.LegendText = "Harcanan " + mek_harcanan;

            var p2 = chart3.Series["Series1"].Points[1];
            p2.AxisLabel = Convert.ToString("#PERCENT");
            p2.LegendText = "Kalan " + mek_kalan;

            chart3.Series[0]["PieLabelStyle"] = "Outside";

            chart3.Series[0].BorderWidth = 1;
            chart3.Series[0].BorderColor = Color.FromArgb(224, 224, 224);
        }

        public void DrawChart4()
        {
            sorgular = new Sorgular();

            genel_ongorulen = "0";
            genel_ongorulen = Convert.ToString(sorgular.HarcamaOngoruSum(cmb_proje_no.Text, "Risk", "Test", "Lojistik", "Ithalat-Gumruk", Convert.ToDecimal(genel_ongorulen)));

            try
            {
                genel_harcanan = genel_mal;
            }
            catch
            {
                genel_harcanan = "0";
                myReader.Close();
            }
            try
            {
                genel_kalan = Convert.ToString((Convert.ToDecimal(genel_ongorulen) - Convert.ToDecimal(genel_harcanan)));
            }
            catch
            {
                genel_kalan = "0";
            }

            chart4.Series["Series1"].Points.Clear();

            if (genel_ongorulen != null || genel_ongorulen != "0")
            {
                genel_ongorulen = hf.DecimalToCurrency(Convert.ToDecimal(genel_ongorulen), genel_ongorulen);
                chart4.Legends[0].Title = "Öngörülen Toplam" + " " + genel_ongorulen;
            }
            else
            {
                chart4.Legends[0].Title = "Öngörülen Toplam : 0";
            }

            chart4.Series["Series1"].Points.Add(Convert.ToDouble(genel_harcanan));
            chart4.Series["Series1"].Points.Add(Convert.ToDouble(genel_kalan));

            genel_harcanan = hf.DecimalToCurrency(Convert.ToDecimal(genel_harcanan), genel_harcanan);
            genel_kalan = hf.DecimalToCurrency(Convert.ToDecimal(genel_kalan), genel_kalan);

            var p1 = chart4.Series["Series1"].Points[0];
            p1.AxisLabel = Convert.ToString("#PERCENT");
            p1.LegendText = "Harcanan " + genel_harcanan;

            var p2 = chart4.Series["Series1"].Points[1];
            p2.AxisLabel = Convert.ToString("#PERCENT");
            p2.LegendText = "Kalan " + genel_kalan;

            chart4.Series[0]["PieLabelStyle"] = "Outside";

            chart4.Series[0].BorderWidth = 1;
            chart4.Series[0].BorderColor = Color.FromArgb(224, 224, 224);
        }
    }
}
