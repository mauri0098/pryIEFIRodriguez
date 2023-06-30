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
                this.varmatriz =varmatriz;
                for (int f = 0; f < varmatriz.GetLength(0); f++)
                {
                    if (varmatriz[f, 0]!=null )
                    {

                        lstProductos.Items.Add("Productos" + (f ,+1).ToString());
                        lstProductos.Items.Add(" Nombre: " + varmatriz[f,0] + " ID:"+  varmatriz[f,1] + " Fecha: " +  varmatriz[f,2]);
                    }
                }

            }
            else
            {
                if (varoperacion == "Ventas")
                {
                    this.Text = "Listados de Ventas";
                    this.varmatriz = varmatriz;
                    for (int f = 0; f < varmatriz.GetLength(0); f++)
                    {
                        if (varmatriz[f, 0] != null)
                        {
                            lstVentas.Items.Add("Ventas" + (f +1).ToString());
                            lstVentas.Items.Add(" Productos " + varmatriz[f, 0] + " ID:" + varmatriz[f, 1] + " Cantidad: " + varmatriz[f, 2] + " Fecha: " + varmatriz[f, 3]);
                        }
                       

                        

                    }

                }

            }

            
        }

        private void frmListar_Load(object sender, EventArgs e)
        {

        }

        private void lstVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
