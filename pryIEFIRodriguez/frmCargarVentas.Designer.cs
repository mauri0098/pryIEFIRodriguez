namespace pryIEFIRodriguez
{
    partial class frmCargarVentas
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
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdRegistar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dptFecha = new System.Windows.Forms.DateTimePicker();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.dtgvConsultarVentas = new System.Windows.Forms.DataGridView();
            this.dtgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVentas.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsultarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.tabRegistrar);
            this.tabVentas.Controls.Add(this.tabConsultar);
            this.tabVentas.Location = new System.Drawing.Point(0, 0);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(476, 354);
            this.tabVentas.TabIndex = 0;
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.groupBox1);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(468, 328);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.cmdCancelar);
            this.groupBox1.Controls.Add(this.cmdRegistar);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.dptFecha);
            this.groupBox1.Controls.Add(this.nudID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Location = new System.Drawing.Point(93, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(78, 137);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(89, 20);
            this.nudCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(22, 139);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(130, 240);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(76, 23);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdRegistar
            // 
            this.cmdRegistar.Location = new System.Drawing.Point(24, 240);
            this.cmdRegistar.Name = "cmdRegistar";
            this.cmdRegistar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistar.TabIndex = 1;
            this.cmdRegistar.Text = "Registrar";
            this.cmdRegistar.UseVisualStyleBackColor = true;
            this.cmdRegistar.Click += new System.EventHandler(this.cmdRegistar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 174);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // dptFecha
            // 
            this.dptFecha.Location = new System.Drawing.Point(24, 190);
            this.dptFecha.Name = "dptFecha";
            this.dptFecha.Size = new System.Drawing.Size(194, 20);
            this.dptFecha.TabIndex = 2;
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(78, 86);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(89, 20);
            this.nudID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(32, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(21, 48);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(78, 45);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(89, 20);
            this.txtProducto.TabIndex = 0;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.dtgvConsultarVentas);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(468, 328);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // dtgvConsultarVentas
            // 
            this.dtgvConsultarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsultarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvProducto,
            this.dtgvID,
            this.dtgvCantidad,
            this.dtgvFecha});
            this.dtgvConsultarVentas.Location = new System.Drawing.Point(3, 6);
            this.dtgvConsultarVentas.Name = "dtgvConsultarVentas";
            this.dtgvConsultarVentas.Size = new System.Drawing.Size(457, 215);
            this.dtgvConsultarVentas.TabIndex = 1;
            // 
            // dtgvProducto
            // 
            this.dtgvProducto.HeaderText = "Producto";
            this.dtgvProducto.Name = "dtgvProducto";
            // 
            // dtgvID
            // 
            this.dtgvID.HeaderText = "ID";
            this.dtgvID.Name = "dtgvID";
            // 
            // dtgvCantidad
            // 
            this.dtgvCantidad.HeaderText = "Cantidad";
            this.dtgvCantidad.Name = "dtgvCantidad";
            // 
            // dtgvFecha
            // 
            this.dtgvFecha.HeaderText = "Fecha";
            this.dtgvFecha.Name = "dtgvFecha";
            // 
            // frmCargarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 364);
            this.Controls.Add(this.tabVentas);
            this.Name = "frmCargarVentas";
            this.Text = "Ventas";
            this.tabVentas.ResumeLayout(false);
            this.tabRegistrar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.tabConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsultarVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdRegistar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dptFecha;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dtgvConsultarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvFecha;
    }
}