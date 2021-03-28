namespace Ferramentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparDiretorio = new System.Windows.Forms.Button();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMensagem);
            this.groupBox1.Controls.Add(this.btnLimparDiretorio);
            this.groupBox1.Controls.Add(this.lblDiretorio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diretório";
            // 
            // btnLimparDiretorio
            // 
            this.btnLimparDiretorio.Location = new System.Drawing.Point(9, 61);
            this.btnLimparDiretorio.Name = "btnLimparDiretorio";
            this.btnLimparDiretorio.Size = new System.Drawing.Size(99, 23);
            this.btnLimparDiretorio.TabIndex = 2;
            this.btnLimparDiretorio.Text = "Limpar Diretório";
            this.btnLimparDiretorio.UseVisualStyleBackColor = true;
            this.btnLimparDiretorio.Click += new System.EventHandler(this.btnLimparDiretorio_Click);
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Location = new System.Drawing.Point(6, 31);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(56, 13);
            this.lblDiretorio.TabIndex = 1;
            this.lblDiretorio.Text = "lblDiretorio";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(6, 107);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(69, 13);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "lblMensagem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 171);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Limpar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimparDiretorio;
        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.Label lblMensagem;
    }
}

