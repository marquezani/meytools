namespace MinhasAnotacoesSqlLite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAnotacoes = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblTotoalEncontrato = new System.Windows.Forms.Label();
            this.lblMostrarDados = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResultadoPesquisa = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAnotacoes);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 320);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // lstAnotacoes
            // 
            this.lstAnotacoes.FormattingEnabled = true;
            this.lstAnotacoes.Location = new System.Drawing.Point(6, 72);
            this.lstAnotacoes.Name = "lstAnotacoes";
            this.lstAnotacoes.Size = new System.Drawing.Size(523, 238);
            this.lstAnotacoes.TabIndex = 2;
            this.lstAnotacoes.SelectedIndexChanged += new System.EventHandler(this.lstAnotacoes_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(437, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(6, 33);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(425, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // lblTotoalEncontrato
            // 
            this.lblTotoalEncontrato.AutoSize = true;
            this.lblTotoalEncontrato.Location = new System.Drawing.Point(109, 345);
            this.lblTotoalEncontrato.Name = "lblTotoalEncontrato";
            this.lblTotoalEncontrato.Size = new System.Drawing.Size(99, 13);
            this.lblTotoalEncontrato.TabIndex = 6;
            this.lblTotoalEncontrato.Text = "lblTotoalEncontrato";
            // 
            // lblMostrarDados
            // 
            this.lblMostrarDados.AutoSize = true;
            this.lblMostrarDados.Location = new System.Drawing.Point(15, 371);
            this.lblMostrarDados.Name = "lblMostrarDados";
            this.lblMostrarDados.Size = new System.Drawing.Size(83, 13);
            this.lblMostrarDados.TabIndex = 7;
            this.lblMostrarDados.Text = "lblMostrarDados";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(15, 345);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total encontrato:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(562, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 312);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResultadoPesquisa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultado da Pesquisa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResultadoPesquisa
            // 
            this.txtResultadoPesquisa.Location = new System.Drawing.Point(6, 6);
            this.txtResultadoPesquisa.Multiline = true;
            this.txtResultadoPesquisa.Name = "txtResultadoPesquisa";
            this.txtResultadoPesquisa.ReadOnly = true;
            this.txtResultadoPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoPesquisa.Size = new System.Drawing.Size(380, 274);
            this.txtResultadoPesquisa.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtDescricao);
            this.tabPage2.Controls.Add(this.txtTitulo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnCadastrar);
            this.tabPage2.Controls.Add(this.txtTipo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(70, 75);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescricao.Size = new System.Drawing.Size(260, 145);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(70, 36);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(168, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Título";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(70, 238);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(260, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(258, 36);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(72, 20);
            this.txtTipo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMostrarDados);
            this.Controls.Add(this.lblTotoalEncontrato);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minhas Anotações";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ListBox lstAnotacoes;
        private System.Windows.Forms.Label lblTotoalEncontrato;
        private System.Windows.Forms.Label lblMostrarDados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtResultadoPesquisa;
    }
}

