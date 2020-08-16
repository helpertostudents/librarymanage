using Library_Managment.Data;
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

namespace Library_Managment.Windows
{
    /// <summary>
    /// Interaction logic for HomePageWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        public HomePageWindow()
        {
            InitializeComponent();
            btnDashboard.Margin = new Thickness(20, 125, 20, 400);
            dbcontent.Visibility = Visibility.Hidden;
        }

        private bool BtnDashboardIsOpen = false;

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            if (!BtnDashboardIsOpen)
            {
                btnDashboard.Margin = new Thickness(20, 35, 19, 517);
                dbcontent.Visibility = Visibility.Visible;
            }
            else
            {
                btnDashboard.Margin = new Thickness(20, 125, 20, 400);
                dbcontent.Visibility = Visibility.Hidden;
            }
            BtnDashboardIsOpen = !BtnDashboardIsOpen;
        }

        //private void btnDashboard_Click(object sender, RoutedEventArgs e)
        //{
        //    btnDashboard.Margin = new Thickness(20, 35, 19, 517);
        //    dbcontent.Visibility = Visibility.Visible;

        //}

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            btnDashboard.Margin = new Thickness(20, 135, 20, 400);
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            dbcontent.Visibility = Visibility.Hidden;

        }

        private void BtnNeedsToGive_Click(object sender, RoutedEventArgs e)
        {
            btnDashboard.Margin = new Thickness(20, 135, 20, 400);
            ReturnBookCustomersWindow addCustomer = new ReturnBookCustomersWindow();
            addCustomer.Show();
            dbcontent.Visibility = Visibility.Hidden;
        }

        private void books_Click(object sender, RoutedEventArgs e)
        {
            btnDashboard.Margin = new Thickness(20, 135, 20, 400);
            dbcontent.Visibility = Visibility.Hidden;
            AddBook addBook = new AddBook();
            addBook.Show();
        }


        private void btnİdareciler_Click(object sender, RoutedEventArgs e)
        {
            dbcontent.Visibility = Visibility.Hidden;
            btnDashboard.Margin = new Thickness(20, 135, 20, 400);

            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IssueBook issueBook = new IssueBook();
            issueBook.Show();

        }


        private void btnHesabatlar_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.Show();
        }

        private void BtnReturnBookList_Click(object sender, RoutedEventArgs e)
        {
            ReturnBookWindow returnBook = new ReturnBookWindow();
            returnBook.Show();
        }
    }
}
