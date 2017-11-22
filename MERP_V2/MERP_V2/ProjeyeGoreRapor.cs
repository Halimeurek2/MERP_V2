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

        int index = 0;

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
        }

        private void btn_frmRapor_Click(object sender, EventArgs e)
        {
            FirmaRapor frmFirmaRapor = new FirmaRapor();
            frmFirmaRapor.Show();
        }

        private void btn_ozetRapor_Click(object sender, EventArgs e)
        {
            OdenecekFaturalar frmOdecekFaturalar = new OdenecekFaturalar();
            frmOdecekFaturalar.Show();
        }

        private void cmb_proje_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array.Clear(monthG, 0, 12);
            Array.Clear(month_sumG, 0, 12);
            Array.Clear(monthK, 0, 12);
            Array.Clear(month_sumK, 0, 12);

            sorgular = new Sorgular();

            try
            {
                TOPLAM = Convert.ToDecimal(sorgular.FaturaTutar(cmb_proje_no.Text, "G", TOPLAM));
                lbl_topMaliyet.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
            }
            catch
            {
                lbl_topMaliyet.Text = "0";
            }

            try
            {
                TOPLAM = Convert.ToDecimal(sorgular.FaturaTutar(cmb_proje_no.Text, "G", "ODENDI", TOPLAM));
                lbl_odenmisG.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
            }
            catch
            {
                lbl_odenmisG.Text = "0";
            }

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

            try
            {
                TOPLAMsiparis = sorgular.SiparisToplam(cmb_proje_no.Text, TOPLAM);
                lbl_siparis.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(lbl_siparis));
            }
            catch
            {
                lbl_siparis.Text = "0";
            }

            try
            {
                lbl_projeButce.Text = sorgular.ProjeButceConvert(cmb_proje_no.Text, Convert.ToString(TOPLAM));
            }
            catch
            {
                lbl_projeButce.Text = "0";
            }

            //----------------------------AÇIK AVANS---------------------------------------------------------------------------
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
            //------------------------------------------------------------------------------------------------------------------
            TOPLAM_odeme = TOPLAM + TOPLAMavans;
            lbl_odenmisK.Text = string.Format(new CultureInfo("en-US"), "{0:C2}", Convert.ToDecimal(TOPLAM_odeme));

            mySqlConnection.Close();
            mySqlConnection.Open();
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

            mySqlConnection.Close();
        }
    }
}
