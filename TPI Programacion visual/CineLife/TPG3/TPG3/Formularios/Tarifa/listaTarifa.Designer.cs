namespace TPG3.Formularios.Tarifa
{
    partial class listaTarifa
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
            this.grdTarifa = new System.Windows.Forms.DataGridView();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscadorTarifa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdTarifa
            // 
            this.grdTarifa.AllowUserToAddRows = false;
            this.grdTarifa.AllowUserToDeleteRows = false;
            this.grdTarifa.BackgroundColor = System.Drawing.Color.White;
            this.grdTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripción,
            this.Valor,
            this.descri});
            this.grdTarifa.GridColor = System.Drawing.SystemColors.Control;
            this.grdTarifa.Location = new System.Drawing.Point(171, 177);
            this.grdTarifa.Name = "grdTarifa";
            this.grdTarifa.ReadOnly = true;
            this.grdTarifa.RowTemplate.Height = 25;
            this.grdTarifa.Size = new System.Drawing.Size(440, 211);
            this.grdTarifa.TabIndex = 21;
            // 
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripción.DataPropertyName = "descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // descri
            // 
            this.descri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descri.DataPropertyName = "descri";
            this.descri.HeaderText = "Formato";
            this.descri.Name = "descri";
            this.descri.ReadOnly = true;
            // 
            // txtBuscadorTarifa
            // 
            this.txtBuscadorTarifa.Location = new System.Drawing.Point(171, 132);
            this.txtBuscadorTarifa.Name = "txtBuscadorTarifa";
            this.txtBuscadorTarifa.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorTarifa.TabIndex = 20;
            this.txtBuscadorTarifa.TextChanged += new System.EventHandler(this.txtBuscadororigen_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 378);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Descripción:";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(65, 15);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(178, 28);
            this.lblListado.TabIndex = 16;
            this.lblListado.Text = "Listado de Tarifas";
            // 
            // listaTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdTarifa);
            this.Controls.Add(this.txtBuscadorTarifa);
            this.Controls.Add(this.panel1);
            this.Name = "listaTarifa";
            this.Text = "listaTarifa";
            this.Load += new System.EventHandler(this.listaTarifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdTarifa;
        private TextBox txtBuscadorTarifa;
        private Panel panel1;
        private Label label1;
        private Label lblListado;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn descri;
    }
}