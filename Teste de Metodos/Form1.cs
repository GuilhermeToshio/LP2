using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/************************************************************************************************************************************
 
Exercício Teste de Metodos

Guilherme Toshio Iita
Fatec Sorocaba (01/03/21)

************************************************************************************************************************************/
namespace Teste_de_Metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrei no Copiar");
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrei no Colar");
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExecicio2 objfrm2 = new frmExecicio2();
            objfrm2.MdiParent = this; //"this" = componente atual
            objfrm2.WindowState = FormWindowState.Maximized;
            objfrm2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objfrm3 = new frmExercicio3();
            objfrm3.MdiParent = this; //"this" = componente atual
            objfrm3.WindowState = FormWindowState.Maximized;
            objfrm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 objfrm4 = new frmExercicio4();
            objfrm4.MdiParent = this; //"this" = componente atual
            objfrm4.WindowState = FormWindowState.Maximized;
            objfrm4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 objfrm5 = new frmExercicio5();
            objfrm5.MdiParent = this; //"this" = componente atual
            objfrm5.WindowState = FormWindowState.Maximized;
            objfrm5.Show();
        }
    }
}
