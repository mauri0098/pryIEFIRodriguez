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
    public partial class frmCargarVentas : Form
    {
        string[,] MatrizVentas
             = new string[4, 4];

        public frmCargarVentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdRegistar_Click(object sender, EventArgs e)
        {
            if (dptFecha.Value >= DateTime.Today)
            {
                if (txtProducto.Text != "")
                {
                    MessageBox.Show("vamos a Registrar");



                    int n = dtgvConsultarVentas.Rows.Add();

                    dtgvConsultarVentas.Rows[n].Cells[0].Value = txtProducto.Text;
                    dtgvConsultarVentas.Rows[n].Cells[1].Value = txtID.Text;
                    dtgvConsultarVentas.Rows[n].Cells[2].Value = nudCantidad.Text;
                    dtgvConsultarVentas.Rows[n].Cells[3].Value = dptFecha.Value.ToString();
                    
                    //Registro de matriz
                    MatrizVentas[n,0] = txtProducto.Text;
                    MatrizVentas[n,1] = txtID.Text;
                    MatrizVentas[n,2] = nudCantidad.Text;
                    MatrizVentas[n, 3] = dptFecha.Value.ToString();

                    txtProducto.Text = "";
                    txtID.Text = "";
                    nudCantidad.Text = "";

                }
                else
                {
                    MessageBox.Show("Falta Completar El Producto", "Cargar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProducto.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar Una Fecha Actual o Posterior a la de Hoy", "cargar tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dptFecha.Value = DateTime.Today;
                dptFecha.Focus();
            }



        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            for (int filas = 0; filas < MatrizVentas.GetLength(0); filas++)
            {
                if (Convert.ToInt32(MatrizVentas[filas, 2])>=10)
                {
                    lstVentasMayores.Items.Add(MatrizVentas[filas, 2]);
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
        }

        private void cmdMostar_Click(object sender, EventArgs e)
        {
            frmListar frmListar = new frmListar("Ventas", MatrizVentas);
            frmListar.ShowDialog();
        }
    }
}
        
    

