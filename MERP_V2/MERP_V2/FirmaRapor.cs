using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class FirmaRapor : MetroFramework.Forms.MetroForm
    {
        MySqlDataReader myReader;
        DataTable dt = new DataTable();
        int index = 0;

        public FirmaRapor()
        {
            InitializeComponent();
        }

        private void FirmaRapor_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //------------------------------------- ELEKTRONİK-----------------------------------------------------------------
            mySqlCommand.CommandText= "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Elektronik' and fatura_tipi='G' and fatura_proje_no='"+lbl_proje_no.Text+"' group by fatura_firma order by sum(fatura_euro) DESC";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader.GetString(0) != "MASRAF")
                {
                    dgw_elektronik.Rows.Add();
                    dgw_elektronik.Rows[index].Cells[0].Value = myReader.GetString(0);
                    dgw_elektronik.Rows[index].Cells[2].Value = myReader.GetString(1);
                    index++;
                }
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            //------------------------------------- MEKANİK--------------------------------------------------------------------
            index = 0;
            mySqlCommand.CommandText = "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Mekanik' and fatura_tipi='G' and fatura_proje_no='"+lbl_proje_no.Text+"' group by fatura_firma order by sum(fatura_euro) DESC";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader.GetString(0) != "MASRAF")
                {
                    dgw_mekanik.Rows.Add();
                    dgw_mekanik.Rows[index].Cells[0].Value = myReader.GetString(0);
                    dgw_mekanik.Rows[index].Cells[2].Value = myReader.GetString(1);
                    index++;
                }
            }
            myReader.Close();
            //-----------------------------------------------------------------------------------------------------------------
            //------------------------------------- GENEL GİDERLER-------------------------------------------------------------
            index = 0;
            mySqlCommand.CommandText = "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Genel Giderler' and fatura_tipi='G' and fatura_proje_no='"+lbl_proje_no.Text+"' group by fatura_firma order by sum(fatura_euro) DESC";
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader.GetString(0) != "MASRAF")
                {
                    dgw_genel.Rows.Add();
                    dgw_genel.Rows[index].Cells[0].Value = myReader.GetString(0);
                    dgw_genel.Rows[index].Cells[2].Value = myReader.GetString(1);
                    index++;
                }
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

            SiparisToplam();
            OdenenFaturalar();
            Kalan();
        }

        public void SiparisToplam()
        {
            for (int i = 0; i < dgw_genel.Rows.Count; i++)
            {
                try
                {
                    mySqlCommand.CommandText = "SELECT sum(siparis_euro) FROM db_siparis_emri where tedarikci='" + dgw_genel.Rows[i].Cells[0].Value + "';";
                    myReader = mySqlCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        dgw_genel.Rows[i].Cells[1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(0)));
                    }
                    myReader.Close();
                }
                catch
                {
                    dgw_genel.Rows[i].Cells[1].Value = 0;
                    myReader.Close();
                }
            }

            for (int i = 0; i < dgw_elektronik.Rows.Count; i++)
            {
                try
                {
                    mySqlCommand.CommandText = "SELECT sum(siparis_euro) FROM db_siparis_emri where tedarikci='" + dgw_elektronik.Rows[i].Cells[0].Value + "';";
                    myReader = mySqlCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        dgw_elektronik.Rows[i].Cells[1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(0)));
                    }
                    myReader.Close();
                }
                catch
                {
                    dgw_elektronik.Rows[i].Cells[1].Value = 0;
                    myReader.Close();
                }
            }

            for (int i = 0; i < dgw_mekanik.Rows.Count; i++)
            {
                try
                {
                    mySqlCommand.CommandText = "SELECT sum(siparis_euro) FROM db_siparis_emri where tedarikci='" + dgw_mekanik.Rows[i].Cells[0].Value + "';";
                    myReader = mySqlCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        dgw_mekanik.Rows[i].Cells[1].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(myReader.GetString(0)));
                    }
                    myReader.Close();
                }
                catch
                {
                    dgw_mekanik.Rows[i].Cells[1].Value = 0;
                    myReader.Close();
                }
            }
        }

        public void OdenenFaturalar()
        {
            for (int i = 0; i < dgw_genel.Rows.Count; i++)
            {
                try
                {
                    mySqlCommand.CommandText = "SELECT sum(fatura_euro) from db_faturalar where fatura_cinsi='Genel Giderler' and fatura_proje_no='" + lbl_proje_no.Text + "' and fatura_firma='" + dgw_genel.Rows[i].Cells[0].Value + "' and fatura_durum='ODENDI' and fatura_tipi='G'";
                    myReader = mySqlCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        dgw_genel.Rows[i].Cells[3].Value = myReader.GetString(0);
                    }
                    myReader.Close();
                }
                catch
                {
                    dgw_genel.Rows[i].Cells[3].Value = 0;
                    myReader.Close();
                }
            }

            for (int i = 0; i < dgw_elektronik.Rows.Count; i++)
            {
                try
                {
                    mySqlCommand.CommandText = "SELECT sum(fatura_euro) from db_faturalar where fatura_cinsi='Elektronik' and fatura_proje_no='" + lbl_proje_no.Text + "' and fatura_firma='" + dgw_elektronik.Rows[i].Cells[0].Value + "' and fatura_durum='ODENDI' and fatura_tipi='G'";
                    myReader = mySqlCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        dgw_elektronik.Rows[i].Cells[3].Value = myReader.GetString(0);
                    }
                    myReader.Close();
                }
                catch
                {
                    dgw_elektronik.Rows[i].Cells[3].Value = 0;
                    myReader.Close();
                }
            }

            for (int i = 0; i < dgw_mekanik.Rows.Count; i++)
            {
                try
                {
                    mySqlCommand.CommandText = "SELECT sum(fatura_euro) from db_faturalar where fatura_cinsi='Mekanik' and fatura_proje_no='" + lbl_proje_no.Text + "' and fatura_firma='" + dgw_mekanik.Rows[i].Cells[0].Value + "' and fatura_durum='ODENDI' and fatura_tipi='G'";
                    myReader = mySqlCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        dgw_mekanik.Rows[i].Cells[3].Value = myReader.GetString(0);
                    }
                    myReader.Close();
                }
                catch
                {
                    dgw_mekanik.Rows[i].Cells[3].Value = 0;
                    myReader.Close();
                }
            }
        }

        public void Kalan()
        {
            for (int k = 0; k < dgw_elektronik.Rows.Count; k++)
            {
                dgw_elektronik.Rows[k].Cells[4].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", (Convert.ToDecimal(dgw_elektronik.Rows[k].Cells[2].Value) - Convert.ToDecimal(dgw_elektronik.Rows[k].Cells[3].Value)));
                dgw_elektronik.Rows[k].Cells[2].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(dgw_elektronik.Rows[k].Cells[2].Value));
                dgw_elektronik.Rows[k].Cells[3].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(dgw_elektronik.Rows[k].Cells[3].Value));
            }
            for (int k = 0; k < dgw_mekanik.Rows.Count; k++)
            {
                dgw_mekanik.Rows[k].Cells[4].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", (Convert.ToDecimal(dgw_mekanik.Rows[k].Cells[2].Value) - Convert.ToDecimal(dgw_mekanik.Rows[k].Cells[3].Value)));
                dgw_mekanik.Rows[k].Cells[2].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(dgw_mekanik.Rows[k].Cells[2].Value));
                dgw_mekanik.Rows[k].Cells[3].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(dgw_mekanik.Rows[k].Cells[3].Value));
            }
            for (int k = 0; k < dgw_genel.Rows.Count; k++)
            {
                dgw_genel.Rows[k].Cells[4].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", (Convert.ToDecimal(dgw_genel.Rows[k].Cells[2].Value) - Convert.ToDecimal(dgw_genel.Rows[k].Cells[3].Value)));
                dgw_genel.Rows[k].Cells[2].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(dgw_genel.Rows[k].Cells[2].Value));
                dgw_genel.Rows[k].Cells[3].Value = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(dgw_genel.Rows[k].Cells[3].Value));
            }
        }

        private void cmb_firma_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgw_elektronik.DataSource;
            bs.Filter = dgw_elektronik.Columns[0].HeaderText.ToString() + " LIKE '%" + cmb_firma.Text + "%'";
            dgw_elektronik.DataSource = bs;

            dgw_elektronik.Refresh();

            bs.DataSource = dgw_mekanik.DataSource;
            bs.Filter = dgw_mekanik.Columns[0].HeaderText.ToString() + " LIKE '%" + cmb_firma.Text + "%'";
            dgw_mekanik.DataSource = bs;

            dgw_mekanik.Refresh();

            bs.DataSource = dgw_genel.DataSource;
            bs.Filter = dgw_genel.Columns[0].HeaderText.ToString() + " LIKE '%" + cmb_firma.Text + "%'";
            dgw_genel.DataSource = bs;

            dgw_genel.Refresh();
        }
    }
}
