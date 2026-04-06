namespace TPG3.Formularios.Pelicula
{
    partial class ListaPelicula
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
            this.lblListaPelicula = new System.Windows.Forms.Label();
            this.pnlListadoProducto = new System.Windows.Forms.Panel();
            this.gdrActualizarPeli = new System.Windows.Forms.DataGridView();
            this.codPeliculaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscadorGenero = new System.Windows.Forms.TextBox();
            this.lblBuscadorGenero = new System.Windows.Forms.Label();
            this.txtBuscadorTitulo = new System.Windows.Forms.TextBox();
            this.lblBuscadorTitulo = new System.Windows.Forms.Label();
            this.btnRegistrarPelícula = new System.Windows.Forms.Button();
            this.btnEliminarPelicula = new System.Windows.Forms.Button();
            this.pnlListadoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarPeli)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaPelicula
            // 
            this.lblListaPelicula.AutoSize = true;
            this.lblListaPelicula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaPelicula.ForeColor = System.Drawing.Color.White;
            this.lblListaPelicula.Location = new System.Drawing.Point(516, 9);
            this.lblListaPelicula.Name = "lblListaPelicula";
            this.lblListaPelicula.Size = new System.Drawing.Size(203, 28);
            this.lblListaPelicula.TabIndex = 21;
            this.lblListaPelicula.Text = "Listado de  Películas";
            // 
            // pnlListadoProducto
            // 
            this.pnlListadoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.pnlListadoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListadoProducto.Controls.Add(this.gdrActualizarPeli);
            this.pnlListadoProducto.Controls.Add(this.lblListaPelicula);
            this.pnlListadoProducto.Controls.Add(this.txtBuscadorGenero);
            this.pnlListadoProducto.Controls.Add(this.lblBuscadorGenero);
            this.pnlListadoProducto.Controls.Add(this.txtBuscadorTitulo);
            this.pnlListadoProducto.Controls.Add(this.lblBuscadorTitulo);
            this.pnlListadoProducto.Location = new System.Drawing.Point(33, 96);
            this.pnlListadoProducto.Name = "pnlListadoProducto";
            this.pnlListadoProducto.Size = new System.Drawing.Size(888, 332);
            this.pnlListadoProducto.TabIndex = 20;
            // 
            // gdrActualizarPeli
            // 
            this.gdrActualizarPeli.AllowUserToAddRows = false;
            this.gdrActualizarPeli.AllowUserToDeleteRows = false;
            this.gdrActualizarPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrActualizarPeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPeliculaItem,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.Duración,
            this.dataGridViewTextBoxColumn3,
            this.Origen,
            this.Calificación,
            this.Formato,
            this.Genero,
            this.Distribuidora,
            this.Idioma});
            this.gdrActualizarPeli.Location = new System.Drawing.Point(3, 99);
            this.gdrActualizarPeli.Name = "gdrActualizarPeli";
            this.gdrActualizarPeli.ReadOnly = true;
            this.gdrActualizarPeli.RowTemplate.Height = 25;
            this.gdrActualizarPeli.Size = new System.Drawing.Size(846, 228);
            this.gdrActualizarPeli.TabIndex = 27;
            // 
            // codPeliculaItem
            // 
            this.codPeliculaItem.DataPropertyName = "codPelicula";
            this.codPeliculaItem.HeaderText = "codPelicula";
            this.codPeliculaItem.Name = "codPeliculaItem";
            this.codPeliculaItem.ReadOnly = true;
            this.codPeliculaItem.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ptitulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pleyenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "Leyenda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Duración
            // 
            this.Duración.DataPropertyName = "duracion";
            this.Duración.HeaderText = "Duración";
            this.Duración.Name = "Duración";
            this.Duración.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sinopsis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sinopsis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "nombre";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Calificación
            // 
            this.Calificación.DataPropertyName = "abreviatura";
            this.Calificación.HeaderText = "Calificación";
            this.Calificación.Name = "Calificación";
            this.Calificación.ReadOnly = true;
            // 
            // Formato
            // 
            this.Formato.DataPropertyName = "fdescripcion";
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "gdescripcion";
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Distribuidora
            // 
            this.Distribuidora.DataPropertyName = "nombreDistribuidora";
            this.Distribuidora.HeaderText = "Distribuidora";
            this.Distribuidora.Name = "Distribuidora";
            this.Distribuidora.ReadOnly = true;
            // 
            // Idioma
            // 
            this.Idioma.DataPropertyName = "idescripcion";
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            // 
            // txtBuscadorGenero
            // 
            this.txtBuscadorGenero.Location = new System.Drawing.Point(228, 53);
            this.txtBuscadorGenero.Name = "txtBuscadorGenero";
            this.txtBuscadorGenero.Size = new System.Drawing.Size(184, 23);
            this.txtBuscadorGenero.TabIndex = 17;
            this.txtBuscadorGenero.TextChanged += new System.EventHandler(this.txtBuscadorGenero_TextChanged);
            // 
            // lblBuscadorGenero
            // 
            this.lblBuscadorGenero.AutoSize = true;
            this.lblBuscadorGenero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorGenero.ForeColor = System.Drawing.Color.White;
            this.lblBuscadorGenero.Location = new System.Drawing.Point(228, 18);
            this.lblBuscadorGenero.Name = "lblBuscadorGenero";
            this.lblBuscadorGenero.Size = new System.Drawing.Size(58, 19);
            this.lblBuscadorGenero.TabIndex = 16;
            this.lblBuscadorGenero.Text = "Genero";
            // 
            // txtBuscadorTitulo
            // 
            this.txtBuscadorTitulo.Location = new System.Drawing.Point(18, 53);
            this.txtBuscadorTitulo.Name = "txtBuscadorTitulo";
            this.txtBuscadorTitulo.Size = new System.Drawing.Size(184, 23);
            this.txtBuscadorTitulo.TabIndex = 15;
            this.txtBuscadorTitulo.TextChanged += new System.EventHandler(this.txtBuscadorTitulo_TextChanged);
            // 
            // lblBuscadorTitulo
            // 
            this.lblBuscadorTitulo.AutoSize = true;
            this.lblBuscadorTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorTitulo.ForeColor = System.Drawing.Color.White;
            this.lblBuscadorTitulo.Location = new System.Drawing.Point(18, 18);
            this.lblBuscadorTitulo.Name = "lblBuscadorTitulo";
            this.lblBuscadorTitulo.Size = new System.Drawing.Size(81, 19);
            this.lblBuscadorTitulo.TabIndex = 8;
            this.lblBuscadorTitulo.Text = "Tipo Título";
            // 
            // btnRegistrarPelícula
            // 
            this.btnRegistrarPelícula.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarPelícula.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPelícula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPelícula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarPelícula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarPelícula.Location = new System.Drawing.Point(33, 22);
            this.btnRegistrarPelícula.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarPelícula.Name = "btnRegistrarPelícula";
            this.btnRegistrarPelícula.Size = new System.Drawing.Size(308, 47);
            this.btnRegistrarPelícula.TabIndex = 19;
            this.btnRegistrarPelícula.Text = "Registrar / Actualizar Película";
            this.btnRegistrarPelícula.UseVisualStyleBackColor = false;
            this.btnRegistrarPelícula.Click += new System.EventHandler(this.btnRegistrarPelícula_Click);
            // 
            // btnEliminarPelicula
            // 
            this.btnEliminarPelicula.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarPelicula.FlatAppearance.BorderSize = 0;
            this.btnEliminarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPelicula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarPelicula.Location = new System.Drawing.Point(724, 22);
            this.btnEliminarPelicula.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarPelicula.Name = "btnEliminarPelicula";
            this.btnEliminarPelicula.Size = new System.Drawing.Size(197, 47);
            this.btnEliminarPelicula.TabIndex = 21;
            this.btnEliminarPelicula.Text = "Eliminar Película";
            this.btnEliminarPelicula.UseVisualStyleBackColor = false;
            this.btnEliminarPelicula.Click += new System.EventHandler(this.btnEliminarPelicula_Click);
            // 
            // ListaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.btnEliminarPelicula);
            this.Controls.Add(this.pnlListadoProducto);
            this.Controls.Add(this.btnRegistrarPelícula);
            this.Name = "ListaPelicula";
            this.Text = "ListaPelicula";
            this.Load += new System.EventHandler(this.ListaPelicula_Load);
            this.pnlListadoProducto.ResumeLayout(false);
            this.pnlListadoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarPeli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblListaPelicula;
        private Panel pnlListadoProducto;
        private TextBox txtBuscadorGenero;
        private Label lblBuscadorGenero;
        private TextBox txtBuscadorTitulo;
        private Label lblBuscadorTitulo;
        private Button btnRegistrarPelícula;
        private DataGridView gdrActualizarPeli;
        private DataGridViewTextBoxColumn codPeliculaItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Duración;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Calificación;
        private DataGridViewTextBoxColumn Formato;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Distribuidora;
        private DataGridViewTextBoxColumn Idioma;
        private Button btnEliminarPelicula;
    }
}