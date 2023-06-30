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
    public partial class frmLogin : Form
    {
        //Declaracion de variables Globales
        string Vusuario;
        string Vcontraseña;
        int VcontadorLogin = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdAcetar_Click(object sender, EventArgs e)
        {
            //Datos para las variables
            Vusuario = txtUsuario.Text;
            Vcontraseña = txtContraseña.Text;
            if (Vusuario == "Mauri" && Vcontraseña == "1234")
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
                this.Hide();

            }
            else if ((Vusuario == "Luli" && Vcontraseña == "1995"))
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
                this.Hide();
            }
            else if ((Vusuario == "Jose" && Vcontraseña == "1999"))
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
                this.Hide();
            }
            else if ((Vusuario == "Laura" && Vcontraseña == "1976"))
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
                this.Hide();
            }

            else
            {
                VcontadorLogin++;
                if (VcontadorLogin == 3)
                {
                    MessageBox.Show("Demasiados Intentos ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else
                {
                    MessageBox.Show("Dato incorrecto. intento:" + VcontadorLogin.ToString() + " de 3 ", "Login . Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            this.Hide();
            frmInicio.ShowDialog();
        }
    }
}
