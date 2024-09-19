using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploWinFormsDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn1Fecha_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dtpFecha.Value;
            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("f"));
        }

        private void btn2Fecha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + calFecha.SelectionStart.ToString("f"));

        }
    }
}
