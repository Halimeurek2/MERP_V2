using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class FaturaGiris : MetroFramework.Forms.MetroForm
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

        Boolean CokluFatura = false;

        public FaturaGiris()
        {
            InitializeComponent();
            hf = new HelperFunctions();
            db = new DBConnect();
        }

        private void FaturaGiris_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------- Projeler-----------------------------------------------------------------
            myReader = mySqlCommandProjeNo.ExecuteReader();
            while (myReader.Read())
            {
                cmb_projeNo.Items.Add(myReader["proje_no"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------- Firmalar-----------------------------------------------------------------
            myReader = mySqlCommandFirmalar.ExecuteReader();
            while (myReader.Read())
            {
                cmb_firma.Items.Add(myReader["fatura_firma"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            //--------------------------------------- Satinalma No-------------------------------------------------------------
            myReader = mySqlCommandSatinAlmaNo.ExecuteReader();
            while (myReader.Read())
            {
                cmb_gelense.Items.Add(myReader["satinalma_no"]);
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
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
                txt_ftr_tutar.Text = hf.Dot2Comma(txt_ftr_tutar.Text);
                fatura_euro = Convert.ToDecimal(hf.EuroCalculation(date_ftr_tarih.Text, txt_ftr_tutar.Text, cmb_birim.Text, Convert.ToString(fatura_euro)));
                fatura_dolar = Convert.ToDecimal(hf.DolarCalculation(date_ftr_tarih.Text, txt_ftr_tutar.Text, cmb_birim.Text, Convert.ToString(fatura_dolar)));
                fatura_tl = Convert.ToDecimal(hf.TLCalculation(date_ftr_tarih.Text, txt_ftr_tutar.Text, cmb_birim.Text, Convert.ToString(fatura_tl)));

                if (fatura_euro == Convert.ToDecimal(0000))
                {
                    frmMessageBox = new FormMessageBox();
                    frmMessageBox.txt_mesaj.Text = "İnternete Bağlanınız!";
                    frmMessageBox.Show();
                }
                else
                {
                    if (txt_fatura_no.Text == "T111" || txt_fatura_no.Text == "M111" || txt_fatura_no.Text == "M222")
                    {
                        Send();
                        CokluFaturaGirisi();
                    }
                    else if(txt_fatura_no.Text == "A111")
                    {
                        if (rbGelen.Checked)
                        {
                            db.InsertFaturaGiris(Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_projeNo.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('A'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENDI"), Convert.ToString(cmb_se.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                        }
                        if (rbKesilen.Checked)
                        {
                            db.InsertFaturaGiris(Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_projeNo.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('V'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENDI"), Convert.ToString(cmb_gelense.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                        }
                        CokluFaturaGirisi();
                    }
                    else
                    {
                        try
                        {
                            myReader.Close();
                            mySqlCommand.CommandText = "SELECT * FROM db_faturalar where fatura_no='" + txt_fatura_no.Text + "'";
                            myReader = mySqlCommand.ExecuteReader();
                            while (myReader.Read()) { }
                            if(myReader.HasRows==false)
                            {
                                Send();
                                CokluFaturaGirisi();
                                myReader.Close();
                            }
                            else
                            {
                                frmMessageBox = new FormMessageBox();
                                frmMessageBox.txt_mesaj.Text = "Fatura No önceden kullanılmış!";
                                frmMessageBox.Show();
                            }
                        } catch { myReader.Close(); }
                    }
                }
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
            {  }
        }

        private void ck_cokluftr_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_cokluftr.Checked)
            {
                CokluFatura = true;
            }
            else
            {
                CokluFatura = false;
            }
        }

        private void rbKesilen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKesilen.Checked)
            {
                cmb_gelense.Visible = true;
            }
            else
            {
                cmb_gelense.Visible = false;
            }
        }

        private void rbGelen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGelen.Checked)
            {
                cmb_se.Visible = true;
            }
            else
            {
                cmb_se.Visible = false;
            }
        }

        private void cmb_avans_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_avans.Checked)
            {
                cmb_durum.Checked = true;
                txt_fatura_no.Text = "A111";
                cmb_ftr_tip.Text = "Kesilen";
                txt_ftr_vade.Enabled = false;
                ck_cokluftr.Enabled = false;
                date_alarm.Enabled = false;
                ck_alarm.Enabled = false;
                txt_avans.Enabled = false;
                lbl_tarih.Text = "Avans Tarihi :";
                lbl_tip.Text = "Avans Tipi :";
                lbl_tutar.Text = "Avans Tutarı :";
                rbGelen.Text = "Alınan Avans";
                rbKesilen.Text = "Verilen Avans";
            }
            else
            {
                cmb_durum.Checked = false;
                txt_fatura_no.Text = "";
                cmb_ftr_tip.Text = "";
                txt_ftr_vade.Enabled = true;
                ck_cokluftr.Enabled = true;
                date_alarm.Enabled = true;
                ck_alarm.Enabled = true;
                txt_avans.Enabled = true;
                lbl_tarih.Text = "Fatura Tarihi :";
                lbl_tip.Text = "Fatura Tipi :";
                lbl_tutar.Text = "Fatura Tutarı :";
                rbGelen.Text = "Gelen Fatura";
                rbKesilen.Text = "Kesilen Fatura";
            }
        }

        public void Send()
        {
            if (cmb_durum.Checked)
            {
                if (rbGelen.Checked)
                {
                    db.InsertFaturaGiris(Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_projeNo.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('G'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENDI"), Convert.ToString(cmb_se.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                }
                if (rbKesilen.Checked)
                {
                    db.InsertFaturaGiris(Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_projeNo.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('K'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENDI"), Convert.ToString(cmb_gelense.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                }
            }
            else
            {
                if (rbGelen.Checked)
                {
                    db.InsertFaturaGiris(Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_projeNo.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('G'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENMEDI"), Convert.ToString(cmb_se.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                }
                if (rbKesilen.Checked)
                {
                    db.InsertFaturaGiris(Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_projeNo.Text), Convert.ToString(cmb_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Value), Convert.ToString(rcb_aciklama.Text), Convert.ToDateTime(date_ftr_tarih.Value), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), fatura_euro, fatura_dolar, fatura_tl, Convert.ToString('K'), Convert.ToString(cmb_ftr_tip.Text), Convert.ToString("ODENMEDI"), Convert.ToString(cmb_gelense.Text), Convert.ToDateTime(date_odendi.Value), Convert.ToDateTime(DateTime.Now));
                }
            }
        }

        public void CokluFaturaGirisi()
        {
            if (CokluFatura == true)
            {
                txt_avans.Text = "";
                txt_fatura_no.Text = "";
                txt_ftr_tutar.Text = "";
                txt_ftr_vade.Text = "";
                ck_alarm.Checked = false;
                cmb_durum.Checked = false;
                rbGelen.Checked = false;
                rbKesilen.Checked = false;
                cmb_birim.Text = "";
                cmb_firma.Text = "";
                cmb_ftr_tip.Text = "";
                cmb_projeNo.Text = "";
                rcb_aciklama.Text = "";
                date_alarm.Value = DateTime.Now;
                date_ftr_tarih.Value = DateTime.Now;
                myReader.Close();
            }
            else
            { this.Close(); }
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
    }
}
