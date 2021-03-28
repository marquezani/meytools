using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            carregarDiretorio();

            limparMensagem();
        }

        private void btnLimparDiretorio_Click(object sender, EventArgs e)
        {
            string diretorio = string.IsNullOrEmpty(lblDiretorio.Text) ? "Diretório mão encontrado" : lblDiretorio.Text;

            try
            {
                if (Directory.Exists(diretorio))
                {
                    Directory.Delete(diretorio, true);
                }

                Directory.CreateDirectory(diretorio);

                lblMensagem.Text = "Diretório limpo";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao deletar diretorio";
            }            
        }

        public void carregarDiretorio()
        {
            string diretorio = @"C:\temp";
            lblDiretorio.Text = diretorio;
        }

        public void limparMensagem()
        {
            lblMensagem.Text = string.Empty;
        }
    }
}
