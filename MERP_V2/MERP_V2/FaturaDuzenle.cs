using MySql.Data.MySqlClient;
using System;
using System.Linq;

namespace MERP_V2
{
    public partial class FaturaDuzenle : MetroFramework.Forms.MetroForm
    {
        HelperFunctions hf;
        DBConnect db;
        MySqlDataReader myReader;
        FormMessageBox frmMessageBox;

        DateTime baslangic;
        DateTime bitis;

        string vade;

        decimal fatura_euro;
        decimal fatura_dolar;
        decimal fatura_tl;

        public FaturaDuzenle()
        {
            InitializeComponent();
            hf = new HelperFunctions();
            db = new DBConnect();
        }

        private void FaturaDuzenle_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------- Projeler-----------------------------------------------------------------
            mySqlCommand.CommandText = "SELECT DISTINCT proje_no FROM db_projeler";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                cmb_proje_no.Items.Add(myReader["proje_no"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------- Firmalar-----------------------------------------------------------------
            mySqlCommand.CommandText = "SELECT DISTINCT fatura_firma FROM db_faturalar";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                cmb_firma.Items.Add(myReader["fatura_firma"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------- Satinalma No-------------------------------------------------------------
            mySqlCommand.CommandText = "SELECT DISTINCT satinalma_no FROM db_siparis_emri where siparis_tipi='Gelen'";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                cmb_se.Items.Add(myReader["satinalma_no"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            if (lbl_tip.Text == "K")
            {
                rbKesilen.Checked = true;
                cmb_se.Visible = true;
            }
            else
            {
                rbGelen.Checked = true;
                cmb_se.Visible = false;
                cmb_se.Text = " ";
            }
        }

        private void cmb_durum_CheckedChanged(object sender, EventArgs e)
        {
            if(cmb_durum.Checked)
            {
                date_odendi.Visible = true;
            }
            else
            {
                date_odendi.Visible = false;
            }
        }

        private void txt_ftr_vade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vade = Convert.ToString(txt_ftr_vade.Text);
                baslangic = Convert.ToDateTime(date_ftr_tarih.Text);
                bitis = baslangic.AddDays(int.Parse(vade));
                date_alarm.Value = bitis;
            }
            catch
            { }
        }

        private void rbKesilen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKesilen.Checked)
            {
                cmb_se.Visible = true;
            }
            else
            {
                cmb_se.Visible = false;
                cmb_se.Text = " ";
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (txt_ftr_tutar.Text.Contains('.') & txt_ftr_tutar.Text.Contains(','))
            {
                frmMessageBox = new FormMessageBox();
                frmMessageBox.txt_mesaj.Text = "Aynı anda hem virgül hem nokta giremezsiniz!";
                frmMessageBox.Show();
            }
            else if ((Convert.ToDateTime(date_ftr_tarih.Value).DayOfWeek == DayOfWeek.Saturday) || ((Convert.ToDateTime(date_ftr_tarih.Value).DayOfWeek == DayOfWeek.Sunday)))
            {
                frmMessageBox = new FormMessageBox();
                frmMessageBox.txt_mesaj.Text = "Lütfen hafta içi olacak bir tarih giriniz!";
                frmMessageBox.Show();
            }
            else
            {
                if (txt_fatura_no.Text == "T111" || txt_fatura_no.Text == "M111" || txt_fatura_no.Text == "M222")
                {
                    Send();
                }
                else if (txt_fatura_no.Text == "A111")
                {
                    if (rbGelen.Checked)
                    {
                        db.UpdateFaturalar(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_proje_no.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('A'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENDI"), Convert.ToString(cmb_se.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                    }
                    if (rbKesilen.Checked)
                    {
                        db.UpdateFaturalar(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_proje_no.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('V'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENDI"), Convert.ToString(cmb_gelense.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                    }
                }
                else
                {
                    try
                    {
                        myReader.Close();
                        mySqlCommand.CommandText = "SELECT * FROM db_faturalar where fatura_no='" + txt_fatura_no.Text + "'";
                        myReader = mySqlCommand.ExecuteReader();
                        while (myReader.Read()) { }
                        if (myReader.HasRows == false)
                        {
                            Send();
                            myReader.Close();
                        }
                        else
                        {
                            frmMessageBox = new FormMessageBox();
                            frmMessageBox.txt_mesaj.Text = "Fatura No önceden kullanılmış!";
                            frmMessageBox.Show();
                        }
                    }
                    catch { myReader.Close(); }
                }
            }
        }

        public void Send()
        {
            if (cmb_durum.Checked)
            {
                if (rbGelen.Checked)
                {
                    db.UpdateFaturalar(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_proje_no.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('G'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENDI"), Convert.ToString(cmb_se.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                }
                if (rbKesilen.Checked)
                {
                    db.UpdateFaturalar(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_proje_no.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('K'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENDI"), Convert.ToString(cmb_gelense.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                }
            }
            else
            {
                if (rbGelen.Checked)
                {
                    db.UpdateFaturalar(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_proje_no.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('G'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENMEDI"), Convert.ToString(cmb_se.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                }
                if (rbKesilen.Checked)
                {
                    db.UpdateFaturalar(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_proje_no.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('K'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENMEDI"), Convert.ToString(cmb_gelense.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                }
            }
        }
    }
}
