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
    public partial class ProjeGiris : MetroFramework.Forms.MetroForm
    {
        public ProjeGiris()
        {
            InitializeComponent();
        }

        private void ProjeGiris_Load(object sender, EventArgs e)
        {

        }

        private void btn_harcamalar_Click(object sender, EventArgs e)
        {
            HarcamaOngorusu frmHarcamaOngorusu = new HarcamaOngorusu();
            frmHarcamaOngorusu.Show();
        }
    }
}
