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
    /// Interaction logic for updateCustomer.xaml
    /// </summary>
    public partial class updateCustomer : Window
    {
        Tcustomer cust = null;
        public updateCustomer()
        {
            
            InitializeComponent();
            setVisible(false);
        }

        private void setVisible(bool value)
        {
            if (value)
            {
                nameLabel.Visibility = Visibility.Visible;
                nameTextBox.Visibility = Visibility.Visible;
                emailLabel.Visibility = Visibility.Visible;
                emailTextBox.Visibility = Visibility.Visible;
                phoneLabel.Visibility = Visibility.Visible;
                phoneTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                nameLabel.Visibility = Visibility.Hidden;
                nameTextBox.Visibility = Visibility.Hidden;
                emailLabel.Visibility = Visibility.Hidden;
                emailTextBox.Visibility = Visibility.Hidden;
                phoneLabel.Visibility = Visibility.Hidden;
                phoneTextBox.Visibility = Visibility.Hidden;
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            
            setVisible(false);
            string check = idTextBox.Text;
            if (check.Length == 0)

            {
                MessageBox.Show("Please enter ID");

            }
            else
            {

                int id = int.Parse(idTextBox.Text);
                using (DAD_TatianaContext ctx = new DAD_TatianaContext())
                {
                    cust = (Tcustomer)ctx.Tcustomers.Where(c => c.Id == id).FirstOrDefault();
                    if (cust != null)
                    {
                        nameTextBox.Text = cust.Name;
                        emailTextBox.Text = cust.Email;
                        phoneTextBox.Text = cust.Phone;
                        setVisible(true);
                    }
                    else
                    {
                        MessageBox.Show("Sorry no record found");
                        setVisible(false);
                    }
                }
            }
        }
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            cust.Name = nameTextBox.Text;
            cust.Email = emailTextBox.Text;
            cust.Phone = phoneTextBox.Text;

            if (cust.Name.Length == 0)
            {
                MessageBox.Show("Please enter name");
            }
            else if (cust.Email.Length == 0)
            {
                MessageBox.Show("Please enter email");
            }

            else
            {

            
            using (DAD_TatianaContext ctx = new DAD_TatianaContext()) 
            {

                ctx.Entry(cust).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();

           

           
                MessageBox.Show("Customer updated succesfully");

                nameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
            }
            }
        }
    }
}

