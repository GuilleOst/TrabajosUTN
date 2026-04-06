namespace TPG3.Formularios.Producto
{
    partial class AltaProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.txtDescripcion1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.cmbTipoProducto1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRegistroProd = new System.Windows.Forms.Label();
            this.lblActualizarProducto = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdrActualizarProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarProd)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLimpiarCampos);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtPrecio1);
            this.panel1.Controls.Add(this.txtDescripcion1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Controls.Add(this.lblNombreProducto);
            this.panel1.Controls.Add(this.cmbTipoProducto1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(53, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 233);
            this.panel1.TabIndex = 16;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(287, 183);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(150, 28);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Location = new System.Drawing.Point(475, 183);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 28);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(587, 183);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(569, 62);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(111, 23);
            this.txtPrecio1.TabIndex = 2;
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Location = new System.Drawing.Point(152, 107);
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.Size = new System.Drawing.Size(528, 48);
            this.txtDescripcion1.TabIndex = 3;
            this.txtDescripcion1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(569, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(306, 62);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(225, 23);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProducto.ForeColor = System.Drawing.Color.White;
            this.lblNombreProducto.Location = new System.Drawing.Point(306, 31);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(131, 19);
            this.lblNombreProducto.TabIndex = 10;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // cmbTipoProducto1
            // 
            this.cmbTipoProducto1.FormattingEnabled = true;
            this.cmbTipoProducto1.Location = new System.Drawing.Point(49, 62);
            this.cmbTipoProducto1.Name = "cmbTipoProducto1";
            this.cmbTipoProducto1.Size = new System.Drawing.Size(225, 23);
            this.cmbTipoProducto1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Producto";
            // 
            // lblRegistroProd
            // 
            this.lblRegistroProd.AutoSize = true;
            this.lblRegistroProd.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroProd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistroProd.ForeColor = System.Drawing.Color.White;
            this.lblRegistroProd.Location = new System.Drawing.Point(53, 26);
            this.lblRegistroProd.Name = "lblRegistroProd";
            this.lblRegistroProd.Size = new System.Drawing.Size(107, 28);
            this.lblRegistroProd.TabIndex = 13;
            this.lblRegistroProd.Text = "Productos";
            // 
            // lblActualizarProducto
            // 
            this.lblActualizarProducto.AutoSize = true;
            this.lblActualizarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblActualizarProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActualizarProducto.ForeColor = System.Drawing.Color.White;
            this.lblActualizarProducto.Location = new System.Drawing.Point(561, 295);
            this.lblActualizarProducto.Name = "lblActualizarProducto";
            this.lblActualizarProducto.Size = new System.Drawing.Size(200, 28);
            this.lblActualizarProducto.TabIndex = 15;
            this.lblActualizarProducto.Text = "Actualizar Producto";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Tipo_Producto
            // 
            this.Tipo_Producto.DataPropertyName = "tipoProducto";
            this.Tipo_Producto.HeaderText = "Tipo Producto";
            this.Tipo_Producto.Name = "Tipo_Producto";
            // 
            // gdrActualizarProd
            // 
            this.gdrActualizarProd.AllowUserToAddRows = false;
            this.gdrActualizarProd.AllowUserToDeleteRows = false;
            this.gdrActualizarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrActualizarProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdProducto,
            this.Descripcion,
            this.TipoProducto,
            this.Precio});
            this.gdrActualizarProd.Location = new System.Drawing.Point(30, 336);
            this.gdrActualizarProd.Name = "gdrActualizarProd";
            this.gdrActualizarProd.ReadOnly = true;
            this.gdrActualizarProd.RowTemplate.Height = 25;
            this.gdrActualizarProd.Size = new System.Drawing.Size(731, 175);
            this.gdrActualizarProd.TabIndex = 11;
            this.gdrActualizarProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrActualizarProd_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "idProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // TipoProducto
            // 
            this.TipoProducto.DataPropertyName = "nombreTipoProd";
            this.TipoProducto.HeaderText = "TipoProducto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            this.TipoProducto.Width = 200;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 133;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(53, 76);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(43, 19);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.gdrActualizarProd);
            this.panel2.Controls.Add(this.lblActualizarProducto);
            this.panel2.Location = new System.Drawing.Point(23, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 573);
            this.panel2.TabIndex = 17;
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(917, 720);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRegistroProd);
            this.Controls.Add(this.panel2);
            this.Name = "AltaProducto";
            this.Text = "AltaProducto";
            this.Load += new System.EventHandler(this.AltaProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarProd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblRegistroProd;
        private Label lblActualizarProducto;
        private Panel panel1;
        private TextBox txtPrecio1;
        private RichTextBox txtDescripcion1;
        private Label label1;
        private Label label2;
        private TextBox txtNombreProducto;
        private Label lblNombreProducto;
        private ComboBox cmbTipoProducto1;
        private Label label4;
        private Button btnLimpiarCampos;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn Tipo_Producto;
        private DataGridView gdrActualizarProd;
        private Label lblError;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn Precio;
        private Panel panel2;
    }
}