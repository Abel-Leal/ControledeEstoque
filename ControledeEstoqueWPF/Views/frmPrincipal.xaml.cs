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
    /// Lógica interna para frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Realmente deseja sair?", "Controle de Estoque WPF", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarProduto frm = new frmCadastrarProduto();
            frm.Show();
        }

        private void menuCadastrarSolicitacao_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarSolicitacao frm = new frmCadastrarSolicitacao();
            frm.ShowDialog();
        }

        private void menuVerificarStatusEstoque_Click(object sender, RoutedEventArgs e)
        {
            frmVerificarStatusEstoque frm = new frmVerificarStatusEstoque();
            frm.ShowDialog();
        }

        private void menuSobre_Click(object sender, RoutedEventArgs e)
        {
            frmDescricaoSistema frm = new frmDescricaoSistema();
            frm.ShowDialog();
        }
    }
}
