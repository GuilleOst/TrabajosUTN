namespace TPG3.Formularios.Promocion
{
    partial class AltaPromocion
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
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.mtbInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtbFin = new System.Windows.Forms.MaskedTextBox();
            this.btnCargarPromocion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBackAltaPromocion = new System.Windows.Forms.Panel();
            this.panelBackAltaPromocion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(35, 339);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(51, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 28);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Promoción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Inicio:";
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(161, 271);
            this.mtbValor.Mask = "99999";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(92, 23);
            this.mtbValor.TabIndex = 3;
            this.mtbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbValor.ValidatingType = typeof(int);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(23, 273);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(55, 21);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFin.ForeColor = System.Drawing.Color.White;
            this.lblFin.Location = new System.Drawing.Point(290, 204);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(85, 21);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "Fecha Fin:";
            // 
            // mtbInicio
            // 
            this.mtbInicio.Location = new System.Drawing.Point(161, 202);
            this.mtbInicio.Mask = "00/00/0000";
            this.mtbInicio.Name = "mtbInicio";
            this.mtbInicio.Size = new System.Drawing.Size(92, 23);
            this.mtbInicio.TabIndex = 4;
            this.mtbInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtbFin
            // 
            this.mtbFin.Location = new System.Drawing.Point(453, 206);
            this.mtbFin.Mask = "00/00/0000";
            this.mtbFin.Name = "mtbFin";
            this.mtbFin.Size = new System.Drawing.Size(92, 23);
            this.mtbFin.TabIndex = 5;
            this.mtbFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbFin.ValidatingType = typeof(System.DateTime);
            // 
            // btnCargarPromocion
            // 
            this.btnCargarPromocion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarPromocion.FlatAppearance.BorderSize = 0;
            this.btnCargarPromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPromocion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPromocion.ForeColor = System.Drawing.Color.White;
            this.btnCargarPromocion.Location = new System.Drawing.Point(420, 368);
            this.btnCargarPromocion.Name = "btnCargarPromocion";
            this.btnCargarPromocion.Size = new System.Drawing.Size(135, 48);
            this.btnCargarPromocion.TabIndex = 10;
            this.btnCargarPromocion.Text = "Cargar";
            this.btnCargarPromocion.UseVisualStyleBackColor = false;
            this.btnCargarPromocion.Click += new System.EventHandler(this.btnCargarPromocion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(133, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 45);
            this.txtDescripcion.TabIndex = 19;
            this.txtDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descripcion:";
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.label3);
            this.panelBackAltaPromocion.Controls.Add(this.btnCargarPromocion);
            this.panelBackAltaPromocion.Controls.Add(this.lblFin);
            this.panelBackAltaPromocion.Controls.Add(this.txtDescripcion);
            this.panelBackAltaPromocion.Controls.Add(this.lblValor);
            this.panelBackAltaPromocion.Controls.Add(this.txtNombre);
            this.panelBackAltaPromocion.Controls.Add(this.mtbInicio);
            this.panelBackAltaPromocion.Controls.Add(this.lblError);
            this.panelBackAltaPromocion.Controls.Add(this.mtbValor);
            this.panelBackAltaPromocion.Controls.Add(this.label2);
            this.panelBackAltaPromocion.Controls.Add(this.mtbFin);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(51, 78);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(580, 443);
            this.panelBackAltaPromocion.TabIndex = 14;
            // 
            // AltaPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(722, 650);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Name = "AltaPromocion";
            this.Text = "AltaPromocion";
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblError;
        private Label lblTitulo;
        private Label label1;
        private MaskedTextBox mtbValor;
        private Label lblValor;
        private Label lblFin;
        private MaskedTextBox mtbInicio;
        private MaskedTextBox mtbFin;
        private Button btnCargarPromocion;
        private Label label2;
        private TextBox txtNombre;
        private RichTextBox txtDescripcion;
        private Label label3;
        private Panel panelBackAltaPromocion;
    }
}