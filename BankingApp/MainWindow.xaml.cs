using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BankingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        double bankingTransaction()
        {
            Banking banking = new Banking();
            // banking.accountNo = Convert.ToInt32(txtID.Text);
            banking.accountName = txtName.Text;
            banking.accountType = txtType.Text;

            var result = Convert.ToDouble(txtbalance.Text) + Convert.ToDouble(txtDeposit.Text) - Convert.ToDouble(txtWithdrawal.Text);


            return result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            txtFinalBalance.Text = bankingTransaction().ToString();

            MessageBox.Show($"Transaction Completed", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

    }
}
