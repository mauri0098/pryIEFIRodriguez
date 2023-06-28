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
            this.cmdInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdInicio
            // 
            this.cmdInicio.Location = new System.Drawing.Point(260, 225);
            this.cmdInicio.Name = "cmdInicio";
            this.cmdInicio.Size = new System.Drawing.Size(165, 44);
            this.cmdInicio.TabIndex = 0;
            this.cmdInicio.Text = "Inicio";
            this.cmdInicio.UseVisualStyleBackColor = true;
            this.cmdInicio.Click += new System.EventHandler(this.cmdInicio_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdInicio);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInicio;
    }
}