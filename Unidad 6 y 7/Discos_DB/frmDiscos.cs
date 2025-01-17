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
    public partial class frmDiscos : Form
    {
        private List<Discos> listaDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void dgvDiscos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
        }

        private void cargar()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                listaDiscos = negocio.listar();
                dgvDiscos.DataSource = listaDiscos;
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                cargarImagen(listaDiscos[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen (string imagen)
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

        private void pbDiscos_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDiscos alta = new frmAltaDiscos();
            alta.ShowDialog();
            cargar();
        }
    }
}
