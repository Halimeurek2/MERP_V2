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
    public partial class FormMessageBox : MetroFramework.Forms.MetroForm
    {
        public FormMessageBox()
        {
            InitializeComponent();
        }

        private void FormMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
