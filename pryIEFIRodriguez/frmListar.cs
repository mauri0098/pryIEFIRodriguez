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
    public partial class frmListar : Form
    {
        string[,] varmatriz;
        string varoperacion;

        public frmListar(string varoperacion, string[,]varmatriz)
        {
            InitializeComponent();

            if (varoperacion=="Productos")
            {
                this.Text = "Listados de Productos";
                for (int f = 0; f < varmatriz.GetLength(0); f++)
                {
                    lstProductos.Items.Add("Productos" + (f, +1).ToString());
                    lstProductos.Items.Add(" Nombre: " + varmatriz[f,0] + " ID:"+varmatriz[f,1] + " Fecha: " + varmatriz[f,2]);
                }

            }

            
        }

        private void frmListar_Load(object sender, EventArgs e)
        {

        }
    }
}
