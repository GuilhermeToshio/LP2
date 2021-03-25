using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*******************************************************************************************************************************************
Guilherme Toshio Iita  
Fatec Sorocaba
24/03/21

Tem um erro na hora de converter os dados do Horista.cs pro Forms1.cs que eu n descobri oque é, me desculpe 


********************************************************************************************************************************************/ 
namespace Atividade_Horarios
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNomeEmpregado.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHora.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtEntradaEmpresa.Text);
            objHorista.DiasFaltas = Convert.ToInt32(txtDiasFaltas.Text);

            MessageBox.Show("Nome:" + objHorista.NomeEmpregado +
                "\n" + "Matricula:" + objHorista.Matricula + "\n" +
                "Tempo Trabalho:" + objHorista.TempoTrabalho().ToString()
                + "\n" + "Salario:" + objHorista.SalarioBruto().ToString("N2"));

        }
    }
}
