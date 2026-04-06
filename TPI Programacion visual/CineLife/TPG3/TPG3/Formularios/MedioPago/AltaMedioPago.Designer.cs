namespace TPG3.Formularios.MedioPago
{
    partial class AltaMedioPago
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCargarMP = new System.Windows.Forms.Button();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(33, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(33, 68);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 21);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(209, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 29);
            this.txtNombre.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(209, 157);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 29);
            this.txtDescripcion.TabIndex = 16;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarjeta.ForeColor = System.Drawing.Color.White;
            this.lblTarjeta.Location = new System.Drawing.Point(33, 116);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(66, 21);
            this.lblTarjeta.TabIndex = 17;
            this.lblTarjeta.Text = "Tarjeta:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(112, 258);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 27;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(53, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(207, 28);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Alta Medio de Pago";
            // 
            // btnCargarMP
            // 
            this.btnCargarMP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarMP.FlatAppearance.BorderSize = 0;
            this.btnCargarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarMP.ForeColor = System.Drawing.Color.White;
            this.btnCargarMP.Location = new System.Drawing.Point(264, 196);
            this.btnCargarMP.Name = "btnCargarMP";
            this.btnCargarMP.Size = new System.Drawing.Size(92, 37);
            this.btnCargarMP.TabIndex = 23;
            this.btnCargarMP.Text = "Cargar";
            this.btnCargarMP.UseVisualStyleBackColor = false;
            this.btnCargarMP.Click += new System.EventHandler(this.btnCargarMP_Click);
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(209, 211);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(200, 23);
            this.cmbTarjeta.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btnCargarMP);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblTarjeta);
            this.panel1.Location = new System.Drawing.Point(53, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 276);
            this.panel1.TabIndex = 28;
            // 
            // AltaMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbTarjeta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.Name = "AltaMedioPago";
            this.Text = "AltaMedioPago";
            this.Load += new System.EventHandler(this.AltaMedioPago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label lblTarjeta;
        private Label lblError;
        private Label lblTitulo;
        private Button btnCargarMP;
        private ComboBox cmbTarjeta;
        private Panel panel1;
    }
}