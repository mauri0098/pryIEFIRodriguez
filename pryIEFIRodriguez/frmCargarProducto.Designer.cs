namespace pryIEFIRodriguez
{
    partial class frmCargarProducto
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
            this.tabProducto = new System.Windows.Forms.TabControl();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mrcProducto = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.dptFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.dtgvConsultarProducto = new System.Windows.Forms.DataGridView();
            this.dtgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProducto.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.mrcProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsultarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.tabRegistrar);
            this.tabProducto.Controls.Add(this.tabConsultar);
            this.tabProducto.Location = new System.Drawing.Point(0, 0);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.SelectedIndex = 0;
            this.tabProducto.Size = new System.Drawing.Size(366, 298);
            this.tabProducto.TabIndex = 0;
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.mrcProducto);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(358, 272);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.dtgvConsultarProducto);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(358, 272);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(89, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mrcProducto
            // 
            this.mrcProducto.Controls.Add(this.cmdCancelar);
            this.mrcProducto.Controls.Add(this.cmdRegistrar);
            this.mrcProducto.Controls.Add(this.lblFecha);
            this.mrcProducto.Controls.Add(this.dptFecha);
            this.mrcProducto.Controls.Add(this.nudID);
            this.mrcProducto.Controls.Add(this.lblID);
            this.mrcProducto.Controls.Add(this.lblNombre);
            this.mrcProducto.Controls.Add(this.txtNombre);
            this.mrcProducto.Location = new System.Drawing.Point(45, 17);
            this.mrcProducto.Name = "mrcProducto";
            this.mrcProducto.Size = new System.Drawing.Size(247, 234);
            this.mrcProducto.TabIndex = 1;
            this.mrcProducto.TabStop = false;
            this.mrcProducto.Text = "Producto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(31, 86);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(72, 84);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(89, 20);
            this.nudID.TabIndex = 2;
            // 
            // dptFecha
            // 
            this.dptFecha.Location = new System.Drawing.Point(25, 150);
            this.dptFecha.Name = "dptFecha";
            this.dptFecha.Size = new System.Drawing.Size(194, 20);
            this.dptFecha.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 134);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(25, 195);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 1;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(119, 195);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(76, 23);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // dtgvConsultarProducto
            // 
            this.dtgvConsultarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsultarProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvNombre,
            this.dtgvID,
            this.dtgvFecha});
            this.dtgvConsultarProducto.Location = new System.Drawing.Point(3, 3);
            this.dtgvConsultarProducto.Name = "dtgvConsultarProducto";
            this.dtgvConsultarProducto.Size = new System.Drawing.Size(349, 215);
            this.dtgvConsultarProducto.TabIndex = 0;
            // 
            // dtgvNombre
            // 
            this.dtgvNombre.HeaderText = "Nombre";
            this.dtgvNombre.Name = "dtgvNombre";
            // 
            // dtgvID
            // 
            this.dtgvID.HeaderText = "ID";
            this.dtgvID.Name = "dtgvID";
            // 
            // dtgvFecha
            // 
            this.dtgvFecha.HeaderText = "Fecha";
            this.dtgvFecha.Name = "dtgvFecha";
            // 
            // frmCargarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 312);
            this.Controls.Add(this.tabProducto);
            this.Name = "frmCargarProducto";
            this.Text = "Producto";
            this.tabProducto.ResumeLayout(false);
            this.tabRegistrar.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            this.mrcProducto.ResumeLayout(false);
            this.mrcProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsultarProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProducto;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.GroupBox mrcProducto;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dptFecha;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgvConsultarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvFecha;
    }
}