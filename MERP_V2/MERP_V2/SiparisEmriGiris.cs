using MySql.Data.MySqlClient;
using System;
using System.Linq;

namespace MERP_V2
{
    public partial class SiparisEmriGiris : MetroFramework.Forms.MetroForm
    {
        MySqlDataReader myReader;
        FormMessageBox frmMessageBox;
        DBConnect db;
        HelperFunctions hf;

        public string siparis_euro;
        public string siparis_dolar;
        public string siparis_tl;

        public SiparisEmriGiris()
        {
            InitializeComponent();
            hf = new HelperFunctions();
            db = new DBConnect();
        }

        private void SiparisEmriGiris_Load(object sender, EventArgs e)
        {
            //----------------------------------------------- BAĞLANTI --------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------PROJE NO----------------------------------------------------------
            mySqlCommand.CommandText = "SELECT DISTINCT proje_no FROM db_projeler";
            myReader = mySqlCommand.ExecuteReader();
            while(myReader.Read())
            {
                cmb_proje_no.Items.Add(myReader["proje_no"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------TEDARİKÇİ---------------------------------------------------------
            mySqlCommand.CommandText = "SELECT DISTINCT tedarikci FROM db_siparis_emri";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                cmb_tedarikci.Items.Add(myReader["tedarikci"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_fiyat.Text.Contains('.') & txt_fiyat.Text.Contains(','))
            {
                frmMessageBox = new FormMessageBox();
                frmMessageBox.txt_mesaj.Text = "Aynı anda hem virgül hem nokta giremezsiniz!";
                frmMessageBox.Show();
            }
            else if((Convert.ToDateTime(date_teslim.Value).DayOfWeek == DayOfWeek.Saturday) || ((Convert.ToDateTime(date_teslim.Value).DayOfWeek == DayOfWeek.Sunday)))
            {
                frmMessageBox = new FormMessageBox();
                frmMessageBox.txt_mesaj.Text = "Lütfen hafta içi olacak bir tarih giriniz!";
                frmMessageBox.Show();
            }
            else
            {
                siparis_euro = hf.EuroCalculation(date_teslim.Text, txt_fiyat.Text, cmb_birim.Text, siparis_euro);
                siparis_dolar = hf.DolarCalculation(date_teslim.Text, txt_fiyat.Text, cmb_birim.Text, siparis_dolar);
                siparis_tl = hf.TLCalculation(date_teslim.Text, txt_fiyat.Text, cmb_birim.Text, siparis_tl);

                if (rbGelen.Checked)
                {
                    db.InsertSE(Convert.ToString(cmb_proje_no.Text), Convert.ToString(txt_siparis_no.Text), Convert.ToString(cmb_tedarikci.Text), Convert.ToString(txt_talepKisi.Text), Convert.ToDateTime(date_teslim.Text), Convert.ToInt32(txt_vade.Text), Convert.ToDateTime(date_temin.Text), Convert.ToDecimal(txt_fiyat.Text), Convert.ToString(cmb_birim.Text), Convert.ToDecimal(siparis_euro), Convert.ToDecimal(siparis_dolar), Convert.ToDecimal(siparis_tl), Convert.ToString(rcb_aciklama.Text), Convert.ToString("Gelen"));
                }
                if (rbVerilen.Checked)
                {
                    db.InsertSE(Convert.ToString(cmb_proje_no.Text), Convert.ToString(txt_siparis_no.Text), Convert.ToString(cmb_tedarikci.Text), Convert.ToString(txt_talepKisi.Text), Convert.ToDateTime(date_teslim.Text), Convert.ToInt32(txt_vade.Text), Convert.ToDateTime(date_temin.Text), Convert.ToDecimal(txt_fiyat.Text), Convert.ToString(cmb_birim.Text), Convert.ToDecimal(siparis_euro), Convert.ToDecimal(siparis_dolar), Convert.ToDecimal(siparis_tl), Convert.ToString(rcb_aciklama.Text), Convert.ToString("Verilen"));
                }
                this.Close();
            }
        }
    }
}
