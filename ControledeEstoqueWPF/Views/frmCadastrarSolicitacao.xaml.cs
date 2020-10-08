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
    /// Lógica interna para frmCadastrarSolicitacao.xaml
    /// </summary>
    public partial class frmCadastrarSolicitacao : Window
    {
        private Solicitacao solicitacao = new Solicitacao();
        private List<dynamic> entradas = new List<dynamic>();
        private List<dynamic> saidas = new List<dynamic>();
        private int totalEntradas = 0;
        private int totalSaidas = 0;


        public frmCadastrarSolicitacao()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboClientes.ItemsSource = ClienteDAO.Listar();
            cboClientes.DisplayMemberPath = "Nome";
            cboClientes.SelectedValuePath = "Id";

            cboFornecedores.ItemsSource = FornecedorDAO.Listar();
            cboFornecedores.DisplayMemberPath = "Nome";
            cboFornecedores.SelectedValuePath = "Id";

            cboProdutos.ItemsSource = ProdutoDAO.Listar();
            cboProdutos.DisplayMemberPath = "Nome";
            cboProdutos.SelectedValuePath = "Id";

        }

        private void btnAdicionarEntrada_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboProdutos.SelectedValue;
            Produto produto = ProdutoDAO.BuscaPorId(id);
            PopularEntradasSolicitacao(produto);
            PopularDataGridEntrada(produto);
            dtaEntradaProdutos.ItemsSource = entradas;
            dtaEntradaProdutos.Items.Refresh();
            totalEntradas += Convert.ToInt32(txtQuantidadeProduto.Text);
            lblTotalEntradas.Content = $"Total de Entradas: {totalEntradas}";
        }

        private void btnRegistrarSaida_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboProdutos.SelectedValue;
            Produto produto = ProdutoDAO.BuscaPorId(id);
            PopularSaidasSolicitacao(produto);
            PopularDataGridSaida(produto);
            dtaSaidaProdutos.ItemsSource = saidas;
            dtaSaidaProdutos.Items.Refresh();
            totalSaidas += Convert.ToInt32(txtQuantidadeProduto.Text);
            lblTotalSaidas.Content = $"Total de Saidas: {totalSaidas}";
        }


        private void PopularDataGridEntrada(Produto produto)
        {
            entradas.Add(new
            {
                Nome = produto.Nome,
                Tipo = produto.Tipo,
                Categoria = produto.Categoria,
                Quantidade = Convert.ToInt32(txtQuantidadeProduto.Text)
            });

        }

        private void PopularDataGridSaida(Produto produto)
        {
            saidas.Add(new
            {
                Nome = produto.Nome,
                Tipo = produto.Tipo,
                Quantidade = Convert.ToInt32(txtQuantidadeProduto.Text)
            });

        }

        private void PopularEntradasSolicitacao(Produto produto)
        {
            solicitacao.Entradas.Add(new Entrada
            {
                Produto = produto,
                QtdeEntrada = Convert.ToInt32(txtQuantidadeProduto.Text)

            });
        }
        private void PopularSaidasSolicitacao(Produto produto)
        {
            solicitacao.Saidas.Add(new Saida
            {
                Produto = produto,
                QtdeSaida = Convert.ToInt32(txtQuantidadeProduto.Text)

            });
        }

        private void btnCadastrarSolicitacao_Click(object sender, RoutedEventArgs e)
        {
            int idCliente = (int)cboClientes.SelectedValue;
            int idFornecedor = (int)cboFornecedores.SelectedValue;
            solicitacao.Cliente = ClienteDAO.BuscaPorId(idCliente);
            solicitacao.Fornecedor = FornecedorDAO.BuscaPorId(idFornecedor);
            SolicitacaoDAO.Cadastrar(solicitacao);
            MessageBox.Show("Solicitação efetivada!", "Controle de Estoque", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
