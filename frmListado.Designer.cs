namespace PryPedernera1P
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvDirreccion = new System.Windows.Forms.DataGridView();
            this.dgvCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIUDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.TabListar = new System.Windows.Forms.TabControl();
            this.tbpApellido = new System.Windows.Forms.TabPage();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbpDirección = new System.Windows.Forms.TabPage();
            this.txtDirecciòn = new System.Windows.Forms.TextBox();
            this.lblbarrio = new System.Windows.Forms.Label();
            this.dgvApellido = new System.Windows.Forms.DataGridView();
            this.Cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirreccion)).BeginInit();
            this.TabListar.SuspendLayout();
            this.tbpApellido.SuspendLayout();
            this.tbpDirección.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApellido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(886, 425);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvDirreccion
            // 
            this.dgvDirreccion.AllowUserToOrderColumns = true;
            this.dgvDirreccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirreccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCuil,
            this.dgvNombre,
            this.dvgApellido,
            this.CIUDAD,
            this.dgvBarrio,
            this.CALLE,
            this.NUMERO,
            this.MAIL,
            this.dvgTelefono});
            this.dgvDirreccion.Location = new System.Drawing.Point(23, 238);
            this.dgvDirreccion.Name = "dgvDirreccion";
            this.dgvDirreccion.Size = new System.Drawing.Size(938, 163);
            this.dgvDirreccion.TabIndex = 20;
            this.dgvDirreccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDirreccion_CellContentClick);
            // 
            // dgvCuil
            // 
            this.dgvCuil.HeaderText = "CUIL";
            this.dgvCuil.Name = "dgvCuil";
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "NOMBRE";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dvgApellido
            // 
            this.dvgApellido.HeaderText = "APELLIDO";
            this.dvgApellido.Name = "dvgApellido";
            // 
            // CIUDAD
            // 
            this.CIUDAD.HeaderText = "CIUDAD";
            this.CIUDAD.Name = "CIUDAD";
            // 
            // dgvBarrio
            // 
            this.dgvBarrio.HeaderText = "BARRIO";
            this.dgvBarrio.Name = "dgvBarrio";
            // 
            // CALLE
            // 
            this.CALLE.HeaderText = "CALLE";
            this.CALLE.Name = "CALLE";
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "NUMERO";
            this.NUMERO.Name = "NUMERO";
            // 
            // MAIL
            // 
            this.MAIL.HeaderText = "MAIL";
            this.MAIL.Name = "MAIL";
            // 
            // dvgTelefono
            // 
            this.dvgTelefono.HeaderText = "TELEFONO";
            this.dvgTelefono.Name = "dvgTelefono";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(734, 194);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 18;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // TabListar
            // 
            this.TabListar.Controls.Add(this.tbpApellido);
            this.TabListar.Controls.Add(this.tbpDirección);
            this.TabListar.Location = new System.Drawing.Point(205, 9);
            this.TabListar.Name = "TabListar";
            this.TabListar.SelectedIndex = 0;
            this.TabListar.Size = new System.Drawing.Size(608, 179);
            this.TabListar.TabIndex = 17;
            // 
            // tbpApellido
            // 
            this.tbpApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpApellido.Controls.Add(this.txtApellido);
            this.tbpApellido.Controls.Add(this.lblApellido);
            this.tbpApellido.Location = new System.Drawing.Point(4, 22);
            this.tbpApellido.Name = "tbpApellido";
            this.tbpApellido.Padding = new System.Windows.Forms.Padding(3);
            this.tbpApellido.Size = new System.Drawing.Size(600, 153);
            this.tbpApellido.TabIndex = 2;
            this.tbpApellido.Text = "Apellido";
            this.tbpApellido.UseVisualStyleBackColor = true;
            this.tbpApellido.Click += new System.EventHandler(this.tbpApellido_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(187, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(213, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(103, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido";
            // 
            // tbpDirección
            // 
            this.tbpDirección.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpDirección.Controls.Add(this.txtDirecciòn);
            this.tbpDirección.Controls.Add(this.lblbarrio);
            this.tbpDirección.Location = new System.Drawing.Point(4, 22);
            this.tbpDirección.Name = "tbpDirección";
            this.tbpDirección.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDirección.Size = new System.Drawing.Size(600, 153);
            this.tbpDirección.TabIndex = 1;
            this.tbpDirección.Text = "Dirección";
            this.tbpDirección.UseVisualStyleBackColor = true;
            // 
            // txtDirecciòn
            // 
            this.txtDirecciòn.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.txtDirecciòn.Location = new System.Drawing.Point(196, 52);
            this.txtDirecciòn.Name = "txtDirecciòn";
            this.txtDirecciòn.Size = new System.Drawing.Size(213, 20);
            this.txtDirecciòn.TabIndex = 13;
            // 
            // lblbarrio
            // 
            this.lblbarrio.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.lblbarrio.AutoSize = true;
            this.lblbarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarrio.Location = new System.Drawing.Point(85, 56);
            this.lblbarrio.Name = "lblbarrio";
            this.lblbarrio.Size = new System.Drawing.Size(91, 16);
            this.lblbarrio.TabIndex = 12;
            this.lblbarrio.Text = "Ingrese Barrio";
            // 
            // dgvApellido
            // 
            this.dgvApellido.AllowUserToOrderColumns = true;
            this.dgvApellido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApellido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuil,
            this.Nombre,
            this.ColApellido,
            this.ColCiudad,
            this.ColBarrio,
            this.ColCalle,
            this.ColNumero,
            this.ColMail,
            this.ColTelefono});
            this.dgvApellido.Location = new System.Drawing.Point(23, 238);
            this.dgvApellido.Name = "dgvApellido";
            this.dgvApellido.Size = new System.Drawing.Size(938, 163);
            this.dgvApellido.TabIndex = 22;
            // 
            // Cuil
            // 
            this.Cuil.HeaderText = "CUIL";
            this.Cuil.Name = "Cuil";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "APELLIDO";
            this.ColApellido.Name = "ColApellido";
            // 
            // ColCiudad
            // 
            this.ColCiudad.HeaderText = "CIUDAD";
            this.ColCiudad.Name = "ColCiudad";
            // 
            // ColBarrio
            // 
            this.ColBarrio.HeaderText = "BARRIO";
            this.ColBarrio.Name = "ColBarrio";
            // 
            // ColCalle
            // 
            this.ColCalle.HeaderText = "CALLE";
            this.ColCalle.Name = "ColCalle";
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "NUMERO";
            this.ColNumero.Name = "ColNumero";
            // 
            // ColMail
            // 
            this.ColMail.HeaderText = "MAIL";
            this.ColMail.Name = "ColMail";
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "TELEFONO";
            this.ColTelefono.Name = "ColTelefono";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.dgvApellido);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvDirreccion);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.TabListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirreccion)).EndInit();
            this.TabListar.ResumeLayout(false);
            this.tbpApellido.ResumeLayout(false);
            this.tbpApellido.PerformLayout();
            this.tbpDirección.ResumeLayout(false);
            this.tbpDirección.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApellido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnVolver;
        internal System.Windows.Forms.DataGridView dgvDirreccion;
        internal System.Windows.Forms.Button btnListar;
        internal System.Windows.Forms.TabControl TabListar;
        internal System.Windows.Forms.TabPage tbpApellido;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.Label lblApellido;
        internal System.Windows.Forms.TabPage tbpDirección;
        internal System.Windows.Forms.TextBox txtDirecciòn;
        internal System.Windows.Forms.Label lblbarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIUDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgTelefono;
        internal System.Windows.Forms.DataGridView dgvApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
    }
}