namespace TPG3.Formularios.Origen
{
    partial class ListadoOrigen
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
            this.grdBuscadororigen = new System.Windows.Forms.DataGridView();
            this.txtBuscadororigen = new System.Windows.Forms.TextBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadororigen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBuscadororigen
            // 
            this.grdBuscadororigen.AllowUserToAddRows = false;
            this.grdBuscadororigen.AllowUserToDeleteRows = false;
            this.grdBuscadororigen.BackgroundColor = System.Drawing.Color.White;
            this.grdBuscadororigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscadororigen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.grdBuscadororigen.GridColor = System.Drawing.SystemColors.Control;
            this.grdBuscadororigen.Location = new System.Drawing.Point(171, 177);
            this.grdBuscadororigen.Name = "grdBuscadororigen";
            this.grdBuscadororigen.ReadOnly = true;
            this.grdBuscadororigen.RowTemplate.Height = 25;
            this.grdBuscadororigen.Size = new System.Drawing.Size(440, 211);
            this.grdBuscadororigen.TabIndex = 18;
            // 
            // txtBuscadororigen
            // 
            this.txtBuscadororigen.Location = new System.Drawing.Point(171, 132);
            this.txtBuscadororigen.Name = "txtBuscadororigen";
            this.txtBuscadororigen.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadororigen.TabIndex = 17;
            this.txtBuscadororigen.TextChanged += new System.EventHandler(this.txtBuscadororigen_TextChanged);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(65, 15);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(199, 28);
            this.lblListado.TabIndex = 16;
            this.lblListado.Text = "Listado de Origenes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 378);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ListadoOrigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdBuscadororigen);
            this.Controls.Add(this.txtBuscadororigen);
            this.Controls.Add(this.panel1);
            this.Name = "ListadoOrigen";
            this.Text = "ListadoOrigen";
            this.Load += new System.EventHandler(this.ListadoOrigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadororigen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdBuscadororigen;
        private TextBox txtBuscadororigen;
        private Label lblListado;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Nombre;
    }
}