using Library_Managment.Data;
using Library_Managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Managment.Controllers
{
    public class ReturnBookCustomersController
    {
        LibraryContext _context;

        public ReturnBookCustomersController()
        {
            _context = new LibraryContext();
        }

        private bool ReturnDateCheck(DateTime returnDate, EnumDate enumDate)
        {
            switch (enumDate)
            {
                case EnumDate.NEEDSTOGIVE:
                    return DateTime.Now.DayOfYear - returnDate.DayOfYear > 0; //DateTime.Now = 16 - return date - 15
                case EnumDate.TODAY:
                    return returnDate.DayOfYear - DateTime.Now.DayOfYear == 0; //DateTime.Now = 14 - return date - 15
                case EnumDate.TOMORROW:
                    return returnDate.DayOfYear - DateTime.Now.DayOfYear == 1; //DateTime.Now = 17 - return date - 16
                default: return false;
            }
        }

        public List<ReturnBooksCustomersTable> GetOrdersByDate(EnumDate enumDate)
        {
            var todayReturnBookTable = (from order in _context.Issues.ToList()
                                        where ReturnDateCheck(order.ReturnDate, enumDate) && order.IssueStatusType == 1
                                        group order by order.CustomerId into orderGrouped
                                        join customer in _context.Customers.ToList() on orderGrouped.Key equals customer.Id
                                        select new ReturnBooksCustomersTable
                                        (
                                            customer.CustomerName,
                                            customer.CustomerTelNo,
                                            orderGrouped.Count()
                                        )).ToList();
            if (todayReturnBookTable != null && todayReturnBookTable.Count != 0)
                return todayReturnBookTable;
            else
                return new List<ReturnBooksCustomersTable>();
        }
    }
}
