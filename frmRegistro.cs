using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PryPedernera1P;

namespace PryPedernera1P
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.MaxLength = 4;
        }

     

       
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos registrados", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Question);





            Datos registroDatos = new Datos();

            registroDatos.varCuit = mtbCUIT.Text.Trim();
            registroDatos.varNombre = txtNombre.Text.Trim();
            registroDatos.varApellido = txtApellido.Text.Trim();
            registroDatos.varCiudad = txtCiudad.Text.Trim();
            registroDatos.varBArrio = txtBarrio.Text.Trim();
            registroDatos.varCalle = txtCalle.Text.Trim();
            registroDatos.varNumero = txtNumero.Text.Trim();
            registroDatos.varMail = txtMail.Text.Trim();
            registroDatos.varTelefono = txtNumero.Text.Trim();

            {

                StreamWriter sw = File.AppendText("Registro.txt");

                sw.Write(registroDatos.varCuit + ",");
                sw.Write(registroDatos.varNombre + ",");
                sw.Write(registroDatos.varApellido + ",");
                sw.Write(registroDatos.varCiudad + ",");
                sw.Write(registroDatos.varBArrio + ",");
                sw.Write(registroDatos.varCalle + ",");
                sw.Write(registroDatos.varNumero + ",");
                sw.Write(registroDatos.varMail + ",");
                sw.WriteLine(registroDatos.varTelefono);

                sw.Close();
            }

                mtbCUIT.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCiudad.Text = "";
                txtBarrio.Text = "";
                txtCalle.Text = "";
                txtNumero.Text = "";
                txtMail.Text = "";
                mtbTelefono.Text = "";

                mtbCUIT.Focus();


        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void pbxRegistro_Click(object sender, EventArgs e)
        {
            ofdImagen.InitialDirectory = Application.StartupPath;
            ofdImagen.Filter = "Imagenes (*.jpg,*.gif)|*.jpg;*.gif";
           

            ofdImagen.ShowDialog();


            if (File.Exists(ofdImagen.FileName))
            {
                pbxRegistro.Image = Image.FromFile(ofdImagen.FileName);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
