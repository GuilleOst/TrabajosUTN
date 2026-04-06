namespace TPG3.Formularios.Estado
{
    partial class listaEstado
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
            this.grdEstado = new System.Windows.Forms.DataGridView();
            this.txtBuscadorEstado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEstado
            // 
            this.grdEstado.AllowUserToAddRows = false;
            this.grdEstado.AllowUserToDeleteRows = false;
            this.grdEstado.BackgroundColor = System.Drawing.Color.White;
            this.grdEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.descripcion});
            this.grdEstado.GridColor = System.Drawing.SystemColors.Control;
            this.grdEstado.Location = new System.Drawing.Point(171, 177);
            this.grdEstado.Name = "grdEstado";
            this.grdEstado.ReadOnly = true;
            this.grdEstado.RowTemplate.Height = 25;
            this.grdEstado.Size = new System.Drawing.Size(440, 211);
            this.grdEstado.TabIndex = 30;
            // 
            // txtBuscadorEstado
            // 
            this.txtBuscadorEstado.Location = new System.Drawing.Point(171, 132);
            this.txtBuscadorEstado.Name = "txtBuscadorEstado";
            this.txtBuscadorEstado.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorEstado.TabIndex = 29;
            this.txtBuscadorEstado.TextChanged += new System.EventHandler(this.txtBuscadorEstado_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 378);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(65, 15);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(187, 28);
            this.lblListado.TabIndex = 16;
            this.lblListado.Text = "Listado de Estados";
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // listaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdEstado);
            this.Controls.Add(this.txtBuscadorEstado);
            this.Controls.Add(this.panel1);
            this.Name = "listaEstado";
            this.Text = "listaEstado";
            this.Load += new System.EventHandler(this.listaEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEstado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdEstado;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private TextBox txtBuscadorEstado;
        private Panel panel1;
        private Label label1;
        private Label lblListado;
    }
}