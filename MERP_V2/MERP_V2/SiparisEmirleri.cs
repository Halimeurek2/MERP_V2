using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class SiparisEmirleri : MetroFramework.Forms.MetroForm
    {
        DataTable dt;
        MySqlDataAdapter da;
        MySqlDataReader myReader;

        string id;
        string proje_no;
        string tedarikci;
        string satinalma_no;
        string olusturan;
        string vade;
        string fiyat_birim;
        string aciklama;
        string fiyat;
        string siparis_tipi;
        DateTime siparis_tarihi;
        DateTime temin_tarihi;

        public SiparisEmirleri()
        {
            InitializeComponent();
            dt = new DataTable();
            da = new MySqlDataAdapter();
        }

        private void SiparisEmirleri_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //----------------------------------------SİPARİŞ EMİRLERİ---------------------------------------------------------
            mySqlDataAdapter.Fill(dt);
            dgw_siparisemirleri.DataSource = dt;
            dgw_siparisemirleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_siparisemirleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgw_siparisemirleri.Columns[8].DefaultCellStyle.Format = "N2";
            dgw_siparisemirleri.Columns[10].DefaultCellStyle.Format = "N2";
            dgw_siparisemirleri.Columns[11].DefaultCellStyle.Format = "N2";
            dgw_siparisemirleri.Columns[12].DefaultCellStyle.Format = "N2";
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
            mySqlConnection.Close();
            SumDGW();
        }

        public void SumDGW()
        {
            try
            {
                decimal a = 0;
                foreach (DataGridViewRow r in dgw_siparisemirleri.Rows)
                {
                    {
                        a += Convert.ToDecimal(r.Cells[10].Value);
                    }
                    lbl_toplam.Text = Convert.ToString(a);
                    lbl_toplam.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(lbl_toplam.Text));
                }
            }
            catch { }
        }

        public void RefreshFilter()
        {
            mySqlConnection.Close();
            mySqlCommand.CommandText = "SELECT * FROM db_siparis_emri where proje_no like '%" + cmb_proje_no.Text + "%' and satinalma_no like '%" + txt_satinalma_no.Text + "%' and tedarikci like '%" + txt_tedarikci.Text + "%'";
            da = new MySqlDataAdapter(mySqlCommand);
            dt.Clear();
            da.Fill(dt);
            dgw_siparisemirleri.DataSource = dt;
            dgw_siparisemirleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_siparisemirleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mySqlConnection.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cmb_proje_no.Text = "";
            txt_satinalma_no.Text = "";
            txt_tedarikci.Text = "";

            mySqlConnection.Close();
            mySqlCommand.CommandText = mySqlCommandListele.CommandText;
            da = new MySqlDataAdapter(mySqlCommand);
            dt.Clear();
            da.Fill(dt);
            dgw_siparisemirleri.DataSource = dt;
            dgw_siparisemirleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_siparisemirleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgw_siparisemirleri.Columns[8].DefaultCellStyle.Format = "N2";
            dgw_siparisemirleri.Columns[10].DefaultCellStyle.Format = "N2";
            dgw_siparisemirleri.Columns[11].DefaultCellStyle.Format = "N2";
            dgw_siparisemirleri.Columns[12].DefaultCellStyle.Format = "N2";
            mySqlConnection.Close();
        }

        private void txt_satinalma_no_TextChanged(object sender, EventArgs e)
        {
            RefreshFilter();
            SumDGW();
        }

        private void txt_tedarikci_TextChanged(object sender, EventArgs e)
        {
            RefreshFilter();
            SumDGW();
        }

        private void cmb_proje_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_proje_no.Text == "Hepsi")
            {
                mySqlConnection.Close();
                mySqlCommand.CommandText = mySqlCommandListele.CommandText;
                da = new MySqlDataAdapter(mySqlCommand);
                dt.Clear();
                da.Fill(dt);
                dgw_siparisemirleri.DataSource = dt;
                dgw_siparisemirleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgw_siparisemirleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgw_siparisemirleri.Columns[8].DefaultCellStyle.Format = "N2";
                dgw_siparisemirleri.Columns[10].DefaultCellStyle.Format = "N2";
                dgw_siparisemirleri.Columns[11].DefaultCellStyle.Format = "N2";
                dgw_siparisemirleri.Columns[12].DefaultCellStyle.Format = "N2";
                mySqlConnection.Close();
            }
            else
            {
                RefreshFilter();
            }
            SumDGW();
        }

        private void dgw_siparisemirleri_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dgw_siparisemirleri.Rows[e.RowIndex].Cells[0].Value.ToString();
                proje_no = dgw_siparisemirleri.Rows[e.RowIndex].Cells[1].Value.ToString();
                satinalma_no = dgw_siparisemirleri.Rows[e.RowIndex].Cells[2].Value.ToString();
                tedarikci = dgw_siparisemirleri.Rows[e.RowIndex].Cells[3].Value.ToString();
                olusturan = dgw_siparisemirleri.Rows[e.RowIndex].Cells[4].Value.ToString();
                siparis_tarihi = Convert.ToDateTime(dgw_siparisemirleri.Rows[e.RowIndex].Cells[5].Value);
                vade = dgw_siparisemirleri.Rows[e.RowIndex].Cells[6].Value.ToString();
                temin_tarihi = Convert.ToDateTime(dgw_siparisemirleri.Rows[e.RowIndex].Cells[7].Value);
                fiyat = dgw_siparisemirleri.Rows[e.RowIndex].Cells[8].Value.ToString();
                fiyat_birim = dgw_siparisemirleri.Rows[e.RowIndex].Cells[9].Value.ToString();
                aciklama = dgw_siparisemirleri.Rows[e.RowIndex].Cells[13].Value.ToString();
                siparis_tipi = dgw_siparisemirleri.Rows[e.RowIndex].Cells[14].Value.ToString();
            }
            catch { }
        }

        private void dgw_siparisemirleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dgw_siparisemirleri.Rows[e.RowIndex].Cells[0].Value.ToString();
                proje_no = dgw_siparisemirleri.Rows[e.RowIndex].Cells[1].Value.ToString();
                satinalma_no = dgw_siparisemirleri.Rows[e.RowIndex].Cells[2].Value.ToString();
                tedarikci = dgw_siparisemirleri.Rows[e.RowIndex].Cells[3].Value.ToString();
                olusturan = dgw_siparisemirleri.Rows[e.RowIndex].Cells[4].Value.ToString();
                siparis_tarihi = Convert.ToDateTime(dgw_siparisemirleri.Rows[e.RowIndex].Cells[5].Value);
                vade = dgw_siparisemirleri.Rows[e.RowIndex].Cells[6].Value.ToString();
                temin_tarihi = Convert.ToDateTime(dgw_siparisemirleri.Rows[e.RowIndex].Cells[7].Value);
                fiyat = dgw_siparisemirleri.Rows[e.RowIndex].Cells[8].Value.ToString();
                fiyat_birim = dgw_siparisemirleri.Rows[e.RowIndex].Cells[9].Value.ToString();
                aciklama = dgw_siparisemirleri.Rows[e.RowIndex].Cells[13].Value.ToString();
                siparis_tipi = dgw_siparisemirleri.Rows[e.RowIndex].Cells[14].Value.ToString();
            }
            catch { }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SiparisEmriDuzenle seDuzenle = new SiparisEmriDuzenle();
                seDuzenle.lbl_id.Text = id;
                seDuzenle.cmb_proje_no.Text = proje_no;
                seDuzenle.txt_siparis_no.Text = satinalma_no;
                seDuzenle.cmb_tedarikci.Text = tedarikci;
                seDuzenle.txt_talepKisi.Text = olusturan;
                seDuzenle.date_teslim.Value = siparis_tarihi;
                seDuzenle.txt_vade.Text = vade;
                seDuzenle.date_temin.Value = temin_tarihi;
                seDuzenle.txt_fiyat.Text = fiyat;
                seDuzenle.cmb_birim.Text = fiyat_birim;
                seDuzenle.rcb_aciklama.Text = aciklama;
                if (siparis_tipi == "Gelen")
                {
                    seDuzenle.rbGelen.Checked = true;
                }
                else if (siparis_tipi == "Verilen")
                {
                    seDuzenle.rbVerilen.Checked = true;
                }
                seDuzenle.Show();
            }
            catch { }
        }
    }
}
