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
            this.mrcProducto = new System.Windows.Forms.GroupBox();
            this.cmdMostar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dptFecha = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.dtgvConsultarProducto = new System.Windows.Forms.DataGridView();
            this.dtgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProducto.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.mrcProducto.SuspendLayout();
            this.tabConsultar.SuspendLayout();
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
            this.tabProducto.Size = new System.Drawing.Size(400, 298);
            this.tabProducto.TabIndex = 0;
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.mrcProducto);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(392, 272);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // mrcProducto
            // 
            this.mrcProducto.Controls.Add(this.cmdMostar);
            this.mrcProducto.Controls.Add(this.txtID);
            this.mrcProducto.Controls.Add(this.cmdCancelar);
            this.mrcProducto.Controls.Add(this.cmdRegistrar);
            this.mrcProducto.Controls.Add(this.lblFecha);
            this.mrcProducto.Controls.Add(this.dptFecha);
            this.mrcProducto.Controls.Add(this.lblID);
            this.mrcProducto.Controls.Add(this.lblNombre);
            this.mrcProducto.Controls.Add(this.txtNombre);
            this.mrcProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcProducto.Location = new System.Drawing.Point(48, 15);
            this.mrcProducto.Name = "mrcProducto";
            this.mrcProducto.Size = new System.Drawing.Size(244, 251);
            this.mrcProducto.TabIndex = 1;
            this.mrcProducto.TabStop = false;
            this.mrcProducto.Text = "Producto";
            // 
            // cmdMostar
            // 
            this.cmdMostar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMostar.Location = new System.Drawing.Point(85, 206);
            this.cmdMostar.Name = "cmdMostar";
            this.cmdMostar.Size = new System.Drawing.Size(71, 27);
            this.cmdMostar.TabIndex = 6;
            this.cmdMostar.Text = "Mostar";
            this.cmdMostar.UseVisualStyleBackColor = true;
            this.cmdMostar.Click += new System.EventHandler(this.cmdMostar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(86, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 27);
            this.txtID.TabIndex = 5;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(162, 206);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(76, 27);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.Location = new System.Drawing.Point(6, 206);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 27);
            this.cmdRegistrar.TabIndex = 1;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(22, 136);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // dptFecha
            // 
            this.dptFecha.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptFecha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptFecha.Location = new System.Drawing.Point(6, 154);
            this.dptFecha.Name = "dptFecha";
            this.dptFecha.Size = new System.Drawing.Size(219, 22);
            this.dptFecha.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(42, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(86, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(89, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.dtgvConsultarProducto);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(392, 272);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = true;
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
            this.dtgvConsultarProducto.Size = new System.Drawing.Size(379, 215);
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
            this.ClientSize = new System.Drawing.Size(398, 366);
            this.Controls.Add(this.tabProducto);
            this.Name = "frmCargarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.tabProducto.ResumeLayout(false);
            this.tabRegistrar.ResumeLayout(false);
            this.mrcProducto.ResumeLayout(false);
            this.mrcProducto.PerformLayout();
            this.tabConsultar.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgvConsultarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvFecha;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button cmdMostar;
    }
}