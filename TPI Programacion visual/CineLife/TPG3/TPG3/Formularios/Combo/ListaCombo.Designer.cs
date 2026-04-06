namespace TPG3.Formularios.Combo
{
    partial class ListaCombo
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
            this.lblListaCombo = new System.Windows.Forms.Label();
            this.pnlListadoProducto = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gdrConsultarProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBuscadorCombo = new System.Windows.Forms.Label();
            this.btnRegistrarCombo = new System.Windows.Forms.Button();
            this.btnActualizarCombo = new System.Windows.Forms.Button();
            this.btnEliminarCombo = new System.Windows.Forms.Button();
            this.pnlListadoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaCombo
            // 
            this.lblListaCombo.AutoSize = true;
            this.lblListaCombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaCombo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListaCombo.Location = new System.Drawing.Point(543, 24);
            this.lblListaCombo.Name = "lblListaCombo";
            this.lblListaCombo.Size = new System.Drawing.Size(190, 28);
            this.lblListaCombo.TabIndex = 15;
            this.lblListaCombo.Text = "Listado de Combos";
            // 
            // pnlListadoProducto
            // 
            this.pnlListadoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.pnlListadoProducto.Controls.Add(this.txtNombre);
            this.pnlListadoProducto.Controls.Add(this.lblListaCombo);
            this.pnlListadoProducto.Controls.Add(this.gdrConsultarProd);
            this.pnlListadoProducto.Controls.Add(this.flowLayoutPanel1);
            this.pnlListadoProducto.Controls.Add(this.lblBuscadorCombo);
            this.pnlListadoProducto.Location = new System.Drawing.Point(33, 96);
            this.pnlListadoProducto.Name = "pnlListadoProducto";
            this.pnlListadoProducto.Size = new System.Drawing.Size(761, 332);
            this.pnlListadoProducto.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 23);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // gdrConsultarProd
            // 
            this.gdrConsultarProd.AllowUserToAddRows = false;
            this.gdrConsultarProd.AllowUserToDeleteRows = false;
            this.gdrConsultarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrConsultarProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdProducto,
            this.Descripcion,
            this.Precio,
            this.cantidadItems});
            this.gdrConsultarProd.Location = new System.Drawing.Point(18, 99);
            this.gdrConsultarProd.Name = "gdrConsultarProd";
            this.gdrConsultarProd.ReadOnly = true;
            this.gdrConsultarProd.RowTemplate.Height = 25;
            this.gdrConsultarProd.Size = new System.Drawing.Size(715, 214);
            this.gdrConsultarProd.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "idProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 240;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // cantidadItems
            // 
            this.cantidadItems.DataPropertyName = "cantidadItems";
            this.cantidadItems.HeaderText = "Cantidad Items";
            this.cantidadItems.Name = "cantidadItems";
            this.cantidadItems.ReadOnly = true;
            this.cantidadItems.Width = 120;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // lblBuscadorCombo
            // 
            this.lblBuscadorCombo.AutoSize = true;
            this.lblBuscadorCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscadorCombo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscadorCombo.Location = new System.Drawing.Point(18, 24);
            this.lblBuscadorCombo.Name = "lblBuscadorCombo";
            this.lblBuscadorCombo.Size = new System.Drawing.Size(69, 19);
            this.lblBuscadorCombo.TabIndex = 8;
            this.lblBuscadorCombo.Text = "Nombre:";
            // 
            // btnRegistrarCombo
            // 
            this.btnRegistrarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarCombo.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarCombo.Location = new System.Drawing.Point(33, 22);
            this.btnRegistrarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarCombo.Name = "btnRegistrarCombo";
            this.btnRegistrarCombo.Size = new System.Drawing.Size(171, 47);
            this.btnRegistrarCombo.TabIndex = 13;
            this.btnRegistrarCombo.Text = "Registrar  Combo";
            this.btnRegistrarCombo.UseVisualStyleBackColor = false;
            this.btnRegistrarCombo.Click += new System.EventHandler(this.btnRegistrarCombo_Click);
            // 
            // btnActualizarCombo
            // 
            this.btnActualizarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizarCombo.FlatAppearance.BorderSize = 0;
            this.btnActualizarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarCombo.Location = new System.Drawing.Point(233, 22);
            this.btnActualizarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizarCombo.Name = "btnActualizarCombo";
            this.btnActualizarCombo.Size = new System.Drawing.Size(194, 47);
            this.btnActualizarCombo.TabIndex = 16;
            this.btnActualizarCombo.Text = "Actualizar Combo";
            this.btnActualizarCombo.UseVisualStyleBackColor = false;
            this.btnActualizarCombo.Click += new System.EventHandler(this.btnActualizarCombo_Click);
            // 
            // btnEliminarCombo
            // 
            this.btnEliminarCombo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarCombo.FlatAppearance.BorderSize = 0;
            this.btnEliminarCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarCombo.Location = new System.Drawing.Point(600, 22);
            this.btnEliminarCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarCombo.Name = "btnEliminarCombo";
            this.btnEliminarCombo.Size = new System.Drawing.Size(194, 47);
            this.btnEliminarCombo.TabIndex = 17;
            this.btnEliminarCombo.Text = "Eliminar Combo";
            this.btnEliminarCombo.UseVisualStyleBackColor = false;
            this.btnEliminarCombo.Click += new System.EventHandler(this.btnEliminarCombo_Click);
            // 
            // ListaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.btnEliminarCombo);
            this.Controls.Add(this.btnActualizarCombo);
            this.Controls.Add(this.pnlListadoProducto);
            this.Controls.Add(this.btnRegistrarCombo);
            this.Name = "ListaCombo";
            this.Text = "ListaCombo";
            this.Load += new System.EventHandler(this.ListaCombo_Load);
            this.pnlListadoProducto.ResumeLayout(false);
            this.pnlListadoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrConsultarProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblListaCombo;
        private Panel pnlListadoProducto;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblBuscadorCombo;
        private Button btnRegistrarCombo;
        private DataGridView gdrConsultarProd;
        private TextBox txtNombre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn cantidadItems;
        private Button btnActualizarCombo;
        private Button btnEliminarCombo;
    }
}