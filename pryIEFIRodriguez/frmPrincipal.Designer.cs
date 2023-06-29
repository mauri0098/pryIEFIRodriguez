namespace pryIEFIRodriguez
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdVentas = new System.Windows.Forms.Button();
            this.cmdProducto = new System.Windows.Forms.Button();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdVentas
            // 
            this.cmdVentas.Location = new System.Drawing.Point(75, 133);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(111, 59);
            this.cmdVentas.TabIndex = 0;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = true;
            this.cmdVentas.Click += new System.EventHandler(this.cmdVentas_Click);
            // 
            // cmdProducto
            // 
            this.cmdProducto.Location = new System.Drawing.Point(213, 133);
            this.cmdProducto.Name = "cmdProducto";
            this.cmdProducto.Size = new System.Drawing.Size(100, 59);
            this.cmdProducto.TabIndex = 1;
            this.cmdProducto.Text = "Producto";
            this.cmdProducto.UseVisualStyleBackColor = true;
            this.cmdProducto.Click += new System.EventHandler(this.cmdProducto_Click);
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Location = new System.Drawing.Point(91, 48);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(49, 13);
            this.lblRegistrar.TabIndex = 2;
            this.lblRegistrar.Text = "Registrar";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 293);
            this.Controls.Add(this.lblRegistrar);
            this.Controls.Add(this.cmdProducto);
            this.Controls.Add(this.cmdVentas);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Button cmdProducto;
        private System.Windows.Forms.Label lblRegistrar;
    }
}