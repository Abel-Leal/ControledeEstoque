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
    /// Lógica interna para frmCadastrarEntradaProduto.xaml
    /// </summary>
    public partial class frmCadastrarEntradaProduto : Window
    {

        private Entrada entrada = new Entrada();
        private List<dynamic> entradas = new List<dynamic>();
        private int totalEntradas = 0;
        public frmCadastrarEntradaProduto()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            cboProdutos.ItemsSource = ProdutoDAO.Listar();
            cboProdutos.DisplayMemberPath = "Nome";
            cboProdutos.SelectedValuePath = "Id";
        }

        private void btnAdicionarEntradaProduto_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboProdutos.SelectedValue;
            Produto produto = ProdutoDAO.BuscaPorId(id);
            PopularEntradasProduto(produto);
            PopularDataGridEntrada(produto);
            dtaEntradaProdutosEstoque.ItemsSource = entradas;
            dtaEntradaProdutosEstoque.Items.Refresh();
            totalEntradas += Convert.ToInt32(txtQuantidadeProduto.Text);
            lblTotalEntradas.Content = $"Total de Entradas: {totalEntradas}";
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

        private void PopularEntradasProduto(Produto produto)
        {
            entradas.Add(new Entrada
            {
                Produto = produto,
                QtdeEntrada = Convert.ToInt32(txtQuantidadeProduto.Text)

            });
        }

        private void btnCadastrarEntradaProduto_Click(object sender, RoutedEventArgs e)
        {
            int idProduto = (int)cboProdutos.SelectedValue;
            entrada.Produto = ProdutoDAO.BuscaPorId(idProduto);
            EntradaDAO.CadastrarEntrada(entrada);
            MessageBox.Show("Entrada de Produto Efetivada!", "Controle de Estoque", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
