namespace TPG3.Formularios.Cliente
{
    partial class ListadoCliente
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
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboBuscarTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.ckbClientes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarCliente.Location = new System.Drawing.Point(651, 56);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(145, 39);
            this.btnEliminarCliente.TabIndex = 31;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarCliente.Location = new System.Drawing.Point(201, 56);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(143, 39);
            this.btnEditarCliente.TabIndex = 30;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCargarCliente.FlatAppearance.BorderSize = 0;
            this.btnCargarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarCliente.Location = new System.Drawing.Point(28, 56);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(143, 39);
            this.btnCargarCliente.TabIndex = 29;
            this.btnCargarCliente.Text = "Cargar Cliente";
            this.btnCargarCliente.UseVisualStyleBackColor = false;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "DNI:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(549, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 30);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Lista de Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(264, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo Doc:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDocumento,
            this.TipoDoc,
            this.dni,
            this.nombre,
            this.apellido,
            this.fechaNacimiento,
            this.email,
            this.telefono});
            this.dgvClientes.Location = new System.Drawing.Point(23, 128);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(697, 231);
            this.dgvClientes.TabIndex = 33;
            this.dgvClientes.Visible = false;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tipoDocumento.DataPropertyName = "tipoDocumento";
            this.tipoDocumento.HeaderText = "Tipo Documento";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Visible = false;
            // 
            // TipoDoc
            // 
            this.TipoDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoDoc.DataPropertyName = "tipoDoc";
            this.TipoDoc.HeaderText = "Tipo Doc.";
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboBuscarTipoDoc);
            this.panel1.Controls.Add(this.txtBuscarDni);
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(28, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 410);
            this.panel1.TabIndex = 32;
            // 
            // cboBuscarTipoDoc
            // 
            this.cboBuscarTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarTipoDoc.FormattingEnabled = true;
            this.cboBuscarTipoDoc.Items.AddRange(new object[] {
            ""});
            this.cboBuscarTipoDoc.Location = new System.Drawing.Point(264, 73);
            this.cboBuscarTipoDoc.Name = "cboBuscarTipoDoc";
            this.cboBuscarTipoDoc.Size = new System.Drawing.Size(232, 23);
            this.cboBuscarTipoDoc.TabIndex = 35;
            this.cboBuscarTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cboBuscarTipoDoc_SelectedIndexChanged);
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Location = new System.Drawing.Point(23, 73);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(180, 23);
            this.txtBuscarDni.TabIndex = 34;
            this.txtBuscarDni.TextChanged += new System.EventHandler(this.txtBuscarDniTextChanged);
            // 
            // ckbClientes
            // 
            this.ckbClientes.AutoSize = true;
            this.ckbClientes.ForeColor = System.Drawing.Color.White;
            this.ckbClientes.Location = new System.Drawing.Point(413, 76);
            this.ckbClientes.Name = "ckbClientes";
            this.ckbClientes.Size = new System.Drawing.Size(161, 19);
            this.ckbClientes.TabIndex = 33;
            this.ckbClientes.Text = "Mostrar todos los clientes";
            this.ckbClientes.UseVisualStyleBackColor = true;
            this.ckbClientes.CheckedChanged += new System.EventHandler(this.ckbClientes_CheckedChanged);
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(864, 591);
            this.Controls.Add(this.ckbClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnCargarCliente);
            this.Name = "ListadoCliente";
            this.Text = "ListadoCliente";
            this.Load += new System.EventHandler(this.ListadoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEliminarCliente;
        private Button btnEditarCliente;
        private Button btnCargarCliente;
        private Label label4;
        private Label lblTitulo;
        private Label label3;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn tipoDocumento;
        private DataGridViewTextBoxColumn TipoDoc;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn telefono;
        private Panel panel1;
        private ComboBox cboBuscarTipoDoc;
        private TextBox txtBuscarDni;
        private CheckBox ckbClientes;
    }
}