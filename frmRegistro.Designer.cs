namespace PryPedernera1P
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.mtbCUIT = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.TbcInfo = new System.Windows.Forms.TabControl();
            this.tbpDirección = new System.Windows.Forms.TabPage();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.tbpContactos = new System.Windows.Forms.TabPage();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.pbxRegistro = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.TbcInfo.SuspendLayout();
            this.tbpDirección.SuspendLayout();
            this.tbpContactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbCUIT
            // 
            this.mtbCUIT.Location = new System.Drawing.Point(88, 14);
            this.mtbCUIT.Mask = "99 -99999999-9";
            this.mtbCUIT.Name = "mtbCUIT";
            this.mtbCUIT.Size = new System.Drawing.Size(83, 20);
            this.mtbCUIT.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(371, 365);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(278, 365);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // TbcInfo
            // 
            this.TbcInfo.Controls.Add(this.tbpDirección);
            this.TbcInfo.Controls.Add(this.tbpContactos);
            this.TbcInfo.Location = new System.Drawing.Point(24, 171);
            this.TbcInfo.Name = "TbcInfo";
            this.TbcInfo.SelectedIndex = 0;
            this.TbcInfo.Size = new System.Drawing.Size(426, 179);
            this.TbcInfo.TabIndex = 17;
            // 
            // tbpDirección
            // 
            this.tbpDirección.Controls.Add(this.txtNumero);
            this.tbpDirección.Controls.Add(this.lblNumero);
            this.tbpDirección.Controls.Add(this.txtBarrio);
            this.tbpDirección.Controls.Add(this.txtCalle);
            this.tbpDirección.Controls.Add(this.txtCiudad);
            this.tbpDirección.Controls.Add(this.lblCalle);
            this.tbpDirección.Controls.Add(this.lblBarrio);
            this.tbpDirección.Controls.Add(this.lblCiudad);
            this.tbpDirección.Location = new System.Drawing.Point(4, 22);
            this.tbpDirección.Name = "tbpDirección";
            this.tbpDirección.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDirección.Size = new System.Drawing.Size(418, 153);
            this.tbpDirección.TabIndex = 1;
            this.tbpDirección.Text = "Dirección";
            this.tbpDirección.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(80, 114);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(32, 20);
            this.txtNumero.TabIndex = 13;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 121);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Número";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(80, 48);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(183, 20);
            this.txtBarrio.TabIndex = 11;
            this.txtBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarrio_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(80, 81);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(183, 20);
            this.txtCalle.TabIndex = 10;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(80, 15);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(183, 20);
            this.txtCiudad.TabIndex = 9;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(6, 88);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 8;
            this.lblCalle.Text = "Calle";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(6, 55);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 7;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(6, 22);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 6;
            this.lblCiudad.Text = "Ciudad";
            // 
            // tbpContactos
            // 
            this.tbpContactos.Controls.Add(this.mtbTelefono);
            this.tbpContactos.Controls.Add(this.txtMail);
            this.tbpContactos.Controls.Add(this.lblTelefono);
            this.tbpContactos.Controls.Add(this.lblMail);
            this.tbpContactos.Location = new System.Drawing.Point(4, 22);
            this.tbpContactos.Name = "tbpContactos";
            this.tbpContactos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContactos.Size = new System.Drawing.Size(418, 153);
            this.tbpContactos.TabIndex = 2;
            this.tbpContactos.Text = "Contactos";
            this.tbpContactos.UseVisualStyleBackColor = true;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(162, 70);
            this.mtbTelefono.Mask = "000-000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(71, 20);
            this.mtbTelefono.TabIndex = 15;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(162, 33);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 16;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 73);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(150, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Ingrese su numero de telefono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(27, 40);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(101, 13);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Introduzca su email:";
            // 
            // pbxRegistro
            // 
            this.pbxRegistro.Location = new System.Drawing.Point(324, 15);
            this.pbxRegistro.Name = "pbxRegistro";
            this.pbxRegistro.Size = new System.Drawing.Size(122, 102);
            this.pbxRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegistro.TabIndex = 16;
            this.pbxRegistro.TabStop = false;
            this.pbxRegistro.Click += new System.EventHandler(this.pbxRegistro_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.CausesValidation = false;
            this.txtApellido.Location = new System.Drawing.Point(88, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(183, 20);
            this.txtApellido.TabIndex = 14;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 104);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(21, 22);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 11;
            this.lblCUIT.Text = "CUIT";
            // 
            // ofdImagen
            // 
            this.ofdImagen.FileName = "openFileDialog1";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 400);
            this.Controls.Add(this.mtbCUIT);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.TbcInfo);
            this.Controls.Add(this.pbxRegistro);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCUIT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.TbcInfo.ResumeLayout(false);
            this.tbpDirección.ResumeLayout(false);
            this.tbpDirección.PerformLayout();
            this.tbpContactos.ResumeLayout(false);
            this.tbpContactos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MaskedTextBox mtbCUIT;
        internal System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.Button btnVolver;
        internal System.Windows.Forms.TabControl TbcInfo;
        internal System.Windows.Forms.TabPage tbpDirección;
        internal System.Windows.Forms.TextBox txtNumero;
        internal System.Windows.Forms.Label lblNumero;
        internal System.Windows.Forms.TextBox txtBarrio;
        internal System.Windows.Forms.TextBox txtCalle;
        internal System.Windows.Forms.TextBox txtCiudad;
        internal System.Windows.Forms.Label lblCalle;
        internal System.Windows.Forms.Label lblBarrio;
        internal System.Windows.Forms.Label lblCiudad;
        internal System.Windows.Forms.TabPage tbpContactos;
        internal System.Windows.Forms.MaskedTextBox mtbTelefono;
        internal System.Windows.Forms.TextBox txtMail;
        internal System.Windows.Forms.Label lblTelefono;
        internal System.Windows.Forms.Label lblMail;
        internal System.Windows.Forms.PictureBox pbxRegistro;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.Label lblApellido;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
    }
}