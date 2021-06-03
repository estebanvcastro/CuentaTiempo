using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasTiempos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuentas c = new FrmCuentas();
            this.Hide();
            c.ShowDialog();
        }
    }
}
