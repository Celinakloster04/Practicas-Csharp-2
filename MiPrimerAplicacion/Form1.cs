using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class MiPrimerAplicacion : Form
    {
        public MiPrimerAplicacion()
        {
            InitializeComponent();
        }

        private void MiPrimerAplicacion_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txbApellido.Text == "")
                txbApellido.BackColor = Color.Crimson;
            else
                txbApellido.BackColor = System.Drawing.SystemColors.Window;
            if (txbNombre.Text == "")
                txbNombre.BackColor = Color.Crimson;
            else
                txbNombre.BackColor = System.Drawing.SystemColors.Window;
            if (txbEdad.Text == "")
                txbEdad.BackColor = Color.Crimson;
            else
                txbEdad.BackColor = System.Drawing.SystemColors.Window;
            if (txbDireccion.Text == "")
                txbDireccion.BackColor = Color.Crimson;
            else
                txbDireccion.BackColor = System.Drawing.SystemColors.Window;

            if (txbApellido.BackColor != Color.Crimson && txbNombre.BackColor != Color.Crimson && txbEdad.BackColor != Color.Crimson && txbDireccion.BackColor != Color.Crimson)
            {
                string apellido = txbApellido.Text;
                string nombre = txbNombre.Text;
                string edad = txbEdad.Text;
                string direccion = txbDireccion.Text;

                txbResultado.Text = "Apellido y Nombre: " + apellido + " " + nombre + "\r\n" + "Edad: " + edad + "\r\n" + "Dirección: " + direccion; ;
            }
            else
                MessageBox.Show("Todos los campos deben ser llenados...");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
