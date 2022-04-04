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
using System.Windows.Shapes;
using TestPreparation.Models.DB;

namespace TestPreparation
{
    /// <summary>
    /// Interaction logic for ShowCustomers.xaml
    /// </summary>
    public partial class ShowCustomers : Window
    {
        public ShowCustomers()
        {
            InitializeComponent();
        }

        private void showCustomers_Click(object sender, RoutedEventArgs e)
        {
using(DAD_TatianaContext ctx = new DAD_TatianaContext())
            {
                grid.ItemsSource = ctx.Tcustomers.ToList();
            }
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }
    }
}
