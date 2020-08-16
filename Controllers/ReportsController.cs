using Library_Managment.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Linq;
using Microsoft.VisualBasic;
using Library_Managment.Models;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Controls;

namespace Library_Managment.Controllers
{
    public class ReportsController
    {
        LibraryContext _context;

        public ReportsController()
        {
            _context = new LibraryContext();
        }
        //ses yoxdu helede 
        private double GetDays(DateTime? d1, DateTime d2)
        {
            DateTime d = d1 ?? d2;
            return d >= d2 ? (d - d2).Days : 0;
        }
        
        public List<Report> GetReportsByTwoDate(DateTime start, DateTime end)
        {
            var result = (from order in _context.Issues.ToList()
                          join customer in _context.Customers.ToList() on order.CustomerId equals customer.Id
                          join book in _context.Books.ToList() on order.BooksId equals book.Id
                          join category in _context.Categories.ToList() on book.CategoryId equals category.Id
                          where order.GivedDate != null && order.GivedDate >= start && order.GivedDate <= end && order.IssueStatusType == 2
                          select new Report
                          (
                              order.Id,
                              customer.CustomerName,
                              customer.CustomerSurname,
                              customer.CustomerTelNo,
                              book.BookName,
                              book.Author,
                              book.Barcode,
                              category.Name,
                              GetDays(order.GivedDate, order.ReturnDate) * (book.Price * (0.5 / 100.0))
                          )).ToList();
            if (result != null && result?.Count != 0)
                return result;
            return new List<Report>();
        }

        public void ReportsToExcelFile(DataGrid dataGrid)
        {

        }

    }
}
