
namespace Primeiro_Projeto
{
    partial class Form1
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(150, 679);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(240, 62);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(396, 679);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(240, 62);
            this.btnsub.TabIndex = 1;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(642, 679);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(240, 62);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(888, 679);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(240, 62);
            this.btnmulti.TabIndex = 3;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(888, 412);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(240, 62);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Sair";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(888, 279);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(240, 62);
            this.btnclean.TabIndex = 5;
            this.btnclean.Text = "Limpar";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(396, 203);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(240, 20);
            this.txtn1.TabIndex = 6;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(396, 362);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(240, 20);
            this.txtn2.TabIndex = 7;
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(396, 519);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(240, 20);
            this.txtresultado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 870);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

