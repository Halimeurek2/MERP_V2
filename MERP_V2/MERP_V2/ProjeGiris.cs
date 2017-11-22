using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class ProjeGiris : MetroFramework.Forms.MetroForm
    {
        HarcamaOngorusu frmHarcamaOng;
        HelperFunctions hf;
        FormMessageBox frmMessageBox;
        DBConnect db;
        MySqlDataReader myReader;

        decimal proje_euro;
        decimal proje_dolar;
        decimal proje_tl;

        DateTime baslangic;
        DateTime bitis;
        string vade;

        public ProjeGiris()
        {
            InitializeComponent();
            frmHarcamaOng = new HarcamaOngorusu();
            hf = new HelperFunctions();
            db = new DBConnect();
        }

        private void ProjeGiris_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
        }

        private void btn_harcamalar_Click(object sender, EventArgs e)
        {
            frmHarcamaOng.Show();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
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
                    db.InsertProjeGiris(Convert.ToString(txt_proje_no.Text), Convert.ToString(txt_proje_adi.Text), Convert.ToDecimal(txt_butce.Text), Convert.ToString(cmb_birim.Text), proje_euro, proje_dolar, proje_tl, Convert.ToString(txt_musteri.Text), Convert.ToDateTime(dtp_baslangic.Text), Convert.ToDateTime(dtp_bitis.Text), Convert.ToInt32(txt_vade.Text), Convert.ToString(rcb_aciklama.Text), Convert.ToDecimal(frmHarcamaOng.toplam), Convert.ToString("EURO"), Convert.ToString("P"));
                }
                if (rbSeri.Checked)
                {
                    db.InsertProjeGiris(Convert.ToString(txt_proje_no.Text), Convert.ToString(txt_proje_adi.Text), Convert.ToDecimal(txt_butce.Text), Convert.ToString(cmb_birim.Text), proje_euro, proje_dolar, proje_tl, Convert.ToString(txt_musteri.Text), Convert.ToDateTime(dtp_baslangic.Text), Convert.ToDateTime(dtp_bitis.Text), Convert.ToInt32(txt_vade.Text), Convert.ToString(rcb_aciklama.Text), Convert.ToDecimal(frmHarcamaOng.toplam), Convert.ToString("EURO"), Convert.ToString("S"));
                }
                //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                //----------------------------------HARCAMALARI KAYDET----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                mySqlCommand.CommandText = "SELECT * FROM db_projeler WHERE proje_no ='" + txt_proje_no.Text + "'";
                myReader = mySqlCommand.ExecuteReader();
                while(myReader.Read())
                {
                    for (int i = 0; i < frmHarcamaOng.dgw_harcama.Rows.Count - 1; i++)
                    {
                        db.InsertHarcamalar(myReader.GetInt32(0), Convert.ToString(frmHarcamaOng.dgw_harcama.Rows[i].Cells[1].Value), Convert.ToDecimal(frmHarcamaOng.dgw_harcama.Rows[i].Cells[2].Value), Convert.ToString(frmHarcamaOng.dgw_harcama.Rows[i].Cells[3].Value), Convert.ToDateTime(frmHarcamaOng.dgw_harcama.Rows[i].Cells[0].Value));
                    }
                    for (int i = 0; i < frmHarcamaOng.dgw_odeme.Rows.Count - 1; i++)
                    {
                        db.InsertOdemeler(myReader.GetInt32(0), Convert.ToString(frmHarcamaOng.dgw_odeme.Rows[i].Cells[1].Value), Convert.ToDecimal(frmHarcamaOng.dgw_odeme.Rows[i].Cells[2].Value), Convert.ToString(frmHarcamaOng.dgw_odeme.Rows[i].Cells[3].Value), Convert.ToDateTime(frmHarcamaOng.dgw_odeme.Rows[i].Cells[0].Value));
                    }
                }
                //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                this.Close();
                frmHarcamaOng.Close();
            }
        }

        private void txt_vade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vade = Convert.ToString(txt_vade.Text);
                baslangic = Convert.ToDateTime(dtp_baslangic.Text);
                bitis = baslangic.AddDays(int.Parse(vade));
                dtp_bitis.Value = bitis;
            }
            catch
            { }
        }
    }
}
