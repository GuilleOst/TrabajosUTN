namespace TPG3.Formularios.Empleado
{
    partial class AltaEmpleado
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.mtbDni = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCargarPromocion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.panelBackAltaPromocion = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panelBackAltaPromocion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(90, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 30);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Alta Empleado";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(282, 86);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 21);
            this.lblApellido.TabIndex = 16;
            this.lblApellido.Text = "(*)Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(19, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 21);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "(*)Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(19, 26);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(63, 21);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "(*)DNI:";
            // 
            // mtbDni
            // 
            this.mtbDni.Location = new System.Drawing.Point(118, 24);
            this.mtbDni.Mask = "99999999";
            this.mtbDni.Name = "mtbDni";
            this.mtbDni.Size = new System.Drawing.Size(155, 23);
            this.mtbDni.TabIndex = 1;
            this.mtbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDni.ValidatingType = typeof(int);
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(381, 24);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(155, 23);
            this.cbTipoDoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "(*)Tipo Doc:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(19, 145);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 21);
            this.lblTelefono.TabIndex = 23;
            this.lblTelefono.Text = "(*)Teléfono:";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(118, 143);
            this.mtbTelefono.Mask = "99999999999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(155, 23);
            this.mtbTelefono.TabIndex = 5;
            this.mtbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "(*)Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(381, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // btnCargarPromocion
            // 
            this.btnCargarPromocion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarPromocion.FlatAppearance.BorderSize = 0;
            this.btnCargarPromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPromocion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPromocion.ForeColor = System.Drawing.Color.Black;
            this.btnCargarPromocion.Location = new System.Drawing.Point(337, 240);
            this.btnCargarPromocion.Name = "btnCargarPromocion";
            this.btnCargarPromocion.Size = new System.Drawing.Size(92, 37);
            this.btnCargarPromocion.TabIndex = 7;
            this.btnCargarPromocion.Text = "Cargar";
            this.btnCargarPromocion.UseVisualStyleBackColor = false;
            this.btnCargarPromocion.Click += new System.EventHandler(this.btnCargarPromocion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(381, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 23);
            this.txtApellido.TabIndex = 4;
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.btnVolver);
            this.panelBackAltaPromocion.Controls.Add(this.lblError);
            this.panelBackAltaPromocion.Controls.Add(this.txtApellido);
            this.panelBackAltaPromocion.Controls.Add(this.txtNombre);
            this.panelBackAltaPromocion.Controls.Add(this.btnCargarPromocion);
            this.panelBackAltaPromocion.Controls.Add(this.txtEmail);
            this.panelBackAltaPromocion.Controls.Add(this.label2);
            this.panelBackAltaPromocion.Controls.Add(this.mtbTelefono);
            this.panelBackAltaPromocion.Controls.Add(this.lblTelefono);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Controls.Add(this.cbTipoDoc);
            this.panelBackAltaPromocion.Controls.Add(this.mtbDni);
            this.panelBackAltaPromocion.Controls.Add(this.lblDni);
            this.panelBackAltaPromocion.Controls.Add(this.lblNombre);
            this.panelBackAltaPromocion.Controls.Add(this.lblApellido);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(90, 69);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(580, 326);
            this.panelBackAltaPromocion.TabIndex = 27;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(444, 240);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 37);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(118, 205);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 29;
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(756, 443);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Name = "AltaEmpleado";
            this.Text = "AltaEmpleado";
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitulo;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDni;
        private MaskedTextBox mtbDni;
        private ComboBox cbTipoDoc;
        private Label label1;
        private Label lblTelefono;
        private MaskedTextBox mtbTelefono;
        private Label label2;
        private TextBox txtEmail;
        private Button btnCargarPromocion;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Panel panelBackAltaPromocion;
        private Label lblError;
        private Button btnVolver;
    }
}