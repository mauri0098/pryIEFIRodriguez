﻿using System;
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
                    MessageBox.Show("vamos a Consultar");



                    int n = dtgvConsultarVentas.Rows.Add();

                    dtgvConsultarVentas.Rows[n].Cells[0].Value = txtProducto.Text;
                    dtgvConsultarVentas.Rows[n].Cells[1].Value = nudID.Text;
                    dtgvConsultarVentas.Rows[n].Cells[2].Value = nudCantidad.Text;
                    dtgvConsultarVentas.Rows[n].Cells[3].Value = dptFecha.Text;

                    txtProducto.Text = "";
                    nudID.Text = "";
                    nudCantidad.Text = "";

                }
                else
                {
                    MessageBox.Show("Falta Completar El Nombre", "Cargar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
        
    

