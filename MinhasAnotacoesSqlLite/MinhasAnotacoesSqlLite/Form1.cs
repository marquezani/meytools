using MinhasAnotacoesSqlLite.Classe;
using MinhasAnotacoesSqlLite.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MinhasAnotacoesSqlLite
{
    public partial class Form1 : Form
    {
        private AnotacoesService anotacoesService;

        public Form1()
        {
            if (anotacoesService == null)
                anotacoesService = new AnotacoesService();

            InitializeComponent();

            limpar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //lstAnotacoes.ClearSelected();
            limpar();

            var anotacoes = new Anotacoes()
            {
                Titulo = txtPesquisar.Text
            };

            var dt = anotacoesService.obterAnotacoes(anotacoes, null);

            if (dt == null)
            {
                return;
            }

            lblTotoalEncontrato.Text = $"{dt.Rows.Count}";

            var lst = new List<Anotacoes>();
            foreach (DataRow r in dt.Rows)
            {
                lst.Add(new Anotacoes() { Id = Convert.ToInt32(r["Id"].ToString()), Titulo = r["Titulo"].ToString(), Tipo = r["Tipo"].ToString(), Descricao = r["Descricao"].ToString() });
            }

            lstAnotacoes.SelectionMode = SelectionMode.None;
            lstAnotacoes.DataSource = lst;
            lstAnotacoes.DisplayMember = "Titulo";
            lstAnotacoes.ValueMember = "ID";
            lstAnotacoes.ClearSelected();
            lstAnotacoes.SelectionMode = SelectionMode.One;
        }

        public void limpar()
        {
            lblTotoalEncontrato.Text = string.Empty;
            txtResultadoPesquisa.Text = string.Empty;
        }

        private void lstAnotacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string itemSelecionado = lstAnotacoes.SelectedValue.ToString();

                var dt = anotacoesService.obterAnotacoes(null, itemSelecionado);

                if (dt.Rows.Count == 0)
                {
                    return;
                }

                txtResultadoPesquisa.Text = dt.Rows[0]["Descricao"].ToString();
            }
            catch (Exception ex)
            {

            }            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var anotacoes = new Anotacoes()
            {
                Titulo = txtTitulo.Text,
                Tipo = txtTitulo.Text,
                Descricao = txtDescricao.Text
            };

            bool isCadasrto = anotacoesService.cadastrarAnotacoes(anotacoes);
            if (isCadasrto)
            {
                MessageBox.Show($"Anotação cadastrada!");

                limparCamposCadastro();

                return;
            }

            MessageBox.Show($"Erro ao cadastrar a anotação!");
        }

        public void limparCamposCadastro()
        {
            txtTitulo.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }
    }
}
