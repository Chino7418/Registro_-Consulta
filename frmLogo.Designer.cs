namespace PryPedernera1P
{
    partial class frmLogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogo));
            this.pgbLogo = new System.Windows.Forms.ProgressBar();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tmrLogo = new System.Windows.Forms.Timer(this.components);
            this.pbxLogoIco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoIco)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbLogo
            // 
            this.pgbLogo.Location = new System.Drawing.Point(99, 304);
            this.pgbLogo.Name = "pgbLogo";
            this.pgbLogo.Size = new System.Drawing.Size(245, 23);
            this.pgbLogo.TabIndex = 0;
            this.pgbLogo.Click += new System.EventHandler(this.pgbLogo_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(217, 278);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(21, 13);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "0%";
            this.lblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tmrLogo
            // 
            this.tmrLogo.Enabled = true;
            this.tmrLogo.Tick += new System.EventHandler(this.tmrLogo_Tick);
            // 
            // pbxLogoIco
            // 
            this.pbxLogoIco.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoIco.Image")));
            this.pbxLogoIco.Location = new System.Drawing.Point(65, 12);
            this.pbxLogoIco.Name = "pbxLogoIco";
            this.pbxLogoIco.Size = new System.Drawing.Size(329, 249);
            this.pbxLogoIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoIco.TabIndex = 2;
            this.pbxLogoIco.TabStop = false;
            // 
            // frmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 389);
            this.Controls.Add(this.pbxLogoIco);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pgbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Integral";
            this.Load += new System.EventHandler(this.frmLogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Timer tmrLogo;
        private System.Windows.Forms.PictureBox pbxLogoIco;
    }
}