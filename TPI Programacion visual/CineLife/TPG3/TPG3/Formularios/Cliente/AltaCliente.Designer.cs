namespace TPG3.Formularios.Cliente
{
    partial class AltaCliente
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
            this.panelBackAltaPromocion = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mtbNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCargarPromocion = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.mtbDni = new System.Windows.Forms.MaskedTextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panelBackAltaPromocion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(110, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 30);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Alta Cliente";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.btnVolver);
            this.panelBackAltaPromocion.Controls.Add(this.mtbNacimiento);
            this.panelBackAltaPromocion.Controls.Add(this.label3);
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
            this.panelBackAltaPromocion.ForeColor = System.Drawing.Color.White;
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(110, 87);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(580, 346);
            this.panelBackAltaPromocion.TabIndex = 29;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(469, 271);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 37);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // mtbNacimiento
            // 
            this.mtbNacimiento.Location = new System.Drawing.Point(162, 214);
            this.mtbNacimiento.Mask = "00/00/0000";
            this.mtbNacimiento.Name = "mtbNacimiento";
            this.mtbNacimiento.Size = new System.Drawing.Size(120, 23);
            this.mtbNacimiento.TabIndex = 31;
            this.mtbNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "(*)Nacimiento:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(50, 271);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 29;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(390, 99);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 23);
            this.txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 23);
            this.txtNombre.TabIndex = 27;
            // 
            // btnCargarPromocion
            // 
            this.btnCargarPromocion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarPromocion.FlatAppearance.BorderSize = 0;
            this.btnCargarPromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPromocion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPromocion.Location = new System.Drawing.Point(350, 271);
            this.btnCargarPromocion.Name = "btnCargarPromocion";
            this.btnCargarPromocion.Size = new System.Drawing.Size(92, 37);
            this.btnCargarPromocion.TabIndex = 24;
            this.btnCargarPromocion.Text = "Agregar";
            this.btnCargarPromocion.UseVisualStyleBackColor = false;
            this.btnCargarPromocion.Click += new System.EventHandler(this.btnCargarPromocion_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(390, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 23);
            this.txtEmail.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "(*)Email:";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(127, 154);
            this.mtbTelefono.Mask = "99999999999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(155, 23);
            this.mtbTelefono.TabIndex = 24;
            this.mtbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(28, 156);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(101, 21);
            this.lblTelefono.TabIndex = 23;
            this.lblTelefono.Text = "(*)Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "(*)Tipo Doc:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(390, 35);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(155, 23);
            this.cbTipoDoc.TabIndex = 21;
            // 
            // mtbDni
            // 
            this.mtbDni.Location = new System.Drawing.Point(127, 35);
            this.mtbDni.Mask = "99999999";
            this.mtbDni.Name = "mtbDni";
            this.mtbDni.Size = new System.Drawing.Size(155, 23);
            this.mtbDni.TabIndex = 20;
            this.mtbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDni.ValidatingType = typeof(int);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(28, 37);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(63, 21);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "(*)DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(28, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 21);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "(*)Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(291, 99);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 21);
            this.lblApellido.TabIndex = 16;
            this.lblApellido.Text = "(*)Apellido:";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(801, 517);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Panel panelBackAltaPromocion;
        private MaskedTextBox mtbNacimiento;
        private Label label3;
        private Label lblError;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnCargarPromocion;
        private TextBox txtEmail;
        private Label label2;
        private MaskedTextBox mtbTelefono;
        private Label lblTelefono;
        private Label label1;
        private ComboBox cbTipoDoc;
        private MaskedTextBox mtbDni;
        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private Button btnVolver;
    }
}