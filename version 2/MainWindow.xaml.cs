using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Markup;

namespace version_2
{
  
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Load_data("", " ");
        }
        public int i = 4, b = 0, g = 0;
        public void Load_data(string stroka, string top)
        {

            Form1.Children.Clear();
            //using (SqlConnection connection = new SqlConnection(@"Data Source = sql-server,49172;                                                
            // Initial Catalog = KinPra3; User id = Kost; Password = 123;
            // Integrated Security = true; "))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand($"SELECT {top} [ArticleNumber], [Product].[Title], [MinCostForAgent], [material].[Title],[Product].[Image], [TagID] FROM [KinPra3].[dbo].[Material], [KinPra3].[dbo].[Product], [KinPra3].[dbo].[ProductMaterial] Where [Material].[ID] = [ProductMaterial].[MaterialID] and [Product].[ID] = [ProductMaterial].[ProductID] and [Product].[Title] like" + stroka, connection);
            //    SqlDataReader reader = command.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            test client = new test();
            //            client.Articul.Content = reader[0];
            //            client.aaa.Content = reader[1];
            //            client.Cost.Content = reader[2];
            //            client.Materials.Content = reader[3];
            //            Form1.Children.Add(client);

            //        }
            //    }
            //}


            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Voproses";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT Table.[vopros], Table.[v1], Table.[v2], Table.[v3] FROM [Table];";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            if (dbReader.HasRows)
            {
                while (dbReader.Read())
                {
                    test client = new test();
                    client.ID.Content = dbReader[1];
                    client.aaa.Content = dbReader[1];
                    client.Articul.Content = dbReader[2];
                    client.Cost.Content = dbReader[3];
                    client.Materials.Content = dbReader[4];
                    Form1.Children.Add(client);

                }
            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load_data("'%%' " + "", "");
        }


        private void Left_Click(object sender, RoutedEventArgs e)
        {
            Scroll_clients.PageUp();
            if (i > 4) i = i - 4; if (i < 4) i = 4;
            LLL.Content = i.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            Scroll_clients.PageDown();
            i = i + 4;
            if (i > b) i = b;
            LLL.Content = i.ToString();
        }


        private void Scroll_clients_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
        }



    }
}
