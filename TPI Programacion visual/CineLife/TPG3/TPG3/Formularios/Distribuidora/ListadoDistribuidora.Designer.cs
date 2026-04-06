namespace TPG3.Formularios.Distribuidora
{
    partial class ListadoDistribuidora
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
            this.grdBuscadordistribuidora = new System.Windows.Forms.DataGridView();
            this.txtBuscadorDistribuidora = new System.Windows.Forms.TextBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreDistribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadordistribuidora)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBuscadordistribuidora
            // 
            this.grdBuscadordistribuidora.AllowUserToAddRows = false;
            this.grdBuscadordistribuidora.AllowUserToDeleteRows = false;
            this.grdBuscadordistribuidora.BackgroundColor = System.Drawing.Color.White;
            this.grdBuscadordistribuidora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscadordistribuidora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDistribuidora});
            this.grdBuscadordistribuidora.GridColor = System.Drawing.SystemColors.Control;
            this.grdBuscadordistribuidora.Location = new System.Drawing.Point(171, 177);
            this.grdBuscadordistribuidora.Name = "grdBuscadordistribuidora";
            this.grdBuscadordistribuidora.ReadOnly = true;
            this.grdBuscadordistribuidora.RowTemplate.Height = 25;
            this.grdBuscadordistribuidora.Size = new System.Drawing.Size(440, 211);
            this.grdBuscadordistribuidora.TabIndex = 10;
            // 
            // txtBuscadorDistribuidora
            // 
            this.txtBuscadorDistribuidora.Location = new System.Drawing.Point(171, 132);
            this.txtBuscadorDistribuidora.Name = "txtBuscadorDistribuidora";
            this.txtBuscadorDistribuidora.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorDistribuidora.TabIndex = 9;
            this.txtBuscadorDistribuidora.TextChanged += new System.EventHandler(this.txtBuscadorDistribuidora_TextChanged);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(72, 15);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(249, 28);
            this.lblListado.TabIndex = 8;
            this.lblListado.Text = "Listado de Distribuidoras";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 378);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            // 
            // NombreDistribuidora
            // 
            this.NombreDistribuidora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreDistribuidora.DataPropertyName = "nombreDistribuidora";
            this.NombreDistribuidora.HeaderText = "NombreDistribuidora";
            this.NombreDistribuidora.Name = "NombreDistribuidora";
            this.NombreDistribuidora.ReadOnly = true;
            // 
            // ListadoDistribuidora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdBuscadordistribuidora);
            this.Controls.Add(this.txtBuscadorDistribuidora);
            this.Controls.Add(this.panel1);
            this.Name = "ListadoDistribuidora";
            this.Text = "ListadoDistribuidora";
            this.Load += new System.EventHandler(this.ListadoDistribuidora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadordistribuidora)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdBuscadordistribuidora;
        private TextBox txtBuscadorDistribuidora;
        private Label lblListado;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn NombreDistribuidora;
    }
}