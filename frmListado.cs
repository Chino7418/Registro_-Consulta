using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PryPedernera1P;
using System.IO;

namespace PryPedernera1P
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        private void dgvDirreccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            StreamReader archivo;
            archivo = File.OpenText("Registro.txt");
            String[] vecDatos = new String[9];
            string lineas;
            lineas = archivo.ReadLine();
            lineas.Trim();
            dgvDirreccion.Rows.Clear();
            dgvApellido.Rows.Clear();
            dgvDirreccion.Rows.Clear();
            txtApellido.Select();




            string apellido = txtApellido.Text;
            string direccion = txtDirecciòn.Text;

            //mientras hayan datos
            if (apellido != "" )
            {
                txtApellido.Text = "";
                txtApellido.Focus();

                while (!archivo.EndOfStream)
                {
                    string flecha = archivo.ReadLine();
                    //cargo en el vector los datos de la linea que estoy leyendo, por cada , un espacio en el vector
                    vecDatos = flecha.Split(',');

                    if (vecDatos[2].Contains(apellido))
                    {
                        dgvApellido.Visible = true;
                        dgvDirreccion.Visible =false;
                        dgvApellido.Rows.Add(vecDatos);
                    }

                    vecDatos = null;

                }
            }
           

               

            if ( direccion != "")

               
            {
                while (!archivo.EndOfStream)
                {
                    string flecha = archivo.ReadLine();
                    //cargo en el vector los datos de la linea que estoy leyendo, por cada , un espacio en el vector
                    vecDatos = flecha.Split(',');

                    if (vecDatos[4].Contains(direccion))
                    {
                        dgvApellido.Visible = false;
                        dgvDirreccion.Visible = true;
                        dgvDirreccion.Rows.Add(vecDatos);
                    }
                   


                }
            }
            archivo.Close();
        }

        private void tbpApellido_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }
    }

      
    }

