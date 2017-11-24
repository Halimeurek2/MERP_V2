using System;
using System.Globalization;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class HarcamaOngorusu : MetroFramework.Forms.MetroForm
    {
        HelperFunctions hf;
        ProjeDuzenle prjDuzenle;
        ProjeGiris prjGiris;

        int indexH = 0;
        int indexO = 0;
        string toplam_euro;
        public string toplam = "0";

        public HarcamaOngorusu()
        {
            InitializeComponent();
            hf = new HelperFunctions();
        }

        private void HarcamaOngorusu_Load(object sender, EventArgs e)
        {
            prjGiris = (ProjeGiris)Application.OpenForms["ProjeGiris"];
            prjDuzenle = (ProjeDuzenle)Application.OpenForms["ProjeDuzenle"];

            if(prjGiris != null)
            {
                indexH = 0;
                indexO = 0;
            }
            else
            {
                indexH = dgw_harcama.Rows.Count - 1;
                indexO = dgw_odeme.Rows.Count - 1;
            }
        }

        private void btn_ekleH_Click(object sender, EventArgs e)
        {
            dgw_harcama.Rows.Add();
            dgw_harcama.Rows[indexH].Cells[0].Value = date_tarihH.Text;
            dgw_harcama.Rows[indexH].Cells[1].Value = cmb_tipH.Text;
            dgw_harcama.Rows[indexH].Cells[2].Value = txt_tutarH.Text;
            dgw_harcama.Rows[indexH].Cells[3].Value = cmb_birimH.Text;
            indexH++;
        }

        private void btn_ekleO_Click(object sender, EventArgs e)
        {
            dgw_odeme.Rows.Add();
            dgw_odeme.Rows[indexO].Cells[0].Value = date_tarihO.Text;
            dgw_odeme.Rows[indexO].Cells[1].Value = cmb_tipO.Text;
            dgw_odeme.Rows[indexO].Cells[2].Value = txt_tutarO.Text;
            dgw_odeme.Rows[indexO].Cells[3].Value = cmb_birimO.Text;
            indexO++;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgw_harcama.SelectedRows.Count > 0)
            {
                dgw_harcama.Rows.RemoveAt(this.dgw_harcama.SelectedRows[0].Index);
                indexH--;
            }
            if (this.dgw_odeme.SelectedRows.Count > 0)
            {
                dgw_odeme.Rows.RemoveAt(this.dgw_odeme.SelectedRows[0].Index);
                indexO--;
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgw_harcama.Rows.Count - 1; i++)
            {
                dgw_harcama.Rows[i].Cells[2].Value = hf.Dot2Comma(Convert.ToString(dgw_harcama.Rows[i].Cells[2].Value));
                toplam_euro = hf.EuroCalculation(Convert.ToString(Convert.ToDateTime(dgw_harcama.Rows[i].Cells[0].Value)), Convert.ToString(dgw_harcama.Rows[i].Cells[2].Value), Convert.ToString(dgw_harcama.Rows[i].Cells[3].Value), toplam_euro);
                toplam = Convert.ToString(Convert.ToDecimal(toplam_euro) + Convert.ToDecimal(toplam));
            }
            
            if (prjGiris != null)
            {
                prjGiris.lbl_harcamalar.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(toplam));
            }
            this.Hide();
        }
    }
}
