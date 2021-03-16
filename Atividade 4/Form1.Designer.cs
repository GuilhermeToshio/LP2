
namespace Atividade_4
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNumeroFilhos = new System.Windows.Forms.MaskedTextBox();
            this.lblResultadoNome = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(224, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(224, 412);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(187, 20);
            this.txtAliquotaINSS.TabIndex = 3;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(224, 568);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(187, 20);
            this.txtSalarioLiquido.TabIndex = 6;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(224, 515);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(187, 20);
            this.txtSalarioFamilia.TabIndex = 5;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(224, 463);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(187, 20);
            this.txtAliquotaIRPF.TabIndex = 4;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Location = new System.Drawing.Point(723, 463);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(187, 20);
            this.txtDescontoIRPF.TabIndex = 8;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(723, 410);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(187, 20);
            this.txtDescontoINSS.TabIndex = 7;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(197, 213);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(235, 43);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(110, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(151, 115);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalarioBruto.TabIndex = 12;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.Location = new System.Drawing.Point(129, 168);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblNumeroFilhos.TabIndex = 13;
            this.lblNumeroFilhos.Text = "Numero de Filhos";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(145, 415);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(73, 13);
            this.lblAliquotaINSS.TabIndex = 14;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(146, 466);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(72, 13);
            this.lblAliquotaIRPF.TabIndex = 15;
            this.lblAliquotaIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(142, 518);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioFamilia.TabIndex = 16;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(142, 571);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioLiquido.TabIndex = 17;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(636, 415);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 18;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(636, 466);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 19;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(77, 53);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 20;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(77, 106);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 21;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(77, 56);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(74, 17);
            this.ckbxCasado.TabIndex = 22;
            this.ckbxCasado.Text = "Casado(a)";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFeminino);
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Location = new System.Drawing.Point(602, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 196);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbxCasado);
            this.groupBox2.Location = new System.Drawing.Point(602, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 122);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(224, 112);
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(187, 20);
            this.mskbxSalarioBruto.TabIndex = 25;
            // 
            // mskbxNumeroFilhos
            // 
            this.mskbxNumeroFilhos.Location = new System.Drawing.Point(224, 165);
            this.mskbxNumeroFilhos.Name = "mskbxNumeroFilhos";
            this.mskbxNumeroFilhos.Size = new System.Drawing.Size(187, 20);
            this.mskbxNumeroFilhos.TabIndex = 26;
            // 
            // lblResultadoNome
            // 
            this.lblResultadoNome.AutoSize = true;
            this.lblResultadoNome.Location = new System.Drawing.Point(129, 272);
            this.lblResultadoNome.Name = "lblResultadoNome";
            this.lblResultadoNome.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoNome.TabIndex = 27;
            this.lblResultadoNome.Text = "label1";
            this.lblResultadoNome.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(472, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 708);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResultadoNome);
            this.Controls.Add(this.mskbxNumeroFilhos);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.txtNome);
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskbxNumeroFilhos;
        private System.Windows.Forms.Label lblResultadoNome;
        private System.Windows.Forms.Button btnClear;
    }
}

