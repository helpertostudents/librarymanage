using Library_Managment.Data;
using Library_Managment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        private readonly LibraryContext _context;
        private Books _selectedBook;
        //public event EventHandler CustomerInfo;
        public AddBook()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCategory();
            FillBook();
        }
        // for reset
        #region reset
        private void Reset()
        {
            TxtBookName.Clear();
            TxtAuthor.Clear();
            TxtEdition.Clear();
            TxtPrice.Clear();
            TxtShelf.Clear();
            TxtBarcode.Clear();
            cmbCategory.SelectedItem = null;
            FillBook();
            addBook.Visibility = Visibility.Visible;
            bookDelete.Visibility = Visibility.Hidden;
            bookEdit.Visibility = Visibility.Hidden;
            cancelBookEdit.Visibility = Visibility.Hidden;

        }
        #endregion 
        //for category
        private void FillCategory()
        {
            cmbCategory.ItemsSource = _context.Categories.ToList();
        }
        // for ADD book
        #region add  new book
        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("qirmizi olan yerleri doldurmalısınız");
                return;
            }
            Books books = new Books
            {
                BookName = TxtBookName.Text,
                Author = TxtAuthor.Text,
                Price = int.Parse(TxtPrice.Text),
                Edition = TxtEdition.Text,
                Bookshelf = TxtShelf.Text,
                Barcode = TxtBarcode.Text,
                CategoryId = (int)cmbCategory.SelectedValue,

            };
            _context.Books.Add(books);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Kitab elave edildi");

        }
        #endregion
        //for see data in dataGrid
        private void FillBook()
        {
            grdBooks.ItemsSource = _context.Books.ToList();
        }
        //when u click the data, u ll see data inside the input 
        #region dataGrid selectionChanged
        private void grdBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grdBooks.SelectedItem == null) return;
            _selectedBook = (Books)grdBooks.SelectedItem;
            TxtAuthor.Text = _selectedBook.Author;
            TxtBookName.Text = _selectedBook.BookName;
            TxtEdition.Text = _selectedBook.Edition;
            TxtPrice.Text = _selectedBook.Price.ToString(); 
            TxtShelf.Text = _selectedBook.Bookshelf;
            cmbCategory.SelectedValue = _selectedBook.CategoryId;

            addBook.Visibility = Visibility.Hidden; // this button visibility ll  change grom visibility to hidden when u click the row
            bookDelete.Visibility = Visibility.Visible;
            bookEdit.Visibility = Visibility.Visible;
            cancelBookEdit.Visibility = Visibility.Visible;
        }
        #endregion

        //for DELETE book
        #region delete book
        private void bookDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Əminsiniz mi?", _selectedBook.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Books.Remove(_selectedBook);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("kitab silindi");
            }
        }
        #endregion

        // for EDIT book
        #region edit book
        private void bookEdit_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                MessageBox.Show("qirmizi olan yerleri doldurmalısınız");
                return;
            }
            _selectedBook.Author = TxtAuthor.Text;
            _selectedBook.BookName = TxtBookName.Text;
            _selectedBook.Barcode = TxtBarcode.Text;
            _selectedBook.Bookshelf = TxtShelf.Text;
            _selectedBook.CategoryId = (int)cmbCategory.SelectedValue;
            _selectedBook.Edition = TxtEdition.Text;
            _selectedBook.Price = int.Parse(TxtPrice.Text);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("deyistirildi");

        }
        #endregion

        #region check inout is null or emplty
        private bool FormValidation()
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                TxtAuthor.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtAuthor.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                TxtBookName.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtBookName.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtEdition.Text))
            {
                TxtEdition.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtEdition.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtPrice.Text))
            {
                TxtPrice.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtPrice.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtBarcode.Text))
            {
                TxtBarcode.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtBarcode.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (string.IsNullOrEmpty(TxtShelf.Text))
            {
                TxtShelf.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                TxtShelf.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (cmbCategory.SelectedValue == null)
            {
                cmbCategory.Foreground = new SolidColorBrush(Colors.Red);
                hasError = true;
            }
            else
            {
                cmbCategory.Foreground = new SolidColorBrush(Colors.Black);
            }
            return hasError;
        }
        #endregion

        // for SEARCH book
        #region search book
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            grdBooks.ItemsSource = _context.Books.FromSqlRaw("select * from dbo.Books where BookName LIKE '%" + txtSearchBook.Text + "%'").ToList();
            //var db = new LibraryContext();
            //var model = db.Books.Where(x => x.BookName.Contains(txtSearchBook.Text)).ToList();
        }

        #endregion

        // Cancel Button
        #region cancel button
        private void cancelBookEdit_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        #endregion

        //when u search book for its barcode , write data to textbox automatically
        #region barcode
        private void txtSearchBarcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            var db = new LibraryContext();
            var model = db.Books.Where(x => x.Barcode == txtSearchBarcode.Text).ToList();
            foreach (var item in model)
            {
                TxtAuthor.Text = item.Author;
                TxtBookName.Text = item.BookName;
                TxtEdition.Text = item.Edition;
                TxtPrice.Text = item.Price.ToString(); 
                TxtBarcode.Text = item.Barcode;
                TxtShelf.Text = item.Bookshelf;
                cmbCategory.SelectedValue = item.CategoryId;
            }
            if (string.IsNullOrEmpty(txtSearchBarcode.Text))
            {
                TxtBookName.Clear();
                TxtAuthor.Clear();
                TxtEdition.Clear();
                TxtPrice.Clear();
                TxtShelf.Clear();
                TxtBarcode.Clear();
                cmbCategory.SelectedItem = null;
                FillBook();
            }
        }

        #endregion

    }
}

