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
using TestPreparation.Models;
namespace TestPreparation
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string name= nameTextBox.Text;
            string email = emailTextBox.Text;   
            string phone = phoneTextBox.Text;

            Tcustomer cust = new Tcustomer();
            cust.Name = name;
            cust.Email = email;
            cust.Phone = phone;

            if (name.Length == 0)
            {
                MessageBox.Show("Please enter name");
            }
            else if(email.Length == 0)
            {
                MessageBox.Show("Please enter email");
            }

            else
            {
                DAO.addCustomer(cust);
                MessageBox.Show("Customer added succesfully");

                nameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
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
