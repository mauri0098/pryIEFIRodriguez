using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFIRodriguez
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdIniciarSesion_Click(object sender, EventArgs e)
        {
            frmCargarProducto frmCargarProducto = new frmCargarProducto();
            this.Hide();
            frmCargarProducto.ShowDialog();

        }
    }
}
