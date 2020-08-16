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
    /// Interaction logic for IssueBook.xaml
    /// </summary>
    public partial class IssueBook : Window
    {
        private readonly LibraryContext _context;
        private Basket _selectedBookFromBasket;

        public IssueBook()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillBook();
        }

        private void btnIssueCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnIssueAddBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Basket basket = new Basket
                {
                    CustomerId = int.Parse(txtIssueCustomerId.Text),
                    BooksId = int.Parse(txtBookId.Text),
                    ReturnDate = (DateTime)txtReturnDate.SelectedDate,
                };
                _context.Baskets.Add(basket);
                _context.SaveChanges();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            Reset();
            MessageBox.Show("sebete elave edildi");
        }
        private void Reset()
        {
            txtBookId.Clear();
            txtBookBarcode.Clear();
            txtBookName.Clear();
            txtBookPrice.Clear();
            txtBookAuthor.Clear();
            txtReturnDate.SelectedDate = null;
            FillBook();
        }
        private void FillBook()
        {
            grdBasket.ItemsSource = _context.Baskets.ToList();
        }

        private void txtBookId_TextChanged(object sender, TextChangedEventArgs e)
        {
            var db = new LibraryContext();
            var model = db.Books.Where(x => x.Id.ToString() == txtBookId.Text).ToList();
            foreach (var item in model)
            {
                txtBookBarcode.Text = item.Barcode;
                txtBookAuthor.Text = item.Author;
                txtBookName.Text = item.BookName;
                txtBookPrice.Text = item.Price.ToString();
                //txtBookId.Text = item.Id.ToString();
            }
            if (string.IsNullOrEmpty(txtBookId.Text))
            {
                txtBookBarcode.Clear();
                txtBookAuthor.Clear();
                txtBookName.Clear();
                txtBookPrice.Clear();

            }
        }

        private void txtIssueCustomerId_TextChanged(object sender, TextChangedEventArgs e)
        {
            var db = new LibraryContext();
            var model = db.Customers.Where(x => x.Id.ToString() == txtIssueCustomerId.Text).ToList();
            foreach (var item in model)
            {
                txtIssueCustomerCode.Text = item.CustomerCode;
                txtIssueCustomerName.Text = item.CustomerName;
                txtIssueCustomerSurname.Text = item.CustomerSurname;
                txtIssueCustomerEmail.Text = item.CustomerEmail;
                txtIssueCustomerTel.Text = item.CustomerTelNo;
            }
            if (string.IsNullOrEmpty(txtIssueCustomerId.Text))
            {
                txtIssueCustomerCode.Clear();
                txtIssueCustomerName.Clear();
                txtIssueCustomerSurname.Clear();
                txtIssueCustomerEmail.Clear();
                txtIssueCustomerTel.Clear();
            }
        }

        private void btnIssueDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Əminsiniz mi?", _selectedBookFromBasket.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Baskets.Remove(_selectedBookFromBasket);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("kitab sebetden silindi");
            }
        }

        private void btnIssueAccept_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIssueCustomerId.Text))
            {
                MessageBox.Show("Musteri Id-sini daxil edin");
                return;
            }
            var books = _context.Baskets.Where(x => x.CustomerId == int.Parse(txtIssueCustomerId.Text)).ToList();
            foreach (var book in books)
            {
                Issue issue = new Issue
                {
                    CustomerId = int.Parse(txtIssueCustomerId.Text),
                    ReturnDate = book.ReturnDate,
                    BooksId = book.BooksId,
                    IssueStatusType = 1
                };
                _context.Issues.Add(issue);
            }
            _context.Baskets.RemoveRange(_context.Baskets.Where(x => x.CustomerId == int.Parse(txtIssueCustomerId.Text)));
            _context.SaveChanges();
            Reset();
            grdBasket.ItemsSource = null;
            grdBasket.Items.Clear();
            grdBasket.Items.Refresh();
            MessageBox.Show("Sifaris Tesdiqlendi");
        }

        private void grdBasket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grdBasket.SelectedItem == null) return;
            _selectedBookFromBasket = (Basket)grdBasket.SelectedItem;

        }
    }
}
