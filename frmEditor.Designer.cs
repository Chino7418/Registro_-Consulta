namespace PryPedernera1P
{
    partial class frmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCantCaracteres = new System.Windows.Forms.Label();
            this.gpbHerramientas = new System.Windows.Forms.GroupBox();
            this.btnEspacios = new System.Windows.Forms.Button();
            this.btnCaracter = new System.Windows.Forms.Button();
            this.txtQuitar = new System.Windows.Forms.TextBox();
            this.lblQuitar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txteditor = new System.Windows.Forms.TextBox();
            this.gpbHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(480, 413);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCantCaracteres
            // 
            this.lblCantCaracteres.AutoSize = true;
            this.lblCantCaracteres.Location = new System.Drawing.Point(19, 418);
            this.lblCantCaracteres.Name = "lblCantCaracteres";
            this.lblCantCaracteres.Size = new System.Drawing.Size(130, 13);
            this.lblCantCaracteres.TabIndex = 12;
            this.lblCantCaracteres.Text = "Cantidad de Caracteres : -";
            // 
            // gpbHerramientas
            // 
            this.gpbHerramientas.Controls.Add(this.btnEspacios);
            this.gpbHerramientas.Controls.Add(this.btnCaracter);
            this.gpbHerramientas.Controls.Add(this.txtQuitar);
            this.gpbHerramientas.Controls.Add(this.lblQuitar);
            this.gpbHerramientas.Controls.Add(this.btnModificar);
            this.gpbHerramientas.Controls.Add(this.btnBuscar);
            this.gpbHerramientas.Controls.Add(this.txtModificar);
            this.gpbHerramientas.Controls.Add(this.txtBuscar);
            this.gpbHerramientas.Controls.Add(this.lblModificar);
            this.gpbHerramientas.Controls.Add(this.lblBuscar);
            this.gpbHerramientas.Location = new System.Drawing.Point(12, 303);
            this.gpbHerramientas.Name = "gpbHerramientas";
            this.gpbHerramientas.Size = new System.Drawing.Size(549, 100);
            this.gpbHerramientas.TabIndex = 11;
            this.gpbHerramientas.TabStop = false;
            this.gpbHerramientas.Text = "Herramientas";
            // 
            // btnEspacios
            // 
            this.btnEspacios.Location = new System.Drawing.Point(468, 52);
            this.btnEspacios.Name = "btnEspacios";
            this.btnEspacios.Size = new System.Drawing.Size(75, 23);
            this.btnEspacios.TabIndex = 9;
            this.btnEspacios.Text = "Espacios";
            this.btnEspacios.UseVisualStyleBackColor = true;
            this.btnEspacios.Click += new System.EventHandler(this.btnEspacios_Click);
            // 
            // btnCaracter
            // 
            this.btnCaracter.Location = new System.Drawing.Point(468, 23);
            this.btnCaracter.Name = "btnCaracter";
            this.btnCaracter.Size = new System.Drawing.Size(75, 23);
            this.btnCaracter.TabIndex = 8;
            this.btnCaracter.Text = "Caracter";
            this.btnCaracter.UseVisualStyleBackColor = true;
            this.btnCaracter.Click += new System.EventHandler(this.btnCaracter_Click);
            // 
            // txtQuitar
            // 
            this.txtQuitar.Location = new System.Drawing.Point(382, 36);
            this.txtQuitar.Name = "txtQuitar";
            this.txtQuitar.Size = new System.Drawing.Size(46, 20);
            this.txtQuitar.TabIndex = 7;
            // 
            // lblQuitar
            // 
            this.lblQuitar.AutoSize = true;
            this.lblQuitar.Location = new System.Drawing.Point(379, 13);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(35, 13);
            this.lblQuitar.TabIndex = 6;
            this.lblQuitar.Text = "Quitar";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(258, 64);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(258, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(86, 64);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(166, 20);
            this.txtModificar.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(86, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(166, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Location = new System.Drawing.Point(7, 71);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(50, 13);
            this.lblModificar.TabIndex = 1;
            this.lblModificar.Text = "Modificar";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(7, 33);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(399, 243);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(480, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(318, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txteditor
            // 
            this.txteditor.Location = new System.Drawing.Point(12, 12);
            this.txteditor.Multiline = true;
            this.txteditor.Name = "txteditor";
            this.txteditor.Size = new System.Drawing.Size(549, 205);
            this.txteditor.TabIndex = 7;
            this.txteditor.TextChanged += new System.EventHandler(this.txteditor_TextChanged);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCantCaracteres);
            this.Controls.Add(this.gpbHerramientas);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txteditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de texto";
            this.gpbHerramientas.ResumeLayout(false);
            this.gpbHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnVolver;
        internal System.Windows.Forms.Label lblCantCaracteres;
        internal System.Windows.Forms.GroupBox gpbHerramientas;
        internal System.Windows.Forms.Button btnEspacios;
        internal System.Windows.Forms.Button btnCaracter;
        internal System.Windows.Forms.TextBox txtQuitar;
        internal System.Windows.Forms.Label lblQuitar;
        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.TextBox txtModificar;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.Label lblModificar;
        internal System.Windows.Forms.Label lblBuscar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.TextBox txteditor;
    }
}