using Library_Managment.Controllers;
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
    /// Interaction logic for ReturnBookWindow.xaml
    /// </summary>
    public partial class ReturnBookWindow : Window
    {
        
        private ReturnBookController returnBookController;
        private ReturnBooksTable _returnBooksTable;
        public ReturnBookWindow()
        {
            InitializeComponent();
            returnBookController = new ReturnBookController();
        }

        private void txtIssueCustomerId_TextChanged(object sender, TextChangedEventArgs e)
        {
            var item = returnBookController.GetCustomerById(int.Parse(txtIssueCustomerId.Text));
            if (item != null)
            {
                txtIssueCustomerCode.Text = item.CustomerCode;
                txtIssueCustomerName.Text = item.CustomerName;
                txtIssueCustomerSurname.Text = item.CustomerSurname;
                txtIssueCustomerEmail.Text = item.CustomerEmail;
                txtIssueCustomerTel.Text = item.CustomerTelNo;
            }
            else
                MessageBox.Show("User is not found.");
            if (string.IsNullOrEmpty(txtIssueCustomerId.Text))
            {
                txtIssueCustomerCode.Clear();
                txtIssueCustomerName.Clear();
                txtIssueCustomerSurname.Clear();
                txtIssueCustomerEmail.Clear();
                txtIssueCustomerTel.Clear();
            }
        }

        private void txtBookId_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void searchByCustomerId_Click(object sender, RoutedEventArgs e)
        {
            fillDataGrid();
        }

        private void fillDataGrid()
        {
            var result = returnBookController.GetCustomerBooks(int.Parse(txtIssueCustomerId.Text));
            returnBookDataGrid.ItemsSource = result;
        }


        private void removeCustomerIssue_Click(object sender, RoutedEventArgs e)
        {
            returnBookController.RemoveCustomerIssue(_returnBooksTable.OrderId);
            removeCustomerIssue.IsEnabled = false;
            fillDataGrid();
            returnBookDataGrid.Items.Refresh();
        }

        private void fillTextBoxBook(Books books)
        {
            txtBookId.Text = books.Id.ToString();
            txtBookName.Text = books.BookName;
            txtBookBarcode.Text = books.Barcode;
            txtBookAuthor.Text = books.Author;
            txtBookPrice.Text = books.Price.ToString();
        }

        private void resetTextBoxBook()
        {
            txtBookId.Clear();
            txtBookName.Clear();
            txtBookBarcode.Clear();
            txtBookAuthor.Clear();
            txtBookPrice.Clear();
        }



        private void returnBookDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (returnBookDataGrid.SelectedItem == null)
            {
                removeCustomerIssue.IsEnabled = false;
                resetTextBoxBook();
                return;
            }
            removeCustomerIssue.IsEnabled = true;
            _returnBooksTable = (ReturnBooksTable)returnBookDataGrid.SelectedItem;
            var result = returnBookController.getBookInformation(_returnBooksTable.BooksId);
            fillTextBoxBook(result);
        }
    }
}
