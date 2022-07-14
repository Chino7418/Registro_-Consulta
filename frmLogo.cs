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
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pgbLogo_Click(object sender, EventArgs e)
        {

        }

        private void tmrLogo_Tick(object sender, EventArgs e)
        {
            {
                pgbLogo.Increment(3);
                lblLogo.Text = pgbLogo.Value.ToString() + "%";

                if (pgbLogo.Value == pgbLogo.Maximum)
                {
                    tmrLogo.Stop();
                    this.Hide();
                    frmPrincipal frmPrincipal = new frmPrincipal();
                        frmPrincipal.ShowDialog();
                   
                }
            }

        }

        private void frmLogo_Load(object sender, EventArgs e)
        {

        }
    }
}
