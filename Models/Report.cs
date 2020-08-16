using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Managment.Models
{
    public class Report
    {
        public int IssueId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerTel { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string Bookbarcode { get; set; }
        public string CategoryName { get; set; }
        public double TotalPrice { get; set; }

        public Report(int issueId, string customerName, string customerSurname, string customerTel, string bookName, string bookAuthor, string bookbarcode, string categoryName, double totalPrice)
        {
            IssueId = issueId;
            CustomerName = customerName;
            CustomerSurname = customerSurname;
            CustomerTel = customerTel;
            BookName = bookName;
            BookAuthor = bookAuthor;
            Bookbarcode = bookbarcode;
            CategoryName = categoryName;
            TotalPrice = totalPrice;
        }
    }
}
