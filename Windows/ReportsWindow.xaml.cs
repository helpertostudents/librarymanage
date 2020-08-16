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
    /// Interaction logic for ReportsWindow.xaml
    /// </summary>
    public partial class ReportsWindow : Window
    {
        ReportsController reportsController;
        public ReportsWindow()
        {
            InitializeComponent();
            reportsController = new ReportsController();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if(txtStartDate == null)
            {
                MessageBox.Show("Baslangic tarixi secin!");
                return;
            }
            else if(txtEndDate == null)
            {
                MessageBox.Show("Bitme tarixi secin!");
                return;
            }
            var begin = txtStartDate.SelectedDate ?? DateTime.Now;
            var end = txtEndDate.SelectedDate?? DateTime.Now;
            reportDataGrid.ItemsSource = reportsController.GetReportsByTwoDate(begin,end);
        }
    }
}
