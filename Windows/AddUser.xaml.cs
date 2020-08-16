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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        private readonly LibraryContext _context;
        private Users _selectedUser;
        public AddUser()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillUser();
        }
        private void Reset()
        {
            TxtUserName.Clear();
            TxtUserPassword.Clear();
            FillUser();
            addUserBtn.Visibility = Visibility.Visible;
            editUser.Visibility = Visibility.Hidden;
            deleteUser.Visibility = Visibility.Hidden;
        }

        private void addCustomers_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("qirmizi olan yerleri doldurmalısınız");
                return;
            }
            Users users = new Users
            {
                Username = TxtUserName.Text,
                Password = TxtUserPassword.Text,
            };
            _context.Users.Add(users);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("user elave edildi");
        }
        private void FillUser()
        {
            grdUser.ItemsSource = _context.Users.ToList();
        }

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            grdAddUser.Visibility = Visibility.Visible;
        }

        private void grdUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdAddUser.Visibility = Visibility.Visible;
            addUser.Visibility = Visibility.Hidden;
            if (grdUser.SelectedItem == null) return;
            _selectedUser = (Users)grdUser.SelectedItem;
            TxtUserName.Text = _selectedUser.Username;
            TxtUserPassword.Text = _selectedUser.Password;

            addUserBtn.Visibility = Visibility.Hidden;
            editUser.Visibility = Visibility.Visible;
            deleteUser.Visibility = Visibility.Visible;
        }

        private void deleteUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Əminsiniz mi?", _selectedUser.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Users.Remove(_selectedUser);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("user silindi");
            }
        }

        private void editUser_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("qirmizi olan yerleri doldurmalısınız");
                return;
            }
            _selectedUser.Username = TxtUserName.Text;
            _selectedUser.Password = TxtUserPassword.Text;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("deyistirildi");
        }
        private bool FormValidation()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtUserName.Text))
            {
                TxtUserName.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtUserName.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtUserPassword.Text))
            {
                TxtUserPassword.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtUserPassword.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }
    }
}
