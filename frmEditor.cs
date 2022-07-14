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

namespace PryPedernera1P
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txteditor.Text = "";
        }

        private void txteditor_TextChanged(object sender, EventArgs e)
        {
            string Caracter;
            int Conteo;
            
            Caracter = txteditor.Text;
            Conteo = Caracter.Length;

            lblCantCaracteres.Text = "Cantidad de caracteres :" + Conteo;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            StreamWriter Archivo = File.AppendText("Nuevo.Secreto");
            Archivo.Close();

            MessageBox.Show("Archivo creado con exito", "Confirmación",MessageBoxButtons.OK);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string varpalabra;
            varpalabra = txtBuscar.Text;

            if (txteditor.Text.Contains(txtBuscar.Text))

            {
                MessageBox.Show(varpalabra + " Si se encuentra en el documento!", "Palabra existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            
            varpalabra = txtBuscar.Text;

            MessageBox.Show(varpalabra + " No se encuentra en el documento!", "Palabra no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificar;
            string modificada;

            modificar = txtBuscar.Text;
            modificada = txtModificar.Text;

            if (txteditor.Text.Contains(txtBuscar.Text))


            {
                txteditor.Text = txteditor.Text.Replace(txtBuscar.Text, txtModificar.Text);

                MessageBox.Show("La palabra " + modificar + " se ha modificado a " + modificada + " con exito!", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
           

       
        }

        private void btnCaracter_Click(object sender, EventArgs e)
        {
            String vacio = "";
            txteditor.Text = txteditor.Text.Replace(txtQuitar.Text, vacio);
            MessageBox.Show("Se eliminaron todos los caracteres: " + txteditor.Text, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtQuitar.Text = "";

        }

        private void btnEspacios_Click(object sender, EventArgs e)
        {
            String vacio = "";
            txteditor.Text = txteditor.Text.Replace(" ", vacio);
            MessageBox.Show("Se eliminaron todos los espacios", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter Sw = File.AppendText("Nuevo.Secreto");
            Sw.WriteLine(txteditor.Text);
            Sw.Close();
        }
    }

}
