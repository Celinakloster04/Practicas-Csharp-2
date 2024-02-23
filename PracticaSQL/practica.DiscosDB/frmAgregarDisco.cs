using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica.DiscosDB
{
    public partial class frmAgregarDisco : Form
    {
        private Discos disco = null;
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        public frmAgregarDisco(Discos disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (disco == null)
                    disco = new Discos();

                disco.Artista = tbxArtista.Text;
                disco.Titulo = tbxTitulo.Text;
                disco.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Text);
                disco.CantidadCanciones = int.Parse(tbxCantidadCanciones.Text);
                disco.UrlImagenTapa = tbxUrlImagenTapa.Text;
                disco.Estilo = (Estilos)cboEstilo.SelectedItem;
                disco.Edicion = (Edicion)cboEdicion.SelectedItem;

                if(disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");
                } 
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {
            EstilosNegocio estilosNegocio = new EstilosNegocio();
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            try
            {
                cboEstilo.DataSource = estilosNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboEdicion.DataSource = edicionNegocio.listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";

                if(disco != null)
                {
                    tbxArtista.Text = disco.Artista;
                    tbxTitulo.Text = disco.Titulo;
                    dtpFechaLanzamiento.Value = disco.FechaLanzamiento;
                    tbxCantidadCanciones.Text = disco.CantidadCanciones.ToString();
                    tbxUrlImagenTapa.Text = disco.UrlImagenTapa;
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                    cboEdicion.SelectedValue = disco.Edicion.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenDisco.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenDisco.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void tbxUrlImagenTapa_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagenTapa.Text);
        }
    }
}
