using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPedernera1P
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
        }

        private void personalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor frmEditor = new frmEditor();
            frmEditor.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            frmListado.Show();
        }

        private void tmrFyH_Tick(object sender, EventArgs e)
        {
            DateTime fecha;
            fecha = DateTime.Now;

            lblFecha.Text = "Fecha y Hora :" + fecha;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema creado por Alejandro Pedernera","Info del sistema",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
              ofd.InitialDirectory = Application.StartupPath;
            ofd.ShowDialog();

            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            this.Close();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogo frm = new frmLogo();
            frm.Close();
        ;
        }
    }
}
