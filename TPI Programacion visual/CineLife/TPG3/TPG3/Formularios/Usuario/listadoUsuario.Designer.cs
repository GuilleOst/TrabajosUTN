namespace TPG3.Formularios.Usuario
{
    partial class listadoUsuario
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
            this.panelBackAltaPromocion = new System.Windows.Forms.Panel();
            this.lblListado = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBackAltaPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.lblListado);
            this.panelBackAltaPromocion.Controls.Add(this.dgvUsuarios);
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscar);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(44, 36);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(604, 509);
            this.panelBackAltaPromocion.TabIndex = 27;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(45, 17);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(196, 28);
            this.lblListado.TabIndex = 23;
            this.lblListado.Text = "Listado de Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.dni,
            this.tipoDoc,
            this.fechaAlta});
            this.dgvUsuarios.Location = new System.Drawing.Point(45, 151);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(494, 273);
            this.dgvUsuarios.TabIndex = 22;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombreUsuario";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            // 
            // tipoDoc
            // 
            this.tipoDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoDoc.DataPropertyName = "tipoDoc";
            this.tipoDoc.HeaderText = "Tipo Doc.";
            this.tipoDoc.Name = "tipoDoc";
            // 
            // fechaAlta
            // 
            this.fechaAlta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaAlta.DataPropertyName = "fechaAlta";
            this.fechaAlta.HeaderText = "Fecha Alta";
            this.fechaAlta.Name = "fechaAlta";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(45, 99);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 23);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // listadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Name = "listadoUsuario";
            this.Text = "listadoUsuario";
            this.Load += new System.EventHandler(this.listadoUsuario_Load);
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBackAltaPromocion;
        private Label lblListado;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn tipoDoc;
        private DataGridViewTextBoxColumn fechaAlta;
        private TextBox txtBuscar;
        private Label label1;
    }
}