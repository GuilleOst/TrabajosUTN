namespace Cinev3.Formularios.pelicula1
{
    partial class frmListadoPelicula
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPelicula = new System.Windows.Forms.DataGridView();
            this.CodPeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leyenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoEstreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPelicula = new System.Windows.Forms.Button();
            this.btnEditarPelicula = new System.Windows.Forms.Button();
            this.btnCancelarPelicula = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPelicula);
            this.panel1.Location = new System.Drawing.Point(38, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 506);
            this.panel1.TabIndex = 0;
            // 
            // dgvPelicula
            // 
            this.dgvPelicula.AllowUserToAddRows = false;
            this.dgvPelicula.AllowUserToDeleteRows = false;
            this.dgvPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPeli,
            this.Titulo,
            this.Leyenda,
            this.Duracion,
            this.Sinopsis,
            this.AnoEstreno,
            this.Descripcion,
            this.Distribuidora,
            this.Origen,
            this.Genero,
            this.Calificacion,
            this.Formato,
            this.Idioma});
            this.dgvPelicula.Location = new System.Drawing.Point(3, 100);
            this.dgvPelicula.Name = "dgvPelicula";
            this.dgvPelicula.ReadOnly = true;
            this.dgvPelicula.RowTemplate.Height = 25;
            this.dgvPelicula.Size = new System.Drawing.Size(1344, 334);
            this.dgvPelicula.TabIndex = 0;
            // 
            // CodPeli
            // 
            this.CodPeli.HeaderText = "Codigo";
            this.CodPeli.Name = "CodPeli";
            this.CodPeli.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Leyenda
            // 
            this.Leyenda.HeaderText = "Leyenda";
            this.Leyenda.Name = "Leyenda";
            this.Leyenda.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // Sinopsis
            // 
            this.Sinopsis.HeaderText = "Sinopsis";
            this.Sinopsis.Name = "Sinopsis";
            this.Sinopsis.ReadOnly = true;
            // 
            // AnoEstreno
            // 
            this.AnoEstreno.HeaderText = "Año de Estreno";
            this.AnoEstreno.Name = "AnoEstreno";
            this.AnoEstreno.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Distribuidora
            // 
            this.Distribuidora.HeaderText = "Distribuidora";
            this.Distribuidora.Name = "Distribuidora";
            this.Distribuidora.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            // 
            // Formato
            // 
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // Idioma
            // 
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.Location = new System.Drawing.Point(12, 42);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(121, 56);
            this.btnAgregarPelicula.TabIndex = 1;
            this.btnAgregarPelicula.Text = "Agregar pelicula";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);
            // 
            // btnEditarPelicula
            // 
            this.btnEditarPelicula.Location = new System.Drawing.Point(199, 42);
            this.btnEditarPelicula.Name = "btnEditarPelicula";
            this.btnEditarPelicula.Size = new System.Drawing.Size(123, 56);
            this.btnEditarPelicula.TabIndex = 2;
            this.btnEditarPelicula.Text = "Editar pelicula";
            this.btnEditarPelicula.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPelicula
            // 
            this.btnCancelarPelicula.Location = new System.Drawing.Point(973, 42);
            this.btnCancelarPelicula.Name = "btnCancelarPelicula";
            this.btnCancelarPelicula.Size = new System.Drawing.Size(108, 56);
            this.btnCancelarPelicula.TabIndex = 3;
            this.btnCancelarPelicula.Text = "Cancelar pelicula";
            this.btnCancelarPelicula.UseVisualStyleBackColor = true;
            // 
            // frmListadoPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1432, 654);
            this.Controls.Add(this.btnCancelarPelicula);
            this.Controls.Add(this.btnEditarPelicula);
            this.Controls.Add(this.btnAgregarPelicula);
            this.Controls.Add(this.panel1);
            this.Name = "frmListadoPelicula";
            this.Text = "frmListadoPelicula";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dgvPelicula;
        private Button btnAgregarPelicula;
        private Button btnEditarPelicula;
        private Button btnCancelarPelicula;
        private DataGridViewTextBoxColumn CodPeli;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Leyenda;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Sinopsis;
        private DataGridViewTextBoxColumn AnoEstreno;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Distribuidora;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Calificacion;
        private DataGridViewTextBoxColumn Formato;
        private DataGridViewTextBoxColumn Idioma;
    }
}