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
    /// Lógica interna para frmCadastrarSaidaProduto.xaml
    /// </summary>
    public partial class frmCadastrarSaidaProduto : Window
    {

        private Saida saida = new Saida();
        private List<dynamic> saidas = new List<dynamic>();
        private int totalSaidas = 0;
        public frmCadastrarSaidaProduto()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            cboProdutos.ItemsSource = ProdutoDAO.Listar();
            cboProdutos.DisplayMemberPath = "Nome";
            cboProdutos.SelectedValuePath = "Id";
        }

        private void btnRegistrarSaidaProduto_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboProdutos.SelectedValue;
            Produto produto = ProdutoDAO.BuscaPorId(id);
            PopularSaidasProduto(produto);
            PopularDataGridSaida(produto);
            dtaSaidaProdutosEstoque.ItemsSource = saidas;
            dtaSaidaProdutosEstoque.Items.Refresh();
            totalSaidas += Convert.ToInt32(txtQuantidadeProduto.Text);
            lblTotalSaidas.Content = $"Total de Entradas: {totalSaidas}";
        }


        private void PopularDataGridSaida(Produto produto)
        {
            saidas.Add(new
            {
                Nome = produto.Nome,
                Tipo = produto.Tipo,
                Categoria = produto.Categoria,
                Quantidade = Convert.ToInt32(txtQuantidadeProduto.Text)
            });

        }

        private void PopularSaidasProduto(Produto produto)
        {
            saidas.Add(new Entrada
            {
                Produto = produto,
                QtdeEntrada = Convert.ToInt32(txtQuantidadeProduto.Text)

            });
        }

        private void btnCadastrarSaidaProduto_Click(object sender, RoutedEventArgs e)
        {
            int idProduto = (int)cboProdutos.SelectedValue;
            saida.Produto = ProdutoDAO.BuscaPorId(idProduto);
            SaidaDAO.CadastrarSaida(saida);
            MessageBox.Show("Saída de Produto Efetivada!", "Controle de Estoque", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
