namespace TPG3.Formularios.Actores
{
    partial class ListaActor
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
            this.btnRegistrarActualizarActor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblListaActor = new System.Windows.Forms.Label();
            this.dtgListadoActor = new System.Windows.Forms.DataGridView();
            this.CodigoActor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscadorApellido = new System.Windows.Forms.TextBox();
            this.txtBuscadorNombre = new System.Windows.Forms.TextBox();
            this.lblBuscadorApellido = new System.Windows.Forms.Label();
            this.lblBuscadorNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoActor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarActualizarActor
            // 
            this.btnRegistrarActualizarActor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarActualizarActor.FlatAppearance.BorderSize = 0;
            this.btnRegistrarActualizarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarActualizarActor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarActualizarActor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarActualizarActor.Location = new System.Drawing.Point(51, 35);
            this.btnRegistrarActualizarActor.Name = "btnRegistrarActualizarActor";
            this.btnRegistrarActualizarActor.Size = new System.Drawing.Size(283, 51);
            this.btnRegistrarActualizarActor.TabIndex = 0;
            this.btnRegistrarActualizarActor.Text = "Registrar / Actualizar Actor";
            this.btnRegistrarActualizarActor.UseVisualStyleBackColor = false;
            this.btnRegistrarActualizarActor.Click += new System.EventHandler(this.btnRegistrarActualizarActor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblListaActor);
            this.panel1.Controls.Add(this.dtgListadoActor);
            this.panel1.Controls.Add(this.txtBuscadorApellido);
            this.panel1.Controls.Add(this.txtBuscadorNombre);
            this.panel1.Controls.Add(this.lblBuscadorApellido);
            this.panel1.Controls.Add(this.lblBuscadorNombre);
            this.panel1.Location = new System.Drawing.Point(51, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 316);
            this.panel1.TabIndex = 1;
            // 
            // lblListaActor
            // 
            this.lblListaActor.AutoSize = true;
            this.lblListaActor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaActor.ForeColor = System.Drawing.Color.White;
            this.lblListaActor.Location = new System.Drawing.Point(506, 8);
            this.lblListaActor.Name = "lblListaActor";
            this.lblListaActor.Size = new System.Drawing.Size(187, 28);
            this.lblListaActor.TabIndex = 2;
            this.lblListaActor.Text = "Listado de Actores";
            // 
            // dtgListadoActor
            // 
            this.dtgListadoActor.AllowUserToAddRows = false;
            this.dtgListadoActor.AllowUserToDeleteRows = false;
            this.dtgListadoActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListadoActor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoActor,
            this.Nombre,
            this.Apellido});
            this.dtgListadoActor.Location = new System.Drawing.Point(37, 83);
            this.dtgListadoActor.Name = "dtgListadoActor";
            this.dtgListadoActor.ReadOnly = true;
            this.dtgListadoActor.RowTemplate.Height = 25;
            this.dtgListadoActor.Size = new System.Drawing.Size(638, 203);
            this.dtgListadoActor.TabIndex = 4;
            // 
            // CodigoActor
            // 
            this.CodigoActor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodigoActor.DataPropertyName = "codActor";
            this.CodigoActor.HeaderText = "CodigoActor";
            this.CodigoActor.Name = "CodigoActor";
            this.CodigoActor.ReadOnly = true;
            this.CodigoActor.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // txtBuscadorApellido
            // 
            this.txtBuscadorApellido.Location = new System.Drawing.Point(246, 45);
            this.txtBuscadorApellido.Name = "txtBuscadorApellido";
            this.txtBuscadorApellido.Size = new System.Drawing.Size(171, 23);
            this.txtBuscadorApellido.TabIndex = 2;
            this.txtBuscadorApellido.TextChanged += new System.EventHandler(this.txtBuscadorApellido_TextChanged);
            // 
            // txtBuscadorNombre
            // 
            this.txtBuscadorNombre.Location = new System.Drawing.Point(37, 45);
            this.txtBuscadorNombre.Name = "txtBuscadorNombre";
            this.txtBuscadorNombre.Size = new System.Drawing.Size(171, 23);
            this.txtBuscadorNombre.TabIndex = 1;
            this.txtBuscadorNombre.TextChanged += new System.EventHandler(this.txtBuscadorNombre_TextChanged);
            // 
            // lblBuscadorApellido
            // 
            this.lblBuscadorApellido.AutoSize = true;
            this.lblBuscadorApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorApellido.ForeColor = System.Drawing.Color.White;
            this.lblBuscadorApellido.Location = new System.Drawing.Point(246, 17);
            this.lblBuscadorApellido.Name = "lblBuscadorApellido";
            this.lblBuscadorApellido.Size = new System.Drawing.Size(66, 19);
            this.lblBuscadorApellido.TabIndex = 1;
            this.lblBuscadorApellido.Text = "Apellido";
            // 
            // lblBuscadorNombre
            // 
            this.lblBuscadorNombre.AutoSize = true;
            this.lblBuscadorNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorNombre.ForeColor = System.Drawing.Color.White;
            this.lblBuscadorNombre.Location = new System.Drawing.Point(37, 17);
            this.lblBuscadorNombre.Name = "lblBuscadorNombre";
            this.lblBuscadorNombre.Size = new System.Drawing.Size(65, 19);
            this.lblBuscadorNombre.TabIndex = 0;
            this.lblBuscadorNombre.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(633, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar Actor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrarActualizarActor);
            this.Name = "ListaActor";
            this.Text = "ListaActor";
            this.Load += new System.EventHandler(this.ListaActor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoActor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegistrarActualizarActor;
        private Panel panel1;
        private DataGridView dtgListadoActor;
        private TextBox textBox1;
        private TextBox txtBuscadorNombre;
        private Label lblBuscadorApellido;
        private Label lblBuscadorNombre;
        private Label lblListaActor;
        private DataGridViewTextBoxColumn CodigoActor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private TextBox txtBuscadorApellido;
        private Button button1;
    }
}