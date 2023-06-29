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
            this.lblID = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.dtgvConsultarVentas = new System.Windows.Forms.DataGridView();
            this.dtgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstVentasMayores = new System.Windows.Forms.ComboBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.lblVentasMayoresa10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tabVentas.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
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
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.cmdCancelar);
            this.groupBox1.Controls.Add(this.cmdRegistar);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.dptFecha);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(96, 129);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(89, 23);
            this.nudCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(21, 131);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(134, 240);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(76, 27);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdRegistar
            // 
            this.cmdRegistar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistar.Location = new System.Drawing.Point(24, 240);
            this.cmdRegistar.Name = "cmdRegistar";
            this.cmdRegistar.Size = new System.Drawing.Size(75, 27);
            this.cmdRegistar.TabIndex = 1;
            this.cmdRegistar.Text = "Registrar";
            this.cmdRegistar.UseVisualStyleBackColor = true;
            this.cmdRegistar.Click += new System.EventHandler(this.cmdRegistar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(26, 168);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // dptFecha
            // 
            this.dptFecha.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptFecha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptFecha.Location = new System.Drawing.Point(22, 188);
            this.dptFecha.Name = "dptFecha";
            this.dptFecha.Size = new System.Drawing.Size(188, 23);
            this.dptFecha.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(37, 94);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(21, 52);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(57, 15);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(96, 49);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(89, 23);
            this.txtProducto.TabIndex = 0;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.lblVentasMayoresa10);
            this.tabConsultar.Controls.Add(this.cmdConsultar);
            this.tabConsultar.Controls.Add(this.lstVentasMayores);
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
            this.dtgvConsultarVentas.Location = new System.Drawing.Point(0, 6);
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
            // lstVentasMayores
            // 
            this.lstVentasMayores.FormattingEnabled = true;
            this.lstVentasMayores.Location = new System.Drawing.Point(92, 251);
            this.lstVentasMayores.Name = "lstVentasMayores";
            this.lstVentasMayores.Size = new System.Drawing.Size(121, 21);
            this.lstVentasMayores.TabIndex = 2;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(11, 249);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // lblVentasMayoresa10
            // 
            this.lblVentasMayoresa10.AutoSize = true;
            this.lblVentasMayoresa10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasMayoresa10.Location = new System.Drawing.Point(8, 231);
            this.lblVentasMayoresa10.Name = "lblVentasMayoresa10";
            this.lblVentasMayoresa10.Size = new System.Drawing.Size(130, 15);
            this.lblVentasMayoresa10.TabIndex = 4;
            this.lblVentasMayoresa10.Text = "Ventas Mayores a 10";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 88);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 27);
            this.txtID.TabIndex = 7;
            // 
            // frmCargarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 364);
            this.Controls.Add(this.tabVentas);
            this.Name = "frmCargarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.tabVentas.ResumeLayout(false);
            this.tabRegistrar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
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
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dtgvConsultarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvFecha;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.ComboBox lstVentasMayores;
        private System.Windows.Forms.Label lblVentasMayoresa10;
        private System.Windows.Forms.TextBox txtID;
    }
}