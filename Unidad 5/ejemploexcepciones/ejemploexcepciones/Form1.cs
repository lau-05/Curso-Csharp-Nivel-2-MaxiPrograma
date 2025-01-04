using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploexcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
            resultado = calcular();
            labelResultado.Text = "= " + resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //FINALLY
            finally 
             { 
                //instrucciones...
                //operacion sensible......
            }
        }
        //THROW
        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(textBoxnum1.Text);
                b = int.Parse(textBoxnum2.Text);
                r = a + b;
                labelResultado.Text = "= " + r;
                return r;
            }
            catch (FormatException ex)
            {
                //guardar registro de error en archivo...
                throw ex;
            }
        }
    }
}
