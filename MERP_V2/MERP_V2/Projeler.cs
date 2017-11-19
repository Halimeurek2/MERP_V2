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
    }
}
