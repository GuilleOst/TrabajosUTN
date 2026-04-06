namespace TPG3.Formularios.TipoDocumento
{
    partial class ListadoTipoDocumento
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
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBackAltaPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.Color.Black;
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.lblListado);
            this.panelBackAltaPromocion.Controls.Add(this.dgvPromocion);
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscar);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(33, 55);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(409, 509);
            this.panelBackAltaPromocion.TabIndex = 26;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(45, 17);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(320, 28);
            this.lblListado.TabIndex = 23;
            this.lblListado.Text = "Listado de Tipos de Documentos";
            // 
            // dgvPromocion
            // 
            this.dgvPromocion.AllowUserToAddRows = false;
            this.dgvPromocion.BackgroundColor = System.Drawing.Color.White;
            this.dgvPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvPromocion.Location = new System.Drawing.Point(45, 151);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowTemplate.Height = 25;
            this.dgvPromocion.Size = new System.Drawing.Size(292, 273);
            this.dgvPromocion.TabIndex = 22;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
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
            // ListadoTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 719);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Name = "ListadoTipoDocumento";
            this.Text = "ListadoTipoDocumento";
            this.Load += new System.EventHandler(this.ListadoTipoDocumento_Load);
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBackAltaPromocion;
        private TextBox txtBuscar;
        private Label label1;
        private DataGridView dgvPromocion;
        private Label lblListado;
        private DataGridViewTextBoxColumn Nombre;
    }
}