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

        int panelWidth;
        bool Hided;

        public AnaEkran()
        {
            InitializeComponent();
            panelWidth = pnl_cokacil.Width;
            Hided = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Hided)
            {
                pnl_cokacil.Width = pnl_cokacil.Width + 20;
                if(pnl_cokacil.Width>=panelWidth)
                {
                    timerPanel.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_cokacil.Width = pnl_cokacil.Width - 20;
                if(pnl_cokacil.Width<=0)
                {
                    timerPanel.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            timerPanel.Start();
        }
    }
}
