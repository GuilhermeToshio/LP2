using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Projeto
{
    public partial class Form1 : Form
    {
        double n1, n2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtn1.Text, out n1) || !double.TryParse(txtn2.Text, out n2))
                MessageBox.Show("Valores Inválidos");

            else
            {
                resultado = n1 - n2;
                txtresultado.Text = resultado.ToString("n2");
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtn1.Text, out n1) || !double.TryParse(txtn2.Text, out n2))
                MessageBox.Show("Valores Inválidos");

            else
            {
                resultado = n1 * n2;
                txtresultado.Text = resultado.ToString("n2");
            }
        }


        private void btnadd_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtn1.Text, out n1) || !double.TryParse(txtn2.Text, out n2))
                MessageBox.Show("Valores Inválidos");

            else
            {
                resultado = n1 + n2;
                txtresultado.Text = resultado.ToString("n2");
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtn1.Text, out n1) && double.TryParse(txtn2.Text, out n2))
                if (n2 == 0)
                {
                    MessageBox.Show("Divisor Inválido");
                }
                else
                {
                    resultado = n1 / n2;
                    txtresultado.Text = resultado.ToString("n2");
                }
        }
        private void btnclean_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtresultado.Clear();
            txtn1.Focus();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
