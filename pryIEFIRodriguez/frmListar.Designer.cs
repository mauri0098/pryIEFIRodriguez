﻿namespace pryIEFIRodriguez
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
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(0, 2);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(324, 381);
            this.lstProductos.TabIndex = 0;
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstProductos);
            this.Name = "frmListar";
            this.Text = "frmListar";
            this.Load += new System.EventHandler(this.frmListar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
    }
}