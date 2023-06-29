namespace pryIEFIRodriguez
{
    partial class frmInicio
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
            this.cmdInicioSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdInicioSesion
            // 
            this.cmdInicioSesion.Location = new System.Drawing.Point(245, 307);
            this.cmdInicioSesion.Name = "cmdInicioSesion";
            this.cmdInicioSesion.Size = new System.Drawing.Size(165, 44);
            this.cmdInicioSesion.TabIndex = 0;
            this.cmdInicioSesion.Text = "Inicio Sesion";
            this.cmdInicioSesion.UseVisualStyleBackColor = true;
            this.cmdInicioSesion.Click += new System.EventHandler(this.cmdInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryIEFIRodriguez.Properties.Resources.zarla_logro_comercial_1x1_2400x2400_20220202_mdp9v7jh6gdfdftqctp9;
            this.pictureBox1.Location = new System.Drawing.Point(593, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdInicioSesion);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInicioSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}