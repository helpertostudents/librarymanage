using Library_Managment.Data;
using Library_Managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        private readonly LibraryContext _context;
        private Customer _selectedCustomer;
        public AddCustomer()
        {
            InitializeComponent();
           _context = new LibraryContext();
            FillCustomer();
        }
        private void Reset()
        {
            TxtCsurname.Clear();
            TxtCusername.Clear();
            TxtCphone.Clear();
            TxtCemail.Clear();
            TxtCcode.Clear();
            FillCustomer();

            editCustomer.Visibility = Visibility.Hidden;
            deleteCustomer.Visibility = Visibility.Hidden;
            addCustomers.Visibility = Visibility.Visible;
        }
        private void addCustomers_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("qirmizi olan yerleri doldurmalısınız");
                return;
            }
            Customer customer = new Customer
            {
                CustomerName = TxtCusername.Text,
                CustomerSurname = TxtCsurname.Text,
                CustomerEmail = TxtCemail.Text,
                CustomerTelNo = TxtCphone.Text,
                CustomerCode=TxtCcode.Text,

            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("musteri elave edildi");
        }
        private void FillCustomer()
        {
            grdCustomer.ItemsSource = _context.Customers.ToList();
        }

        private void grdCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grdCustomer.SelectedItem == null) return;
            _selectedCustomer = (Customer)grdCustomer.SelectedItem;
            TxtCusername.Text = _selectedCustomer.CustomerName;
            TxtCsurname.Text = _selectedCustomer.CustomerSurname;
            TxtCphone.Text = _selectedCustomer.CustomerTelNo;
            TxtCemail.Text = _selectedCustomer.CustomerEmail;
            TxtCcode.Text = _selectedCustomer.CustomerCode;

            editCustomer.Visibility = Visibility.Visible;
            deleteCustomer.Visibility = Visibility.Visible;
            addCustomers.Visibility = Visibility.Hidden;

        }

        private void deleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Əminsiniz mi?", _selectedCustomer.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Customers.Remove(_selectedCustomer);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("musteri silindi");
            }
        }

        private void editCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("qirmizi olan yerleri doldurmalısınız");
                return;
            }
            _selectedCustomer.CustomerName = TxtCusername.Text;
            _selectedCustomer.CustomerSurname = TxtCsurname.Text;
            _selectedCustomer.CustomerEmail = TxtCemail.Text;
            _selectedCustomer.CustomerTelNo = TxtCphone.Text;
            _selectedCustomer.CustomerCode = TxtCcode.Text;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("deyistirildi");
        }

        private bool FormValidation()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtCusername.Text))
            {
                TxtCusername.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtCusername.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtCsurname.Text))
            {
                TxtCsurname.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtCsurname.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtCphone.Text))
            {
                TxtCphone.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtCphone.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtCemail.Text))
            {
                TxtCemail.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtCemail.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtCcode.Text))
            {
                TxtCcode.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtCcode.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }
    }
}
