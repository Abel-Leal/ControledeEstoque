using ControledeEstoqueWPF.DAL;
using ControledeEstoqueWPF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControledeEstoqueWPF.Views
{
    /// <summary>
    /// Lógica interna para frmVerificarStatusEstoque.xaml
    /// </summary>
    public partial class frmVerificarStatusEstoque : Window
    {
        private EntradaProdutoEstoque entradaProdutoEstoque = new EntradaProdutoEstoque();
        private Saida saidaEstoque = new Saida();
        private List<dynamic> entradaProdutos = new List<dynamic>();
        private List<dynamic> saidaProdutos = new List<dynamic>();
        private List<dynamic> solicitacaoProdutos = new List<dynamic>();
        private List<dynamic> consultasStatusEstoque = new List<dynamic>();
        public frmVerificarStatusEstoque()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboEntradadeProdutos.ItemsSource = ProdutoDAO.Listar();
            cboEntradadeProdutos.DisplayMemberPath = "Nome";
            cboEntradadeProdutos.SelectedValuePath = "Id";

            cboSaidadeEstoque.ItemsSource = ProdutoDAO.Listar();
            cboSaidadeEstoque.DisplayMemberPath = "Nome";
            cboSaidadeEstoque.SelectedValuePath = "Id";

            cboSolicitacoes.ItemsSource = SolicitacaoDAO.Listar();
            cboSolicitacoes.DisplayMemberPath = "Id";
            cboSolicitacoes.SelectedValuePath = "Id";

            cboStatusEstoqueGeral.ItemsSource = StatusEstoqueDAO.Listar();
            cboStatusEstoqueGeral.DisplayMemberPath = "Produto";
            cboStatusEstoqueGeral.SelectedValuePath = "Id";

        }

        private void btnConsultarEntradaEstoque_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboEntradadeProdutos.SelectedValue;
            Produto produto = ProdutoDAO.BuscaPorId(id);
            PopularEntradasEstoque(produto);
            PopularDataGridEntradaProdutos(produto);
            dtaEntradaProdutosEstoque.ItemsSource = entradaProdutos;
            dtaEntradaProdutosEstoque.Items.Refresh();


        }

        private void btnVerificarSaidaEstoque_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboSaidadeEstoque.SelectedValue;
            Produto produto = ProdutoDAO.BuscaPorId(id);
            PopularSaidasEstoque(produto);
            PopularDataGridSaidaProdutos(produto);
            dtaSaidaProdutosEstoque.ItemsSource = saidaProdutos;
            dtaSaidaProdutosEstoque.Items.Refresh();
        }

        private void btnListarSolicitacoes_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboSolicitacoes.SelectedValue;
            Solicitacao solicitacao = SolicitacaoDAO.BuscaPorId(id);
            PopularDataGridSolicitacoes(solicitacao);
            dtaSolicitcoesProdutos.ItemsSource = solicitacaoProdutos;
            dtaSolicitcoesProdutos.Items.Refresh();
        }

        private void btnAnalisarEstoque_Click(object sender, RoutedEventArgs e)
        {
            Produto produto= (Produto)cboStatusEstoqueGeral.SelectedValue;
            StatusEstoque statusEstoque = StatusEstoqueDAO.BuscaPorId(produto);
            PopularDataGridConsultasStatusEstoque(statusEstoque);
            dtaStatusEstoqueGeral.ItemsSource = consultasStatusEstoque;
            dtaStatusEstoqueGeral.Items.Refresh();
        }

        private void PopularDataGridEntradaProdutos(Produto produto)
        {
            entradaProdutos.Add(new
            {
                Nome = produto.Nome,
                Tipo = produto.Tipo,
                QtdeProdutoEntrada = entradaProdutoEstoque.QtdeProdutoEntrada,
                EspacoDisponivel = entradaProdutoEstoque.EspaçoDisponívelEstoque


            });
        }

        private void PopularDataGridSaidaProdutos(Produto produto)
        {
            saidaProdutos.Add(new
            {
                Nome = produto.Nome,
                Tipo = produto.Tipo,
                QtdeSaidaProduto = saidaEstoque.QtdeSaidaProduto,
                MotivoSaida = saidaEstoque.MotivoSaida
            });

        }

        private void PopularDataGridSolicitacoes(Solicitacao solicitacao)
        {
            solicitacaoProdutos.Add(new
            {
              Cliente = solicitacao.Cliente,
              Fornecedor = solicitacao.Fornecedor,
              Itens = solicitacao.Itens,
              TipoSolicitacao = solicitacao.TipoSolicitacao
            });
        }

        private void PopularDataGridConsultasStatusEstoque(StatusEstoque statusEstoque)
        {
            consultasStatusEstoque.Add(new
            {
                Produto = statusEstoque.Produto,
                EntradaProdutoEstoque = statusEstoque.EntradaProdutosEstoque,
                Saidas = statusEstoque.Saidas
            });
        }


        private void PopularEntradasEstoque(Produto produto)
        {
            entradaProdutoEstoque.Solicitacao.Itens.Add(
                new ItemSolicitacao
                {
                    Produto = produto,
                    Quantidade = produto.Quantidade
                });
        }

        private void PopularSaidasEstoque(Produto produto)
        {
            saidaEstoque.Solicitacao.Itens.Add(
                new ItemSolicitacao
                {
                    Produto = produto,
                    Quantidade = produto.Quantidade
                }) ;
        }


    }
}
