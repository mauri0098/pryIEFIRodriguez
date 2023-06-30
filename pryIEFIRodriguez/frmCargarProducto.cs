using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFIRodriguez
{
    public partial class frmCargarProducto : Form
    {
        string varID;
        string[,] MatrizProductos
            = new string[3, 3];
        public frmCargarProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (dptFecha.Value>=DateTime.Today)
            {
                if (txtNombre.Text !="")
                {
                    if (txtID.Text != "")
                    {
                        varID = txtID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Falta Completar el ID", "Cargar ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtID.Focus();
                    }
                    
                    MessageBox.Show("vamos a Registrar");

                    
                    
                    int n = dtgvConsultarProducto.Rows.Add();

                    dtgvConsultarProducto.Rows[n].Cells[0].Value = txtNombre.Text;
                    dtgvConsultarProducto.Rows[n].Cells[1].Value = txtID.Text;
                    dtgvConsultarProducto.Rows[n].Cells[2].Value = dptFecha.Text;
                    
                    MatrizProductos[n, 0] = txtNombre.Text;
                    MatrizProductos[n, 1] = txtID.Text;
                    MatrizProductos[n, 2] = dptFecha.Text;
                    
                    txtNombre.Text = "";
                    txtID.Text = "";


                }
                else
                {
                    MessageBox.Show("Falta Completar El Nombre", "Cargar Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar Una Fecha Actual o Posterior a la de Hoy", "cargar tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dptFecha.Value = DateTime.Today;
                dptFecha.Focus();
            }
            

            
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
