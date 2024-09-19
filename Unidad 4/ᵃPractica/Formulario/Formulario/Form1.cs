using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {
        }
        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static object GetDebuggerDisplay()
        {
            throw new NotImplementedException();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Reiniciar colores de fondo a blanco
            tbApellido.BackColor = Color.White;
            tbNombre.BackColor = Color.White;
            tbEdad.BackColor = Color.White;
            tbDireccion.BackColor = Color.White;

            bool datosValidos = true;

            //Validar Campos
            if (string.IsNullOrWhiteSpace(tbApellido.Text))
            {
                tbApellido.BackColor = Color.Red;
                datosValidos |= false;
            }
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                tbNombre.BackColor = Color.Red;
                datosValidos |= false;
            }
            if (string.IsNullOrWhiteSpace(tbEdad.Text))
            {
                tbEdad.BackColor = Color.Red;
                datosValidos |= false;
            }
            if (string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                tbDireccion.BackColor = Color.Red;
                datosValidos |= false;
            }
            if (datosValidos)
            {
                tbResultado.Text = $"Apellido y Nombre: {tbApellido.Text.ToUpper()} {tbNombre.Text.ToUpper()}\r\n" +
                                    $"Edad: {tbEdad.Text}\r\n" +
                                    $"Dirección: {tbDireccion.Text.ToUpper()}";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
        