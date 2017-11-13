using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            mySqlCommand.CommandText= "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Elektronik' and fatura_tipi='G' and fatura_proje_no='910.20' group by fatura_firma order by sum(fatura_euro) DESC";
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
            //------------------------------------- MEKANİK-----------------------------------------------------------------
            index = 0;
            mySqlCommand.CommandText = "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Mekanik' and fatura_tipi='G' and fatura_proje_no='910.20' group by fatura_firma order by sum(fatura_euro) DESC";
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
            //------------------------------------- GENEL GİDERLER------------------------------------------------------------
            index = 0;
            mySqlCommand.CommandText = "SELECT fatura_firma,sum(fatura_euro) from db_faturalar where fatura_cinsi='Genel Giderler' and fatura_tipi='G' and fatura_proje_no='910.20' group by fatura_firma order by sum(fatura_euro) DESC";
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
        }
    }
}
