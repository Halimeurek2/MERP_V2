using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class ProjeDuzenle : MetroFramework.Forms.MetroForm
    {
        HelperFunctions hf;
        DBConnect db;
        FormMessageBox frmMessageBox;
        MySqlDataReader myReader;

        decimal proje_euro;
        decimal proje_dolar;
        decimal proje_tl;

        DateTime baslangic;
        DateTime bitis;
        string vade;

        public ProjeDuzenle()
        {
            InitializeComponent();
            hf = new HelperFunctions();
            db = new DBConnect();
        }

        private void ProjeDuzenle_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (txt_butce.Text.Contains('.') & txt_butce.Text.Contains(','))
            {
                frmMessageBox = new FormMessageBox();
                frmMessageBox.txt_mesaj.Text = "Aynı anda hem virgül hem nokta giremezsiniz!";
                frmMessageBox.Show();
            }
            else
            {
                //--------------------------------------DÖNÜŞÜMLER----------------------------------------------------------------------------------------------------------
                txt_butce.Text = hf.Dot2Comma(txt_butce.Text);
                lbl_harcamalar.Text = hf.Dot2Comma(lbl_harcamalar.Text);

                proje_euro = Convert.ToDecimal(hf.EuroCalculation(Convert.ToString(dtp_baslangic.Value), txt_butce.Text, cmb_birim.Text, Convert.ToString(proje_euro)));
                proje_dolar = Convert.ToDecimal(hf.DolarCalculation(Convert.ToString(dtp_baslangic.Value), txt_butce.Text, cmb_birim.Text, Convert.ToString(proje_dolar)));
                proje_tl = Convert.ToDecimal(hf.TLCalculation(Convert.ToString(dtp_baslangic.Value), txt_butce.Text, cmb_birim.Text, Convert.ToString(proje_tl)));
                //-----------------------------------------------------------------------------------------------------------------------------------------------------------

                //--------------------------------------PROJEYİ KAYDET---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (rbProje.Checked)
                {
                    db = new DBConnect();
                    db.UpdateProjeler(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_proje_no.Text), Convert.ToString(txt_proje_adi.Text), Convert.ToDecimal(txt_butce.Text), Convert.ToString(cmb_birim.Text), proje_euro, proje_dolar, proje_tl, Convert.ToString(txt_musteri.Text), Convert.ToDateTime(dtp_baslangic.Text), Convert.ToDateTime(dtp_bitis.Text), Convert.ToInt32(txt_vade.Text), Convert.ToString(rcb_aciklama.Text), Convert.ToDecimal(lbl_harcamalar.Text), Convert.ToString("EURO"), Convert.ToString("P"), Convert.ToString(cmb_durum.Text));
                }
                if (rbSeri.Checked)
                {
                    db = new DBConnect();
                    db.UpdateProjeler(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_proje_no.Text), Convert.ToString(txt_proje_adi.Text), Convert.ToDecimal(txt_butce.Text), Convert.ToString(cmb_birim.Text), proje_euro, proje_dolar, proje_tl, Convert.ToString(txt_musteri.Text), Convert.ToDateTime(dtp_baslangic.Text), Convert.ToDateTime(dtp_bitis.Text), Convert.ToInt32(txt_vade.Text), Convert.ToString(rcb_aciklama.Text), Convert.ToDecimal(lbl_harcamalar.Text), Convert.ToString("EURO"), Convert.ToString("S"), Convert.ToString(cmb_durum.Text));
                }
                //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                //----------------------------------HARCAMALARI KAYDET----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                HarcamaOngorusu frmHarcamaOng = (HarcamaOngorusu)Application.OpenForms["HarcamaOngorusu"];
                Projeler Projeler = (Projeler)Application.OpenForms["Projeler"];

                mySqlCommand.CommandText = "SELECT * FROM db_projeler WHERE proje_no ='" + txt_proje_no.Text + "'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    for (int i = 0; i < frmHarcamaOng.dgw_harcama.Rows.Count - 1; i++)
                    {
                        db.UpdateHarcamalar(Convert.ToInt16(Projeler.harcama_id[i]), myReader.GetInt32(0), Convert.ToString(frmHarcamaOng.dgw_harcama.Rows[i].Cells[1].Value), Convert.ToDecimal(frmHarcamaOng.dgw_harcama.Rows[i].Cells[2].Value), Convert.ToString(frmHarcamaOng.dgw_harcama.Rows[i].Cells[3].Value), Convert.ToDateTime(frmHarcamaOng.dgw_harcama.Rows[i].Cells[0].Value));
                    }
                    for (int i = 0; i < frmHarcamaOng.dgw_odeme.Rows.Count - 1; i++)
                    {
                        db.UpdateOdemeler(Convert.ToInt16(Projeler.odeme_id[i]), myReader.GetInt32(0), Convert.ToString(frmHarcamaOng.dgw_odeme.Rows[i].Cells[1].Value), Convert.ToDecimal(frmHarcamaOng.dgw_odeme.Rows[i].Cells[2].Value), Convert.ToString(frmHarcamaOng.dgw_odeme.Rows[i].Cells[3].Value), Convert.ToDateTime(frmHarcamaOng.dgw_odeme.Rows[i].Cells[0].Value));
                    }
                }
                //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                myReader.Close();
                mySqlConnection.Close();
                this.Close();
                frmHarcamaOng.Close();
            }
        }
    }
}
