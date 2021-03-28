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

namespace MinhasAnotacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pesquisaDiretorio();
        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            listarArquivos(txtPesquisa.Text);
        }

        private void lstbArquivo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string itemSelecionado = lstbArquivo.SelectedItem.ToString();
            var dir = diretorio();
            string abrirArquivo = dir.ToString() + itemSelecionado;

            System.Diagnostics.Process.Start(abrirArquivo.Replace(@"\\", @"\").Trim());
        }

        public void listarArquivos(string textoPesquisa)
        {
            int count = 0;

            lstbArquivo.Items.Clear();

            DirectoryInfo dir = diretorio();
            FileInfo[] files = dir.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo file in files)
            {
                if (file.Name.Contains(textoPesquisa))
                {
                    lstbArquivo.Items.Add(file.Name);

                    count++;
                }                
            }

            if (lstbArquivo.Items.Count == 0)
            {
                lblTotalRegistro.Text = "0";

                MessageBox.Show($"Nenhum arquivo encotrando com este nome: {textoPesquisa}");                
            }

            lblTotalRegistro.Text = count.ToString();
        }

        public DirectoryInfo diretorio()
        {
            return new DirectoryInfo(@"C:\anotacoes\txt\");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var dir = diretorio();

            string titulo = txtTitulo.Text.ToLower();
            string tipo = txtTipo.Text;
            string nomeArquivo = dir.ToString() + tipo + " - " + titulo + ".txt";

            if (File.Exists(nomeArquivo))
            {
                MessageBox.Show("Já existe um arqruivo criado com mesmo nome!");
            }
            else
            {
                File.Create(titulo).Close();

                TextWriter arquivo = File.AppendText(nomeArquivo);
                arquivo.WriteLine(txtTexto.Text);
                arquivo.Close();

                limpaCampo();

                MessageBox.Show("Anotação cadastrada!");
            }            
        }        

        public void limpaCampo()
        {
            txtTexto.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtTipo.Text = string.Empty;
            lblTotalRegistro.Text = string.Empty;
        }

        public void pesquisaDiretorio()
        {
            var dir = diretorio();
            lblLocalPasta.Text = dir.ToString();
        }
    }
}
