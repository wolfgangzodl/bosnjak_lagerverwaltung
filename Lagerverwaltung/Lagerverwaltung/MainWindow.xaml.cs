using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lagerverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder cmdbl;
        public MainWindow()
        {
            InitializeComponent();
            bindingdatagrid();
        }

        private void bindingdatagrid()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = WOLFGANGZODAC27\\SQLExpress; Database = Bosnjak; user id = sa; password = red.bull1610";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from [auftrag]";
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Auftrag");
            da.Fill(dt);
            g1.ItemsSource = dt.DefaultView;
        }

        private void AuftragAendern_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cmdbl = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Information updated", "Update", MessageBoxButton.OK);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }
    }
}