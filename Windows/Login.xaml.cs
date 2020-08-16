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
using System.Data.SqlClient;
using System.Data;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-DGKGL9C\MSSQLSERVER01;Database=Library;Trusted_Connection=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Users where Username = '" + TxtUsername.Text + "' and Password ='" + TxtPassword.Password.ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                HomePageWindow homePageWindow = new HomePageWindow();
                homePageWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
        }

    }
}
