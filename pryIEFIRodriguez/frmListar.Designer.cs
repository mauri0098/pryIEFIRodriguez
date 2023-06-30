namespace pryIEFIRodriguez
{
    partial class frmListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListar));
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.BackColor = System.Drawing.SystemColors.Info;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(1, 8);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(268, 316);
            this.lstProductos.TabIndex = 0;
            // 
            // lstVentas
            // 
            this.lstVentas.BackColor = System.Drawing.SystemColors.Info;
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.Location = new System.Drawing.Point(275, 8);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(276, 316);
            this.lstVentas.TabIndex = 1;
            this.lstVentas.SelectedIndexChanged += new System.EventHandler(this.lstVentas_SelectedIndexChanged);
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(570, 336);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.lstProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListar";
            this.Text = "frmListar";
            this.Load += new System.EventHandler(this.frmListar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.ListBox lstVentas;
    }
}