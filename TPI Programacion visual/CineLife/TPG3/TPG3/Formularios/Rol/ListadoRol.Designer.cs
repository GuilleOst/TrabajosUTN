namespace TPG3.Formularios.Rol
{
    partial class ListadoRol
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
            this.grdBuscadorrol = new System.Windows.Forms.DataGridView();
            this.txtBuscadorRoles = new System.Windows.Forms.TextBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorrol)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBuscadorrol
            // 
            this.grdBuscadorrol.AllowUserToAddRows = false;
            this.grdBuscadorrol.AllowUserToDeleteRows = false;
            this.grdBuscadorrol.BackgroundColor = System.Drawing.Color.White;
            this.grdBuscadorrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscadorrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreRol});
            this.grdBuscadorrol.GridColor = System.Drawing.SystemColors.Control;
            this.grdBuscadorrol.Location = new System.Drawing.Point(72, 146);
            this.grdBuscadorrol.Name = "grdBuscadorrol";
            this.grdBuscadorrol.ReadOnly = true;
            this.grdBuscadorrol.RowTemplate.Height = 25;
            this.grdBuscadorrol.Size = new System.Drawing.Size(440, 211);
            this.grdBuscadorrol.TabIndex = 14;
            // 
            // txtBuscadorRoles
            // 
            this.txtBuscadorRoles.Location = new System.Drawing.Point(171, 132);
            this.txtBuscadorRoles.Name = "txtBuscadorRoles";
            this.txtBuscadorRoles.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorRoles.TabIndex = 13;
            this.txtBuscadorRoles.TextChanged += new System.EventHandler(this.txtBuscadorRoles_TextChanged);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListado.Location = new System.Drawing.Point(72, 22);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(166, 28);
            this.lblListado.TabIndex = 12;
            this.lblListado.Text = "Listado de Roles";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.grdBuscadorrol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblListado);
            this.panel1.Location = new System.Drawing.Point(99, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 386);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // NombreRol
            // 
            this.NombreRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreRol.DataPropertyName = "nombreRol";
            this.NombreRol.HeaderText = "NombreRol";
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.ReadOnly = true;
            // 
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscadorRoles);
            this.Controls.Add(this.panel1);
            this.Name = "ListadoRol";
            this.Text = "ListadoRol";
            this.Load += new System.EventHandler(this.ListadoRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorrol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdBuscadorrol;
        private TextBox txtBuscadorRoles;
        private Label lblListado;
        private Panel panel1;
        private Label label2;
        private DataGridViewTextBoxColumn NombreRol;
    }
}