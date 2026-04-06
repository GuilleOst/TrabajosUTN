namespace TPG3.Formularios.Formato
{
    partial class listaFormato
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
            this.txtBuscadorFormatos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdBuscadorFormato = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorFormato)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscadorFormatos
            // 
            this.txtBuscadorFormatos.Location = new System.Drawing.Point(171, 136);
            this.txtBuscadorFormatos.Name = "txtBuscadorFormatos";
            this.txtBuscadorFormatos.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorFormatos.TabIndex = 16;
            this.txtBuscadorFormatos.TextChanged += new System.EventHandler(this.txtBuscadorFormatos_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.grdBuscadorFormato);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 386);
            this.panel1.TabIndex = 17;
            // 
            // grdBuscadorFormato
            // 
            this.grdBuscadorFormato.AllowUserToAddRows = false;
            this.grdBuscadorFormato.AllowUserToDeleteRows = false;
            this.grdBuscadorFormato.BackgroundColor = System.Drawing.Color.White;
            this.grdBuscadorFormato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscadorFormato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion});
            this.grdBuscadorFormato.GridColor = System.Drawing.SystemColors.Control;
            this.grdBuscadorFormato.Location = new System.Drawing.Point(72, 146);
            this.grdBuscadorFormato.Name = "grdBuscadorFormato";
            this.grdBuscadorFormato.ReadOnly = true;
            this.grdBuscadorFormato.RowTemplate.Height = 25;
            this.grdBuscadorFormato.Size = new System.Drawing.Size(440, 211);
            this.grdBuscadorFormato.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descripción:";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(72, 22);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(203, 28);
            this.lblListado.TabIndex = 12;
            this.lblListado.Text = "Listado de Formatos";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // listaFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscadorFormatos);
            this.Controls.Add(this.panel1);
            this.Name = "listaFormato";
            this.Text = "listaFormato";
            this.Load += new System.EventHandler(this.listaFormato_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorFormato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBuscadorFormatos;
        private Panel panel1;
        private DataGridView grdBuscadorFormato;
        private Label label2;
        private Label lblListado;
        private DataGridViewTextBoxColumn Descripcion;
    }
}