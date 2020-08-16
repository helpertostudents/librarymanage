using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Managment.Models
{
    public class ReturnBooksTable
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int BooksId { get; set; }
        public DateTime ReturnDate { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public String StatusType { get; set; }

        private String getStatus(int status)
        {
            switch (status)
            {
                case 1:return "Gozlemede";
                case 2:return "Qaytarilib";
                default:
                    return "No Info";
            }
        }

        public ReturnBooksTable(int orderId, int customerId, int booksId, DateTime returnDate, double price, double totalPrice, int statusType)
        {
            OrderId = orderId;
            CustomerId = customerId;
            BooksId = booksId;
            ReturnDate = returnDate;
            Price = price;
            TotalPrice = totalPrice;
            StatusType = getStatus(statusType);
        }
    }


}
