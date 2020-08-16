using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Managment.Models
{
    public class ReturnBooksCustomersTable
    {
        public string CustomerName { get; set; }
        public string CustomerTel { get; set; }
        public int CustomerBookNeedsToGiveCount { get; set; }

        public ReturnBooksCustomersTable(string customerName, string customerTel, int customerBookNeedsToGiveCount)
        {
            CustomerName = customerName;
            CustomerTel = customerTel;
            CustomerBookNeedsToGiveCount = customerBookNeedsToGiveCount;
        }

    }
}
