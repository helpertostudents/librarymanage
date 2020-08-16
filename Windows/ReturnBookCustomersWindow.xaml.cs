using Library_Managment.Controllers;
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
    /// Interaction logic for ReturnBookCustomersWindow.xaml
    /// </summary>
    public partial class ReturnBookCustomersWindow : Window
    {
        ReturnBookCustomersController returnBookCustomersController;
        public ReturnBookCustomersWindow()
        {
            InitializeComponent();
            returnBookCustomersController = new ReturnBookCustomersController();
            todayDataGrid.ItemsSource = returnBookCustomersController.GetOrdersByDate(Models.EnumDate.TODAY);
            tomorrowDataGrid.ItemsSource = returnBookCustomersController.GetOrdersByDate(Models.EnumDate.TOMORROW);
            needsToGiveDataGrid.ItemsSource = returnBookCustomersController.GetOrdersByDate(Models.EnumDate.NEEDSTOGIVE);
        }
    }
}
