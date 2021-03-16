using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lblResultadoNome.Visible = true;

            double salariobruto = 0;

            if ((txtNome.Text == "") || (txtNome.Text.Length < 5))
                MessageBox.Show("Nome Inválido");
            else if (!double.TryParse(mskbxSalarioBruto.Text, out salariobruto))
                MessageBox.Show("Salário Inválido");

            else
            {
                double descontoinss = 0;
                double descontoirpf = 0;
                double salariofamilia = 0;
                double salarioliquido = 0;
                int numerofilhos = 0;
                double numerosalariofamilia = 0;
                string textnome = "Os descontos do salário";
                
                //
                // Cálculo Desconto INSS ----------------------------------------------------------------------
                //
                if (salariobruto <= 800.47)
                {
                    txtAliquotaINSS.Text = "7.65%";
                    descontoinss = 0.0765 * salariobruto;
                }
                else if (salariobruto <= 1050)
                {
                    txtAliquotaINSS.Text = "8.65%";
                    descontoinss = 0.0865 * salariobruto;
                }
                else if (salariobruto <= 1400.77)
                {
                    txtAliquotaINSS.Text = "9.00%";
                    descontoinss = 0.09 * salariobruto;
                }
                else if (salariobruto <= 2801.56)
                {
                    txtAliquotaINSS.Text = "11.00%";
                    descontoinss = 0.011 * salariobruto;
                }
                else
                {
                    txtAliquotaINSS.Text = "Teto (308.17)";
                    descontoinss = 308.17;
                }
                txtDescontoINSS.Text = descontoinss.ToString("N2");
                //
                //Cálculo Desconto IRPF -----------------------------------------------------------------------
                //
                if (salariobruto <= 1257.12)
                {
                    txtAliquotaIRPF.Text = "0%";
                    descontoirpf = 0;
                }
                else if (salariobruto <= 2512.08)
                {
                    txtAliquotaIRPF.Text = "15.00%";
                    descontoirpf = 0.015 * salariobruto;
                }
                else
                {
                    txtAliquotaIRPF.Text = "27.50%";
                    descontoirpf = 0.0275 * salariobruto;
                }
                txtDescontoIRPF.Text = descontoirpf.ToString("N2");
                //
                //Calculo Salário Família ---------------------------------------------------------------------
                //
                if (!int.TryParse(mskbxNumeroFilhos.Text, out numerofilhos))
                {
                    MessageBox.Show("Valor Inválido");
                }
                else if (salariobruto <= 435.52)
                {
                    numerosalariofamilia = 22.33;
                    salariofamilia = numerosalariofamilia * numerofilhos;
                    txtSalarioFamilia.Text = salariofamilia.ToString("N2");

                }
                else if (salariobruto <= 654.61)
                {
                    numerosalariofamilia = 15.74;
                    salariofamilia = numerosalariofamilia * numerofilhos;
                    txtSalarioFamilia.Text = salariofamilia.ToString("N2");
                }
                else
                {
                    txtSalarioFamilia.Text = "0";
                }
                //
                // Salário Liquido ----------------------------------------------------------------------------
                //
                salarioliquido = salariobruto - descontoinss - descontoirpf + salariofamilia;
                txtSalarioLiquido.Text = salarioliquido.ToString("N2");
                //
                // Texto --------------------------------------------------------------------------------------
                //
                if (rbtnFeminino.Checked)
                {
                    textnome = textnome + " da sra." + txtNome.Text;
                }
                else
                {
                    textnome = textnome + " do sr." + txtNome.Text;
                }
                if (ckbxCasado.Checked)
                {
                    textnome = textnome + " que é casado(a)";
                    textnome = textnome + " e tem " + numerofilhos + " filho(s)";
                }
                else
                {
                    textnome = textnome + " que é solteiro(a)";
                    textnome = textnome + " e tem " + numerofilhos + " filho(s)";
                }
                lblResultadoNome.Text = textnome;
                //
                // --------------------------------------------------------------------------------------------
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAliquotaINSS.Clear();
            txtAliquotaIRPF.Clear();
            txtDescontoINSS.Clear();
            txtDescontoIRPF.Clear();
            txtSalarioFamilia.Clear();
            txtSalarioLiquido.Clear();
            mskbxNumeroFilhos.Clear();
            mskbxSalarioBruto.Clear();
            lblResultadoNome.Text = "";
            txtNome.Clear();
            txtNome.Focus();
        }
    }
}
