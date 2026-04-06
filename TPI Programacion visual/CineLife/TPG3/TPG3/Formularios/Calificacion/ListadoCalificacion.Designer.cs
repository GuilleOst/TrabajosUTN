namespace TPG3.Formularios.Calificacion
{
    partial class ListadoCalificacion
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
            this.grdBuscadorcalificacion = new System.Windows.Forms.DataGridView();
            this.txtBuscadorCalificacion = new System.Windows.Forms.TextBox();
            this.lblListadoCalificacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorcalificacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBuscadorcalificacion
            // 
            this.grdBuscadorcalificacion.AllowUserToAddRows = false;
            this.grdBuscadorcalificacion.AllowUserToDeleteRows = false;
            this.grdBuscadorcalificacion.BackgroundColor = System.Drawing.Color.White;
            this.grdBuscadorcalificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscadorcalificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Abreviatura});
            this.grdBuscadorcalificacion.GridColor = System.Drawing.SystemColors.Control;
            this.grdBuscadorcalificacion.Location = new System.Drawing.Point(171, 177);
            this.grdBuscadorcalificacion.Name = "grdBuscadorcalificacion";
            this.grdBuscadorcalificacion.ReadOnly = true;
            this.grdBuscadorcalificacion.RowTemplate.Height = 25;
            this.grdBuscadorcalificacion.Size = new System.Drawing.Size(533, 211);
            this.grdBuscadorcalificacion.TabIndex = 6;
            // 
            // txtBuscadorCalificacion
            // 
            this.txtBuscadorCalificacion.Location = new System.Drawing.Point(171, 132);
            this.txtBuscadorCalificacion.Name = "txtBuscadorCalificacion";
            this.txtBuscadorCalificacion.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorCalificacion.TabIndex = 5;
            this.txtBuscadorCalificacion.TextChanged += new System.EventHandler(this.txtBuscadorCalificacion_TextChanged);
            // 
            // lblListadoCalificacion
            // 
            this.lblListadoCalificacion.AutoSize = true;
            this.lblListadoCalificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListadoCalificacion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListadoCalificacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListadoCalificacion.Location = new System.Drawing.Point(72, 20);
            this.lblListadoCalificacion.Name = "lblListadoCalificacion";
            this.lblListadoCalificacion.Size = new System.Drawing.Size(245, 28);
            this.lblListadoCalificacion.TabIndex = 4;
            this.lblListadoCalificacion.Text = "Listado de Calificaciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListadoCalificacion);
            this.panel1.Location = new System.Drawing.Point(99, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 378);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Descripción:";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Abreviatura
            // 
            this.Abreviatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abreviatura.DataPropertyName = "abreviatura";
            this.Abreviatura.HeaderText = "Abreviatura";
            this.Abreviatura.Name = "Abreviatura";
            this.Abreviatura.ReadOnly = true;
            // 
            // ListadoCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdBuscadorcalificacion);
            this.Controls.Add(this.txtBuscadorCalificacion);
            this.Controls.Add(this.panel1);
            this.Name = "ListadoCalificacion";
            this.Text = "ListadoCalificacion";
            this.Load += new System.EventHandler(this.ListadoCalificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorcalificacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdBuscadorcalificacion;
        private TextBox txtBuscadorCalificacion;
        private Label lblListadoCalificacion;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Abreviatura;
    }
}