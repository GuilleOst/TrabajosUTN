namespace TPG3.Formularios.Tarjeta
{
    partial class AltaTarjeta
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
            this.txtCodTarjeta = new System.Windows.Forms.TextBox();
            this.btnRegistrarTarjeta = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodTarjeta
            // 
            this.txtCodTarjeta.Location = new System.Drawing.Point(215, 110);
            this.txtCodTarjeta.MaxLength = 16;
            this.txtCodTarjeta.Name = "txtCodTarjeta";
            this.txtCodTarjeta.Size = new System.Drawing.Size(246, 23);
            this.txtCodTarjeta.TabIndex = 24;
            // 
            // btnRegistrarTarjeta
            // 
            this.btnRegistrarTarjeta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarTarjeta.Location = new System.Drawing.Point(275, 205);
            this.btnRegistrarTarjeta.Name = "btnRegistrarTarjeta";
            this.btnRegistrarTarjeta.Size = new System.Drawing.Size(158, 45);
            this.btnRegistrarTarjeta.TabIndex = 23;
            this.btnRegistrarTarjeta.Text = "Registrar Tarjeta";
            this.btnRegistrarTarjeta.UseVisualStyleBackColor = false;
            this.btnRegistrarTarjeta.Click += new System.EventHandler(this.btnRegistrarTarjeta_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(215, 194);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(246, 23);
            this.txtDescripcion.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(215, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(33, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 28);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Alta Tarjeta";
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(187, 155);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(246, 23);
            this.cmbBanco.TabIndex = 26;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(139, 300);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRegistrarTarjeta);
            this.panel1.Controls.Add(this.cmbBanco);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 322);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Tarjeta:";
            // 
            // AltaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtCodTarjeta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "AltaTarjeta";
            this.Text = "AltaTarjeta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtCodTarjeta;
        private Button btnRegistrarTarjeta;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label lblTitulo;
        private ComboBox cmbBanco;
        private Label lblError;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}