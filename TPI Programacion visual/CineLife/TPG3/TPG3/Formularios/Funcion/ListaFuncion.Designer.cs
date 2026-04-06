namespace TPG3.Formularios.Funcion
{
    partial class ListaFuncion
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
            this.btnCargarFuncion = new System.Windows.Forms.Button();
            this.btnEliminarFuncion = new System.Windows.Forms.Button();
            this.btnEditarFuncion = new System.Windows.Forms.Button();
            this.dgvFuncion = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(34, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 30);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Lista de Funciones";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnCargarFuncion
            // 
            this.btnCargarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarFuncion.FlatAppearance.BorderSize = 0;
            this.btnCargarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnCargarFuncion.Location = new System.Drawing.Point(51, 82);
            this.btnCargarFuncion.Name = "btnCargarFuncion";
            this.btnCargarFuncion.Size = new System.Drawing.Size(143, 47);
            this.btnCargarFuncion.TabIndex = 0;
            this.btnCargarFuncion.Text = "Cargar Funcion";
            this.btnCargarFuncion.UseVisualStyleBackColor = false;
            this.btnCargarFuncion.Click += new System.EventHandler(this.btnCargarFuncion_Click);
            // 
            // btnEliminarFuncion
            // 
            this.btnEliminarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarFuncion.FlatAppearance.BorderSize = 0;
            this.btnEliminarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFuncion.Location = new System.Drawing.Point(641, 82);
            this.btnEliminarFuncion.Name = "btnEliminarFuncion";
            this.btnEliminarFuncion.Size = new System.Drawing.Size(143, 47);
            this.btnEliminarFuncion.TabIndex = 2;
            this.btnEliminarFuncion.Text = "Eliminar Funcion";
            this.btnEliminarFuncion.UseVisualStyleBackColor = false;
            this.btnEliminarFuncion.Click += new System.EventHandler(this.btnEliminarFuncion_Click);
            // 
            // btnEditarFuncion
            // 
            this.btnEditarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditarFuncion.FlatAppearance.BorderSize = 0;
            this.btnEditarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnEditarFuncion.Location = new System.Drawing.Point(200, 82);
            this.btnEditarFuncion.Name = "btnEditarFuncion";
            this.btnEditarFuncion.Size = new System.Drawing.Size(143, 47);
            this.btnEditarFuncion.TabIndex = 1;
            this.btnEditarFuncion.Text = "Editar Funcion";
            this.btnEditarFuncion.UseVisualStyleBackColor = false;
            this.btnEditarFuncion.Click += new System.EventHandler(this.btnEditarFuncion_Click);
            // 
            // dgvFuncion
            // 
            this.dgvFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncion.Location = new System.Drawing.Point(17, 133);
            this.dgvFuncion.Name = "dgvFuncion";
            this.dgvFuncion.RowTemplate.Height = 25;
            this.dgvFuncion.Size = new System.Drawing.Size(732, 199);
            this.dgvFuncion.TabIndex = 3;
            this.dgvFuncion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncion_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.dgvFuncion);
            this.panel1.Location = new System.Drawing.Point(34, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 361);
            this.panel1.TabIndex = 14;
            // 
            // ListaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.btnEditarFuncion);
            this.Controls.Add(this.btnEliminarFuncion);
            this.Controls.Add(this.btnCargarFuncion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "ListaFuncion";
            this.Text = "ListaFuncion";
            this.Load += new System.EventHandler(this.ListaFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Button btnCargarFuncion;
        private Button btnEliminarFuncion;
        private Button btnEditarFuncion;
        private DataGridView dgvFuncion;
        private Panel panel1;
    }
}