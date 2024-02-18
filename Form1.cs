using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class lbl_x2 : Form
    {
        private double disc;

        public lbl_x2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Ecuacion_Click(object sender, EventArgs e)
        {

        }

        private void Btn_resolver_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2;
            // Validar la entrada para a
            if (!double.TryParse(tbx_a.Text, out a))
            {
                MessageBox.Show("Ingrese un valor numérico para a", "Error");
                tbx_a.Focus();
                return;
            }
            // Validar la entrada para b
            if (!double.TryParse(tbx_b.Text, out b))
            {
                MessageBox.Show("Ingrese un valor numérico para b", "Error");
                tbx_b.Focus();
                return;
            }
            // Validar la entrada para c
            if (!double.TryParse(tbx_c.Text, out c))
            {
                MessageBox.Show("Ingrese un valor numérico para c", "Error");
                tbx_c.Focus();
                return;
            }
            // Calcular el discriminante
            double discriminante = Math.Pow(b, 2) - 4 * a * c;
            // Calcular las raíces de la ecuación cuadrática
            if (discriminante > 0)
            {
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                lbl_1.Text = "x1 = " + x1.ToString();
                lbl_2.Text = "x2 = " + x2.ToString();
                
 }
            else if (discriminante == 0)
            {
                x1 = -b / (2 * a);
                lbl_1.Text = "x1 = x2 = " + x1.ToString();
                lbl_2.Text = "";
            }
            else
            {
                // Calcular la parte real e imaginaria de las raíces complejas
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                lbl_1.Text = "x1 = " + parteReal.ToString("F2") + " + " +
               parteImaginaria.ToString("F2") + "i";
                lbl_2.Text = "x2 = " + parteReal.ToString("F2") + " - " +
               parteImaginaria.ToString("F2") + "i";
            }
            lbl_a.Text = Convert.ToString(a);
            lbl_b.Text = Convert.ToString(b);
            lbl_c.Text = Convert.ToString(c);
        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbx_a_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
