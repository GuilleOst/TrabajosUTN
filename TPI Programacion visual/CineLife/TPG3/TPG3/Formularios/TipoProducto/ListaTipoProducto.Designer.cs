namespace TPG3.Formularios.TipoProducto
{
    partial class ListaTipoProducto
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
            this.txtBuscadorTipoProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdBuscadorTipoProd = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorTipoProd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.txtBuscadorTipoProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grdBuscadorTipoProd);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 402);
            this.panel1.TabIndex = 19;
            // 
            // txtBuscadorTipoProd
            // 
            this.txtBuscadorTipoProd.Location = new System.Drawing.Point(72, 114);
            this.txtBuscadorTipoProd.Name = "txtBuscadorTipoProd";
            this.txtBuscadorTipoProd.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorTipoProd.TabIndex = 18;
            this.txtBuscadorTipoProd.TextChanged += new System.EventHandler(this.txtBuscadorTipoProd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre:";
            // 
            // grdBuscadorTipoProd
            // 
            this.grdBuscadorTipoProd.AllowUserToAddRows = false;
            this.grdBuscadorTipoProd.AllowUserToDeleteRows = false;
            this.grdBuscadorTipoProd.BackgroundColor = System.Drawing.Color.White;
            this.grdBuscadorTipoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscadorTipoProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre});
            this.grdBuscadorTipoProd.GridColor = System.Drawing.SystemColors.Control;
            this.grdBuscadorTipoProd.Location = new System.Drawing.Point(72, 156);
            this.grdBuscadorTipoProd.Name = "grdBuscadorTipoProd";
            this.grdBuscadorTipoProd.ReadOnly = true;
            this.grdBuscadorTipoProd.RowTemplate.Height = 25;
            this.grdBuscadorTipoProd.Size = new System.Drawing.Size(440, 211);
            this.grdBuscadorTipoProd.TabIndex = 14;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombreTipoProd";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(72, 25);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(296, 28);
            this.lblListado.TabIndex = 12;
            this.lblListado.Text = "Listado de Tipos de Productos";
            // 
            // ListaTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.panel1);
            this.Name = "ListaTipoProducto";
            this.Text = "ListaTipoProducto";
            this.Load += new System.EventHandler(this.ListaTipoProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorTipoProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private DataGridView grdBuscadorTipoProd;
        private Label lblListado;
        private TextBox txtBuscadorTipoProd;
        private Label label1;
        private DataGridViewTextBoxColumn nombre;
    }
}