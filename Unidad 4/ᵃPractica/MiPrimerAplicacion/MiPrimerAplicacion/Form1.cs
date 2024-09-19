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
    public partial class principal : Form
    {
        private object txtApellido;

        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Adios, gracias por tu visita.");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparó el evento Click", "Atención");
            this.BackColor = Color.LightYellow;
            //if (txtApellido.Text == "")
            //    txtApellido.BackColor = Color.Red;
            //else
            //    txtApellido.BackColor = SystemColors.Control;
        }

        private void principal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el boton izquierdo");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el boton derecho");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presionó el boton del Medio");
        }

        private void principal_MouseMove(object sender, MouseEventArgs e)
        {
            lbl.BackColor = Color.Cyan;
            lbl.Cursor = Cursors.Hand;
        }

        private void principal_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = System.Drawing.SystemColors.Control;
            lbl.Cursor = Cursors.Arrow;

        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            string txtApellido = tb.Text;
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <48 || e.KeyChar > 59)&&e.KeyChar !=8)
                e.Handled = true;
        }

        private void tb2_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Tiene" + txtNuevo.Text.Lenght + "caracteres");
        }
    }
}
