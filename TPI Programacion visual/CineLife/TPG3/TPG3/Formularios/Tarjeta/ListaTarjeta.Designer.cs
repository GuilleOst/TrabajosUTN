namespace TPG3.Formularios.Tarjeta
{
    partial class ListaTarjeta
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
            this.lblAltaTarjeta = new System.Windows.Forms.Label();
            this.btnRegistrarTarjeta = new System.Windows.Forms.Button();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscadorTarjeta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltaTarjeta
            // 
            this.lblAltaTarjeta.AutoSize = true;
            this.lblAltaTarjeta.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltaTarjeta.ForeColor = System.Drawing.Color.White;
            this.lblAltaTarjeta.Location = new System.Drawing.Point(479, 31);
            this.lblAltaTarjeta.Name = "lblAltaTarjeta";
            this.lblAltaTarjeta.Size = new System.Drawing.Size(199, 28);
            this.lblAltaTarjeta.TabIndex = 0;
            this.lblAltaTarjeta.Text = "Listado de Tarjetas";
            // 
            // btnRegistrarTarjeta
            // 
            this.btnRegistrarTarjeta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarTarjeta.Location = new System.Drawing.Point(23, 48);
            this.btnRegistrarTarjeta.Name = "btnRegistrarTarjeta";
            this.btnRegistrarTarjeta.Size = new System.Drawing.Size(186, 39);
            this.btnRegistrarTarjeta.TabIndex = 10;
            this.btnRegistrarTarjeta.Text = "Registrar Tarjeta";
            this.btnRegistrarTarjeta.UseVisualStyleBackColor = false;
            this.btnRegistrarTarjeta.Click += new System.EventHandler(this.btnRegistrarTarjeta_Click);
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Banco});
            this.dgvTarjetas.Location = new System.Drawing.Point(19, 172);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.RowTemplate.Height = 25;
            this.dgvTarjetas.Size = new System.Drawing.Size(659, 321);
            this.dgvTarjetas.TabIndex = 12;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Banco
            // 
            this.Banco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Banco.DataPropertyName = "NombreBanco";
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(549, 48);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(191, 39);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar Tarjeta";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(237, 48);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(192, 39);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar Tarjeta";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscadorTarjeta);
            this.panel1.Controls.Add(this.dgvTarjetas);
            this.panel1.Controls.Add(this.lblAltaTarjeta);
            this.panel1.Location = new System.Drawing.Point(23, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 529);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            // 
            // txtBuscadorTarjeta
            // 
            this.txtBuscadorTarjeta.Location = new System.Drawing.Point(19, 118);
            this.txtBuscadorTarjeta.Name = "txtBuscadorTarjeta";
            this.txtBuscadorTarjeta.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorTarjeta.TabIndex = 19;
            this.txtBuscadorTarjeta.TextChanged += new System.EventHandler(this.txtBuscadorTarjeta_TextChanged);
            // 
            // ListaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(823, 710);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrarTarjeta);
            this.Controls.Add(this.panel1);
            this.Name = "ListaTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de nueva tarjeta";
            this.Load += new System.EventHandler(this.ListaTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAltaTarjeta;
        private Button btnRegistrarTarjeta;
        private DataGridView dgvTarjetas;
        private Button btnEliminar;
        private Button btnModificar;
        private Panel panel1;
        private Label label1;
        private TextBox txtBuscadorTarjeta;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Banco;
    }
}