using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class AnaEkran : MetroFramework.Forms.MetroForm
    {
        string komut;
        MySqlCommand myCommand;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        HarrProgressBar pgb1 = new HarrProgressBar();
        HarrProgressBar pgb2 = new HarrProgressBar();
        HarrProgressBar pgb3 = new HarrProgressBar();
        string proje_butce;
        string harcama_toplam;
        string gelenFtr;
        string kesilenFtr;
        int BarKesilenftr;
        int BarZaman;
        int BarButce;

        public AnaEkran()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //--------------------------------------- BAĞLANTI ----------------------------------------------------------------
            mySqlConnection.Open();
            //-----------------------------------------------------------------------------------------------------------------
            //------------------------------------- ÇOK ACİL İŞLER ------------------------------------------------------------
            komut = "SELECT * FROM db_aktivite WHERE akt_oncelik='COK ACİL' AND akt_statu='AKTİF'";
            myCommand = new MySqlCommand(komut, mySqlConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            da.Fill(dt);
            //dg_cokacil.DataSource = dt;
            //dg_cokacil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dg_cokacil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //-----------------------------------------------------------------------------------------------------------------

            mySqlConnection.Close();
        }

        private void faturaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaGiris frmFaturaGiris = new FaturaGiris();
            frmFaturaGiris.Show();
        }

        private void faturalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Faturalar frmFaturalar = new Faturalar();
            frmFaturalar.Show();
        }

        private void projeGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeGiris frmProjeGiris = new ProjeGiris();
            frmProjeGiris.Show();
        }

        private void projelerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Projeler frmProjeler = new Projeler();
            frmProjeler.Show();
        }

        private void siparişEmriGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisEmriGiris frmSiparisEmriGiris = new SiparisEmriGiris();
            frmSiparisEmriGiris.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisEmirleri frmSiparisEmirleri = new SiparisEmirleri();
            frmSiparisEmirleri.Show();
        }

        private void projeyeGöreRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeyeGoreRapor frmProjeyeGoreRapor = new ProjeyeGoreRapor();
            frmProjeyeGoreRapor.Show();
        }

        private void btn_grafik_Click(object sender, EventArgs e)
        {
           
        }

        private void progressbarlar()
        {
            mySqlConnection.Open();
            komut = "SELECT proje_baslangic,proje_bitis,proje_butce,harcama_toplam FROM db_projeler where proje_no='" + cmb_Barprojeler.Text + "'";
            da = new MySqlDataAdapter(komut, mySqlConnection);
            myCommand = new MySqlCommand(komut, mySqlConnection);
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                var start = Convert.ToDateTime(myReader.GetString(0));
                var end = Convert.ToDateTime(myReader.GetString(1));
                proje_butce = myReader.GetString(2);
                harcama_toplam = myReader.GetString(3);
                var total = (end - start).TotalDays;
                BarZaman = Convert.ToInt32(Math.Truncate((DateTime.Now - start).TotalDays * 100 / total));
                
                pgb1.Padding = new Padding(5);
                pgb1.LeftText = "1";
                pgb1.MainText = "PROJE TAKVİM DURUMU";
                pgb1.FillDegree = BarZaman;
                pgb1.RightText = "1";
                pgb1.StatusText = BarZaman.ToString();
                pgb1.StatusBarColor = 0;
                pgb1.Size = flw_tarih.Size;
                pgb1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                this.flw_tarih.Controls.Clear();
                this.flw_tarih.Controls.Add(pgb1);
            }
            myReader.Close();

            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar where fatura_tipi='G' and fatura_proje_no='" + cmb_Barprojeler.Text + "'";
                da = new MySqlDataAdapter(komut, mySqlConnection);
                myCommand = new MySqlCommand(komut, mySqlConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                     gelenFtr = myReader.GetString(0);
                }
                myReader.Close();
            }
            catch
            {
                gelenFtr = "0";
               myReader.Close();
            }
            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar where fatura_tipi='K' and fatura_proje_no='" + cmb_Barprojeler.Text + "'";
                da = new MySqlDataAdapter(komut, mySqlConnection);
                myCommand = new MySqlCommand(komut, mySqlConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    kesilenFtr = myReader.GetString(0);
                }
                myReader.Close();
            }
            catch
            {
                kesilenFtr = "0";
                myReader.Close();
            }

            try
            {
                BarButce = Convert.ToInt32(Math.Truncate(((100) * (Convert.ToDecimal(gelenFtr)) / (Convert.ToDecimal(harcama_toplam)))));

                pgb2.Padding = new Padding(5);
                pgb2.LeftText = "2";
                pgb2.MainText = "PROJE BÜTÇE DURUMU";
                if (BarButce == 0)
                { pgb2.FillDegree = 1; }
                else
                { pgb2.FillDegree = BarButce; }
                pgb2.RightText = "2";
                pgb2.StatusText = BarButce.ToString();
                pgb2.StatusBarColor = 0;
                pgb2.Size = flw_butce.Size;
                pgb2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                this.flw_butce.Controls.Clear();
                this.flw_butce.Controls.Add(pgb2);
            }
            catch { }

            try
            {
                BarKesilenftr = Convert.ToInt32(Math.Truncate(((100 - 0) * (Convert.ToDecimal(kesilenFtr) - 0) / (Convert.ToDecimal(proje_butce) - 0)) + 0));

                pgb3.Padding = new Padding(5);
                pgb3.LeftText = "3";
                pgb3.MainText = "PROJE FATURA DURUMU";
                if (BarKesilenftr == 0)
                { pgb3.FillDegree = 1; }
                else
                { pgb3.FillDegree = BarKesilenftr; }
                pgb3.RightText = "3";
                pgb3.StatusText = BarKesilenftr.ToString();
                pgb3.StatusBarColor = 0;
                pgb3.Size = flw_fatura.Size;
                pgb3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                this.flw_fatura.Controls.Clear();
                this.flw_fatura.Controls.Add(pgb3);
            }
            catch { }

            mySqlConnection.Close();
          

        }

        private void cmb_Barprojeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressbarlar();
        }
    }
}
