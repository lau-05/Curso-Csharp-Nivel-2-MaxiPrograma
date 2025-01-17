using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Discos_DB
{ 
    public partial class frmAltaDiscos : Form
    {
        public frmAltaDiscos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Discos disco = new Discos();
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = txtFechaLanzamiento.Text;
                disco.CantidadCanciones = (int.Parse(txtCantidadCanciones.Text));
                disco.UrlImagenTapa = txtUrlmagenTapa.Text;
                disco.Estilo = (Estilos)cboEstilo.SelectedItem;
                disco.Edicion = (TiposEdicion)cboTipoEdicion.SelectedItem;

                negocio.agregar(disco);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblFechaLanzamiento_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaDiscos_Load(object sender, EventArgs e)
        {
            EstilosNegocio estiloNegocio = new EstilosNegocio();
            try
            {
                cboEstilo.DataSource = estiloNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            TiposEdicionNegocio edicionNegocio = new TiposEdicionNegocio();
            try
            {
                cboTipoEdicion.DataSource = edicionNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlmagenTapa_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlmagenTapa.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbDiscos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbDiscos.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
    }

}
