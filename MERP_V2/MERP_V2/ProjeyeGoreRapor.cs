using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERP_V2
{
    public partial class ProjeyeGoreRapor : MetroFramework.Forms.MetroForm
    {
        public ProjeyeGoreRapor()
        {
            InitializeComponent();
        }

        private void ProjeyeGoreRapor_Load(object sender, EventArgs e)
        {

        }

        private void btn_frmRapor_Click(object sender, EventArgs e)
        {
            FirmaRapor frmFirmaRapor = new FirmaRapor();
            frmFirmaRapor.Show();
        }

        private void btn_ozetRapor_Click(object sender, EventArgs e)
        {
            OdenecekFaturalar frmOdecekFaturalar = new OdenecekFaturalar();
            frmOdecekFaturalar.Show();
        }
    }
}
