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
    public partial class frmProducto : Form
    {
        public frmProducto()
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
                    MessageBox.Show("vamos a grabar");

                    
                    
                    int n = dtgvConsultarProducto.Rows.Add();

                    dtgvConsultarProducto.Rows[n].Cells[0].Value = txtNombre.Text;
                    dtgvConsultarProducto.Rows[n].Cells[1].Value = nudID.Text;
                    dtgvConsultarProducto.Rows[n].Cells[2].Value = dptFecha.Text;









                }
                else
                {
                    MessageBox.Show("falta completar el Nombre", "Cargar Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("seleccionar una fecha actual o posterior a la de hoy", "cargar tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dptFecha.Value = DateTime.Today;
                dptFecha.Focus();
            }
            

            
        }
    }
}
