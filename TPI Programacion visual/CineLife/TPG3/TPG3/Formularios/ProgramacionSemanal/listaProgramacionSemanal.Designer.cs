namespace TPG3.Formularios.ProgramacionSemanal
{
    partial class listaProgramacionSemanal
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
            this.grdProgSem = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscadorProg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProgSem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProgSem
            // 
            this.grdProgSem.AllowUserToAddRows = false;
            this.grdProgSem.AllowUserToDeleteRows = false;
            this.grdProgSem.BackgroundColor = System.Drawing.Color.White;
            this.grdProgSem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProgSem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.fechaInicio,
            this.fechaFin});
            this.grdProgSem.GridColor = System.Drawing.SystemColors.Control;
            this.grdProgSem.Location = new System.Drawing.Point(171, 177);
            this.grdProgSem.Name = "grdProgSem";
            this.grdProgSem.ReadOnly = true;
            this.grdProgSem.RowTemplate.Height = 25;
            this.grdProgSem.Size = new System.Drawing.Size(440, 211);
            this.grdProgSem.TabIndex = 27;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numero.DataPropertyName = "nroSemana";
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaInicio.DataPropertyName = "fechaInicio";
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaFin
            // 
            this.fechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaFin.DataPropertyName = "fechaFin";
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            // 
            // txtBuscadorProg
            // 
            this.txtBuscadorProg.Location = new System.Drawing.Point(171, 132);
            this.txtBuscadorProg.Name = "txtBuscadorProg";
            this.txtBuscadorProg.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorProg.TabIndex = 26;
//            this.txtBuscadorProg.TextChanged += new System.EventHandler(this.txtBuscadorSala_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 378);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Semana";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(65, 15);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(373, 28);
            this.lblListado.TabIndex = 16;
            this.lblListado.Text = "Listado de Programaciones Semanales";
            // 
            // listaProgramacionSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProgSem);
            this.Controls.Add(this.txtBuscadorProg);
            this.Controls.Add(this.panel1);
            this.Name = "listaProgramacionSemanal";
            this.Text = "lsitaProgramacionSemanal";
            this.Load += new System.EventHandler(this.lsitaProgramacionSemanal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProgSem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdProgSem;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn fechaInicio;
        private DataGridViewTextBoxColumn fechaFin;
        private TextBox txtBuscadorProg;
        private Panel panel1;
        private Label label1;
        private Label lblListado;
    }
}