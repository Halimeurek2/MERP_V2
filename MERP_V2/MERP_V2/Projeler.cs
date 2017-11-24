using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class Projeler : MetroFramework.Forms.MetroForm
    {
        DataTable dt;
        MySqlDataAdapter da;
        MySqlDataReader myReader;

        string id;
        int index = 0;
        string flag;
        public string[] harcama_id = new string[10];
        public string[] odeme_id = new string[10];
        string proje_adi;
        string proje_no;
        string butce;
        string birim;
        string harcamalar;
        string harcama_birim;
        string musteri;
        string vade;
        string aciklama;
        string durum;
        DateTime baslangic;
        DateTime bitis;

        public Projeler()
        {
            InitializeComponent();
            dt = new DataTable();
            da = new MySqlDataAdapter();
        }

        private void Projeler_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //----------------------------------------PROJELER-----------------------------------------------------------------
            mySqlDataAdapter.Fill(dt);
            dgw_projeler.DataSource = dt;
            dgw_projeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_projeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgw_projeler.Columns[3].DefaultCellStyle.Format = "N2";
            dgw_projeler.Columns[4].DefaultCellStyle.Format = "N2";
            dgw_projeler.Columns[5].DefaultCellStyle.Format = "N2";
            dgw_projeler.Columns[7].DefaultCellStyle.Format = "N2";
            dgw_projeler.Columns[13].DefaultCellStyle.Format = "N2";
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
                foreach (DataGridViewRow r in dgw_projeler.Rows)
                {
                    {
                        a += Convert.ToDecimal(r.Cells[13].Value);
                    }
                    lbl_toplam.Text = Convert.ToString(a);
                    lbl_toplam.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(lbl_toplam.Text));
                }
            } catch { }
        }

        private void cmb_proje_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_proje_no.Text=="Hepsi")
            {
                mySqlConnection.Close();
                mySqlCommand.CommandText = mySqlCommandListele.CommandText;
                da = new MySqlDataAdapter(mySqlCommand);
                dt.Clear();
                da.Fill(dt);
                dgw_projeler.DataSource = dt;
                dgw_projeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgw_projeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgw_projeler.Columns[3].DefaultCellStyle.Format = "N2";
                dgw_projeler.Columns[4].DefaultCellStyle.Format = "N2";
                dgw_projeler.Columns[5].DefaultCellStyle.Format = "N2";
                dgw_projeler.Columns[7].DefaultCellStyle.Format = "N2";
                dgw_projeler.Columns[13].DefaultCellStyle.Format = "N2";
                mySqlConnection.Close();
            }
            else
            {
                if (txt_proje_adi.Text == "")
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgw_projeler.DataSource;
                    bs.Filter = dgw_projeler.Columns[1].HeaderText.ToString() + " LIKE '%" + cmb_proje_no.Text + "%'";
                    dgw_projeler.DataSource = bs;

                    dgw_projeler.Refresh();
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgw_projeler.DataSource;
                    bs.Filter = string.Format(dgw_projeler.Columns[1].HeaderText.ToString() + " LIKE '%{0}%' AND " + dgw_projeler.Columns[2].HeaderText.ToString() + " LIKE '%{1}%'",
                                                      cmb_proje_no.Text, txt_proje_adi.Text);
                    dgw_projeler.DataSource = bs;
                }
            }
            SumDGW();
        }

        private void txt_proje_adi_TextChanged(object sender, EventArgs e)
        {
            if (cmb_proje_no.Text == "")
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgw_projeler.DataSource;
                bs.Filter = dgw_projeler.Columns[2].HeaderText.ToString() + " LIKE '%" + txt_proje_adi.Text + "%'";
                dgw_projeler.DataSource = bs;
                dgw_projeler.Refresh();
            }
            else
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgw_projeler.DataSource;
                bs.Filter = string.Format(dgw_projeler.Columns[1].HeaderText.ToString() + " LIKE '%{0}%' AND " + dgw_projeler.Columns[2].HeaderText.ToString() + " LIKE '%{1}%'",
                                                  cmb_proje_no.Text, txt_proje_adi.Text);
                dgw_projeler.DataSource = bs;
            }
            SumDGW();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cmb_proje_no.Text = "";
            txt_proje_adi.Text = "";

            mySqlConnection.Close();
            mySqlCommand.CommandText = mySqlCommandListele.CommandText;
            da = new MySqlDataAdapter(mySqlCommand);
            dt.Clear();
            da.Fill(dt);
            dgw_projeler.DataSource = dt;
            dgw_projeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_projeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgw_projeler.Columns[3].DefaultCellStyle.Format = "N2";
            dgw_projeler.Columns[4].DefaultCellStyle.Format = "N2";
            dgw_projeler.Columns[5].DefaultCellStyle.Format = "N2";
            dgw_projeler.Columns[7].DefaultCellStyle.Format = "N2";
            dgw_projeler.Columns[13].DefaultCellStyle.Format = "N2";
            mySqlConnection.Close();
            SumDGW();
        }

        private void dgw_projeler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dgw_projeler.Rows[e.RowIndex].Cells[0].Value.ToString();
                proje_no = dgw_projeler.Rows[e.RowIndex].Cells[1].Value.ToString();
                proje_adi = dgw_projeler.Rows[e.RowIndex].Cells[2].Value.ToString();
                butce = dgw_projeler.Rows[e.RowIndex].Cells[3].Value.ToString();
                birim = dgw_projeler.Rows[e.RowIndex].Cells[4].Value.ToString();

                musteri = dgw_projeler.Rows[e.RowIndex].Cells[8].Value.ToString();
                baslangic = Convert.ToDateTime(dgw_projeler.Rows[e.RowIndex].Cells[9].Value.ToString());
                bitis = Convert.ToDateTime(dgw_projeler.Rows[e.RowIndex].Cells[10].Value.ToString());
                vade = dgw_projeler.Rows[e.RowIndex].Cells[11].Value.ToString();
                aciklama = dgw_projeler.Rows[e.RowIndex].Cells[12].Value.ToString();
                harcamalar = dgw_projeler.Rows[e.RowIndex].Cells[13].Value.ToString();
                harcama_birim = dgw_projeler.Rows[e.RowIndex].Cells[14].Value.ToString();
                flag = dgw_projeler.Rows[e.RowIndex].Cells[15].Value.ToString();
                durum = dgw_projeler.Rows[e.RowIndex].Cells[16].Value.ToString();
            }
            catch { }
        }

        private void dgw_projeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dgw_projeler.Rows[e.RowIndex].Cells[0].Value.ToString();
                proje_no = dgw_projeler.Rows[e.RowIndex].Cells[1].Value.ToString();
                proje_adi = dgw_projeler.Rows[e.RowIndex].Cells[2].Value.ToString();
                butce = dgw_projeler.Rows[e.RowIndex].Cells[3].Value.ToString();
                birim = dgw_projeler.Rows[e.RowIndex].Cells[4].Value.ToString();

                musteri = dgw_projeler.Rows[e.RowIndex].Cells[8].Value.ToString();
                baslangic = Convert.ToDateTime(dgw_projeler.Rows[e.RowIndex].Cells[9].Value.ToString());
                bitis = Convert.ToDateTime(dgw_projeler.Rows[e.RowIndex].Cells[10].Value.ToString());
                vade = dgw_projeler.Rows[e.RowIndex].Cells[11].Value.ToString();
                aciklama = dgw_projeler.Rows[e.RowIndex].Cells[12].Value.ToString();
                harcamalar = dgw_projeler.Rows[e.RowIndex].Cells[13].Value.ToString();
                harcama_birim = dgw_projeler.Rows[e.RowIndex].Cells[14].Value.ToString();
                flag = dgw_projeler.Rows[e.RowIndex].Cells[15].Value.ToString();
                durum = dgw_projeler.Rows[e.RowIndex].Cells[16].Value.ToString();
            }
            catch { }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                ProjeDuzenle prjDuzenle = new ProjeDuzenle();
                prjDuzenle.lbl_id.Text = id;
                prjDuzenle.cmb_birim.Text = birim;
                prjDuzenle.txt_butce.Text = butce;
                prjDuzenle.txt_musteri.Text = musteri;
                prjDuzenle.txt_proje_adi.Text = proje_adi;
                prjDuzenle.txt_proje_no.Text = proje_no;
                prjDuzenle.dtp_baslangic.Value = baslangic;
                prjDuzenle.dtp_bitis.Value = bitis;
                prjDuzenle.txt_vade.Text = vade;
                prjDuzenle.rcb_aciklama.Text = aciklama;
                prjDuzenle.lbl_harcamalar.Text = harcamalar;
                prjDuzenle.cmb_durum.Text = durum;
                if (flag == "S") { prjDuzenle.rbSeri.Checked = true; }
                else { prjDuzenle.rbProje.Checked = true; }
                prjDuzenle.Show();


                HarcamaOngorusu frmHarcamaOng = new HarcamaOngorusu();

                index = 0;
                mySqlConnection.Close();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM db_projeharcama WHERE harcama_proje='" + id + "'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Array.Resize(ref harcama_id, index + 1);
                    harcama_id[index] = myReader.GetString(0);
                    frmHarcamaOng.dgw_harcama.Rows.Add();
                    frmHarcamaOng.dgw_harcama.Rows[index].Cells[0].Value = Convert.ToDateTime(myReader.GetString(5));
                    frmHarcamaOng.dgw_harcama.Rows[index].Cells[1].Value = myReader.GetString(2);
                    frmHarcamaOng.dgw_harcama.Rows[index].Cells[2].Value = myReader.GetString(3);
                    frmHarcamaOng.dgw_harcama.Rows[index].Cells[3].Value = myReader.GetString(4);
                    index++;
                }
                myReader.Close();

                index = 0;
                mySqlConnection.Close();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM db_projeongoru WHERE ongoru_proje='" + id + "'";
                myReader = mySqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Array.Resize(ref odeme_id, index + 1);
                    odeme_id[index] = myReader.GetString(0);
                    frmHarcamaOng.dgw_odeme.Rows.Add();
                    frmHarcamaOng.dgw_odeme.Rows[index].Cells[0].Value = Convert.ToDateTime(myReader.GetString(5));
                    frmHarcamaOng.dgw_odeme.Rows[index].Cells[1].Value = myReader.GetString(2);
                    frmHarcamaOng.dgw_odeme.Rows[index].Cells[2].Value = myReader.GetString(3);
                    frmHarcamaOng.dgw_odeme.Rows[index].Cells[3].Value = myReader.GetString(4);
                    index++;
                }
                myReader.Close();
                mySqlConnection.Close();
                frmHarcamaOng.Show();
            }
            catch { }
        }
    }
}
