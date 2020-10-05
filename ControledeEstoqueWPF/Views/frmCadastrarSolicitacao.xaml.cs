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
        private List<dynamic> itens = new List<dynamic>();
        private int totalItens = 0;
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

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboProdutos.SelectedValue;
            Produto produto = ProdutoDAO.BuscaPorId(id);
            PopularItensSolicitacao(produto);
            PopularDataGrid(produto);
            dtaProdutos.ItemsSource = itens;
            dtaProdutos.Items.Refresh();
            totalItens += Convert.ToInt32(txtQuantidadeProduto.Text);
            lblTotalItens.Content = $"Total de Itens: {totalItens}";
        }

        private void PopularDataGrid(Produto produto)
        {
            itens.Add(new
            {
                Nome = produto.Nome,
                Tipo = produto.Tipo,
                Quantidade = Convert.ToInt32(txtQuantidadeProduto.Text)
            });

        }

        private void PopularItensSolicitacao(Produto produto)
        {
            solicitacao.Itens.Add(new ItemSolicitacao
            {
                Produto = produto,
                Quantidade = Convert.ToInt32(txtQuantidadeProduto.Text)

            });
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            int idCliente = (int)cboClientes.SelectedValue;
            int idFornecedor = (int)cboFornecedores.SelectedValue;
            solicitacao.Cliente = ClienteDAO.BuscaPorId(idCliente);
            solicitacao.Fornecedor = FornecedorDAO.BuscaPorId(idFornecedor);
            SolicitacaoDAO.Cadastrar(solicitacao);
            MessageBox.Show("Solicitacao efetivada!", "Controle de Estoque", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
