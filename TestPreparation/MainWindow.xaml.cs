using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestPreparation
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

        private void addCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();
            this.Hide();
        }

        private void showCustomer_Click(object sender, RoutedEventArgs e)
        {
            ShowCustomers form = new ShowCustomers();
            form.Show();
            this.Hide();
        }

        private void SearchCustomer_Click(object sender, RoutedEventArgs e)
        {
            SearchCustomer form = new SearchCustomer();
            form.Show();
            this.Hide();
        }

        private void updateCustomer_Click(object sender, RoutedEventArgs e)
        {
            updateCustomer form = new updateCustomer();
            form.Show();
            this.Hide();
        }
    }
}
