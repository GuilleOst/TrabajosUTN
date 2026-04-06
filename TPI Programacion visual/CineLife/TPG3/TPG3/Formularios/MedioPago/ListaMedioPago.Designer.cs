namespace TPG3.Formularios.MedioPago
{
    partial class ListaMedioPago
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvMedioPago = new System.Windows.Forms.DataGridView();
            this.btnCargarMP = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPago)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(330, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 30);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Lista de Medios de Pago";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dgvMedioPago
            // 
            this.dgvMedioPago.AllowUserToAddRows = false;
            this.dgvMedioPago.AllowUserToDeleteRows = false;
            this.dgvMedioPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedioPago.Location = new System.Drawing.Point(61, 206);
            this.dgvMedioPago.Name = "dgvMedioPago";
            this.dgvMedioPago.RowTemplate.Height = 25;
            this.dgvMedioPago.Size = new System.Drawing.Size(547, 150);
            this.dgvMedioPago.TabIndex = 14;
            // 
            // btnCargarMP
            // 
            this.btnCargarMP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarMP.FlatAppearance.BorderSize = 0;
            this.btnCargarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarMP.ForeColor = System.Drawing.Color.White;
            this.btnCargarMP.Location = new System.Drawing.Point(27, 57);
            this.btnCargarMP.Name = "btnCargarMP";
            this.btnCargarMP.Size = new System.Drawing.Size(200, 59);
            this.btnCargarMP.TabIndex = 15;
            this.btnCargarMP.Text = "Cargar Medio de Pago";
            this.btnCargarMP.UseVisualStyleBackColor = false;
            this.btnCargarMP.Click += new System.EventHandler(this.btnCargarMP_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(233, 57);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 59);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar Medio de Pago";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(464, 57);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 59);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar Medio de Pago";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(27, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 255);
            this.panel1.TabIndex = 18;
            // 
            // ListaMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCargarMP);
            this.Controls.Add(this.dgvMedioPago);
            this.Controls.Add(this.panel1);
            this.Name = "ListaMedioPago";
            this.Text = "ListaMedioPago";
            this.Load += new System.EventHandler(this.ListaMedioPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPago)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvMedioPago;
        private Button btnCargarMP;
        private Button btnEditar;
        private Button btnEliminar;
        private Panel panel1;
    }
}