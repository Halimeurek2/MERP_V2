using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class Faturalar : MetroFramework.Forms.MetroForm
    {
        DataTable dt;
        MySqlDataAdapter da;
        MySqlDataReader myReader;

        string id;
        string firma;
        string proje_no;
        string fatura_no;
        string birim;
        string tutar;
        int check;
        string avans;
        string vade;
        DateTime vade_tarih;
        DateTime odendi_tarih;
        DateTime fatura_tarih;
        string aciklama;
        string tip;
        string cins;
        string durum;
        string satinalma_no;

        public Faturalar()
        {
            InitializeComponent();
            dt = new DataTable();
            da = new MySqlDataAdapter();
        }

        private void Faturalar_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //---------------FATURALAR-------------------------------------------
            mySqlDataAdapter.Fill(dt);
            dgw_faturalar.DataSource = dt;
            dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgw_faturalar.Columns[9].DefaultCellStyle.Format = "N2";
            dgw_faturalar.Columns[12].DefaultCellStyle.Format = "N2";
            dgw_faturalar.Columns[13].DefaultCellStyle.Format = "N2";
            dgw_faturalar.Columns[14].DefaultCellStyle.Format = "N2";
            //---------------------------------------------------------------------

            //--------------------PROJE NO----------------------------------------
            myReader = mySqlCommandProjeler.ExecuteReader();
            while(myReader.Read())
            {
                cmb_proje_no.Items.Add(myReader["proje_no"]);
            }
            myReader.Close();
            //--------------------------------------------------------------------
            
            //----------------------FİRMALAR-------------------------------------
            myReader = mySqlCommandFirmalar.ExecuteReader();
            while (myReader.Read())
            {
                cmb_firma.Items.Add(myReader["fatura_firma"]);
            }
            myReader.Close();
            //--------------------------------------------------------------------
            mySqlConnection.Close();

            SUMDGW();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                FaturaDuzenle ftrDuzenle = new FaturaDuzenle();
                ftrDuzenle.lbl_id.Text = id;
                ftrDuzenle.txt_fatura_no.Text = fatura_no;
                ftrDuzenle.cmb_projeNo.Text = proje_no;
                ftrDuzenle.cmb_firma.Text = firma;
                ftrDuzenle.txt_ftr_vade.Text = vade;
                ftrDuzenle.rcb_aciklama.Text = aciklama;
                ftrDuzenle.date_alarm.Value = vade_tarih;
                ftrDuzenle.date_ftr_tarih.Value = fatura_tarih;
                ftrDuzenle.ck_alarm.Checked = Convert.ToBoolean(check);
                ftrDuzenle.txt_ftr_tutar.Text = tutar;
                ftrDuzenle.cmb_birim.Text = birim;
                ftrDuzenle.txt_avans.Text = avans;
                ftrDuzenle.lbl_tip.Text = tip;
                ftrDuzenle.cmb_ftr_tip.Text = cins;
                ftrDuzenle.cmb_se.Text = satinalma_no;
                if (durum == "ODENDI")
                {
                    ftrDuzenle.cmb_durum.Checked = true;
                    ftrDuzenle.date_odendi.Visible = true;
                    //ftrDuzenle.date_odendi.Value = odendi_tarih;
                }
                else
                {
                    ftrDuzenle.cmb_durum.Checked = false;
                    ftrDuzenle.date_odendi.Visible = false;
                }
                ftrDuzenle.Show();
            }
            catch { }
        }

        private void dgw_faturalar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dgw_faturalar.Rows[e.RowIndex].Cells[0].Value.ToString();
                fatura_no = dgw_faturalar.Rows[e.RowIndex].Cells[1].Value.ToString();
                proje_no = dgw_faturalar.Rows[e.RowIndex].Cells[2].Value.ToString();
                firma = dgw_faturalar.Rows[e.RowIndex].Cells[3].Value.ToString();
                vade = dgw_faturalar.Rows[e.RowIndex].Cells[4].Value.ToString();
                aciklama = dgw_faturalar.Rows[e.RowIndex].Cells[6].Value.ToString();
                vade_tarih = Convert.ToDateTime(dgw_faturalar.Rows[e.RowIndex].Cells[5].Value.ToString());
                fatura_tarih = Convert.ToDateTime(dgw_faturalar.Rows[e.RowIndex].Cells[7].Value.ToString());
                check = Convert.ToInt32(dgw_faturalar.Rows[e.RowIndex].Cells[8].Value);
                tutar = dgw_faturalar.Rows[e.RowIndex].Cells[9].Value.ToString();
                birim = dgw_faturalar.Rows[e.RowIndex].Cells[10].Value.ToString();
                avans = dgw_faturalar.Rows[e.RowIndex].Cells[11].Value.ToString();
                tip = dgw_faturalar.Rows[e.RowIndex].Cells[15].Value.ToString();
                cins = dgw_faturalar.Rows[e.RowIndex].Cells[16].Value.ToString();
                durum = dgw_faturalar.Rows[e.RowIndex].Cells[17].Value.ToString();
                satinalma_no = dgw_faturalar.Rows[e.RowIndex].Cells[18].Value.ToString();
            }
            catch { }
        }

        public void RefreshFilter()
        {
            mySqlConnection.Close();
            mySqlCommand1.CommandText = "SELECT * FROM db_faturalar where fatura_no like '%" + txt_fatura_no.Text + "%' and fatura_proje_no like '%" + cmb_proje_no.Text + "%' and fatura_firma like '%" + cmb_firma.Text + "%' and fatura_tipi like '%" + txt_tip.Text + "%'";
            da = new MySqlDataAdapter(mySqlCommand1);
            dt.Clear();
            da.Fill(dt);
            dgw_faturalar.DataSource = dt;
            dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mySqlConnection.Close();
        }

        private void txt_fatura_no_TextChanged(object sender, EventArgs e)
        {
            RefreshFilter();
            SUMDGW();
        }

        private void cmb_proje_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlConnection.Close();
            if (cmb_proje_no.Text == "Hepsi")
            {
                mySqlCommand1.CommandText = "SELECT * FROM db_faturalar";
                da = new MySqlDataAdapter(mySqlCommand1);
                dt.Clear();
                da.Fill(dt);
                dgw_faturalar.DataSource = dt;
                dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                mySqlConnection.Close();

                cmb_firma.Text = "";
                txt_fatura_no.Text = "";
                txt_tip.Text = "";
            }
            else
            {
                RefreshFilter();
            }
            SUMDGW();
        }

        private void cmb_firma_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFilter();
            SUMDGW();
        }

        private void txt_tip_TextChanged(object sender, EventArgs e)
        {
            RefreshFilter();
            SUMDGW();
        }

        public void SUMDGW()
        {
            try
            {
                decimal a = 0;
                foreach (DataGridViewRow r in dgw_faturalar.Rows)
                {
                    {
                        a += Convert.ToDecimal(r.Cells[12].Value);
                    }
                    lbl_toplam.Text = Convert.ToString(a);
                    lbl_toplam.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(lbl_toplam.Text));
                }
            } catch  { }

            try
            {
                mySqlConnection.Open();
                mySqlCommand1.CommandText = "SELECT fatura_cinsi,sum(fatura_euro) from db_faturalar group by(fatura_cinsi);";
                myReader = mySqlCommand1.ExecuteReader();
                while(myReader.Read())
                {
                    if(myReader.GetString(0)=="Elektronik") { lbl_elektronik.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1))); }
                    if(myReader.GetString(0) == "Genel Giderler") { lbl_gnlgiderler.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1))); }
                    if(myReader.GetString(0) == "Mekanik") { lbl_mekanik.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(1))); }
                }
            }
            catch { }
        }

        private void dgw_faturalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dgw_faturalar.Rows[e.RowIndex].Cells[0].Value.ToString();
                fatura_no = dgw_faturalar.Rows[e.RowIndex].Cells[1].Value.ToString();
                proje_no = dgw_faturalar.Rows[e.RowIndex].Cells[2].Value.ToString();
                firma = dgw_faturalar.Rows[e.RowIndex].Cells[3].Value.ToString();
                vade = dgw_faturalar.Rows[e.RowIndex].Cells[4].Value.ToString();
                aciklama = dgw_faturalar.Rows[e.RowIndex].Cells[6].Value.ToString();
                vade_tarih = Convert.ToDateTime(dgw_faturalar.Rows[e.RowIndex].Cells[5].Value.ToString());
                fatura_tarih = Convert.ToDateTime(dgw_faturalar.Rows[e.RowIndex].Cells[7].Value.ToString());
                check = Convert.ToInt32(dgw_faturalar.Rows[e.RowIndex].Cells[8].Value);
                tutar = dgw_faturalar.Rows[e.RowIndex].Cells[9].Value.ToString();
                birim = dgw_faturalar.Rows[e.RowIndex].Cells[10].Value.ToString();
                avans = dgw_faturalar.Rows[e.RowIndex].Cells[11].Value.ToString();
                tip = dgw_faturalar.Rows[e.RowIndex].Cells[15].Value.ToString();
                cins = dgw_faturalar.Rows[e.RowIndex].Cells[16].Value.ToString();
                durum = dgw_faturalar.Rows[e.RowIndex].Cells[17].Value.ToString();
                satinalma_no = dgw_faturalar.Rows[e.RowIndex].Cells[18].Value.ToString();
            }
            catch { }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cmb_firma.Text = "";
            cmb_proje_no.Text = "";
            txt_fatura_no.Text = "";
            txt_tip.Text = "";

            mySqlConnection.Close();
            mySqlCommand1.CommandText = "SELECT * FROM db_faturalar";
            da = new MySqlDataAdapter(mySqlCommand1);
            dt.Clear();
            da.Fill(dt);
            dgw_faturalar.DataSource = dt;
            dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_faturalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            mySqlConnection.Close();
        }
    }
}
