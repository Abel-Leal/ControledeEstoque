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
    /// Lógica interna para frmCadastrarProduto.xaml
    /// </summary>
    public partial class frmCadastrarProduto : Window
    {
        private Produto produto;
        public frmCadastrarProduto()
        {
            InitializeComponent();
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                produto = new Produto
                {
                    Nome = txtNome.Text,
                    Quantidade = Convert.ToInt32(txtQuantidade.Text)
                };
                if (ProdutoDAO.Cadastrar(produto))
                {
                    MessageBox.Show("Cadastro do Produto foi efetivado!", "Controle de Etoque WPF", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Produto já existente!", "Controle de Estoque WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher campo nome do produto!", "Controle de Estoque WPF", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        private  void LimparFormulario()
        {
            txtId.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtCriadoEm.Clear();
            txtNome.Focus();
            btnCadastrar.IsEnabled = true;
            btnAlterar.IsEnabled = false;
            btnRemover.IsEnabled = false;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                produto = ProdutoDAO.BuscarPorNome(txtNome.Text);
                if (produto != null)
                {
                    btnCadastrar.IsEnabled = false;
                    btnAlterar.IsEnabled = true;
                    btnRemover.IsEnabled = true;

                    txtId.Text = produto.Id.ToString();
                    txtNome.Text = produto.Nome;
                    txtQuantidade.Text = produto.Quantidade.ToString();
                    txtCriadoEm.Text = produto.CriadoEm.ToString();
                }
                else
                {
                    MessageBox.Show("Produto inexistente!", "Controle de Estoque WPF",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparFormulario();
                }
            }
            else
            {
                MessageBox.Show("Favor preencher campo nome do produto!", "Controle de Estoque WPF",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparFormulario();

        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if(produto != null)
            {
                ProdutoDAO.Remover(produto);
                MessageBox.Show("Remoção do produto foi efetivada!", "Controle de Estoque WPF",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível remover o produto!", "Controle de Estoque WPF",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimparFormulario();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (produto != null)
            {
                produto.Nome = txtNome.Text;
                produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                ProdutoDAO.Alterar(produto);
                MessageBox.Show("Alteração do produto foi efetivada!", "Controle de Estoque WPF",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível alterar o produto!", "Controle de Estoque WPF",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimparFormulario();
        }
    }
}
