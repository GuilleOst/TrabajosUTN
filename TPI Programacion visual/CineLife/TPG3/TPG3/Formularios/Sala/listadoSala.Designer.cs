namespace TPG3.Formularios.Sala
{
    partial class listadoSala
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
            this.grdSala = new System.Windows.Forms.DataGridView();
            this.txtBuscadorSala = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.es3d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSala)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSala
            // 
            this.grdSala.AllowUserToAddRows = false;
            this.grdSala.AllowUserToDeleteRows = false;
            this.grdSala.BackgroundColor = System.Drawing.Color.White;
            this.grdSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.capacidad,
            this.es3d});
            this.grdSala.GridColor = System.Drawing.SystemColors.Control;
            this.grdSala.Location = new System.Drawing.Point(171, 177);
            this.grdSala.Name = "grdSala";
            this.grdSala.ReadOnly = true;
            this.grdSala.RowTemplate.Height = 25;
            this.grdSala.Size = new System.Drawing.Size(440, 211);
            this.grdSala.TabIndex = 24;
            // 
            // txtBuscadorSala
            // 
            this.txtBuscadorSala.Location = new System.Drawing.Point(171, 132);
            this.txtBuscadorSala.Name = "txtBuscadorSala";
            this.txtBuscadorSala.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorSala.TabIndex = 23;
            this.txtBuscadorSala.TextChanged += new System.EventHandler(this.txtBuscadorSala_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 378);
            this.panel1.TabIndex = 25;
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
            this.label1.Text = "Número";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(65, 15);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(163, 28);
            this.lblListado.TabIndex = 16;
            this.lblListado.Text = "Listado de Salas";
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // capacidad
            // 
            this.capacidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capacidad.DataPropertyName = "capacidadButacas";
            this.capacidad.HeaderText = "Capacidad";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
            // 
            // es3d
            // 
            this.es3d.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.es3d.DataPropertyName = "es3d";
            this.es3d.HeaderText = "Es 3D";
            this.es3d.Name = "es3d";
            this.es3d.ReadOnly = true;
            // 
            // listadoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdSala);
            this.Controls.Add(this.txtBuscadorSala);
            this.Controls.Add(this.panel1);
            this.Name = "listadoSala";
            this.Text = "listadoSala";
            this.Load += new System.EventHandler(this.listadoSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSala)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdSala;
        private TextBox txtBuscadorSala;
        private Panel panel1;
        private Label label1;
        private Label lblListado;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn capacidad;
        private DataGridViewTextBoxColumn es3d;
    }
}