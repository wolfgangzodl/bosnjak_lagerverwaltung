using System;
using System.Collections.Generic;
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
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace Lagerverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // BosnjakEntities bj = new BosnjakEntities();
            SqlConnection con = new SqlConnection();
            SqlDataAdapter ad = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            String str = "select Jahr, AuftragNummer, Bauvorhaben.UnternehmenName, Bauvorhaben.Art,Bauvorhaben.PLZ, Bauvorhaben.Ort, Bauvorhaben.Strasse, Auftraggeber.AuftraggeberName, Auftraggeber.PLZ, Auftraggeber.Ort, Auftraggeber.Strasse from Auftrag" + 
            "where (select BauvorhabenNr from Bauvorhaben) = Auftrag.BauvorhabenNr and (select AuftraggeberNr from Auftraggeber) = Auftrag.AuftraggeberNr";

            //String str = "select Jahr, Auftragnummer from Auftrag;";
            cmd.CommandText = str;
            ad.SelectCommand = cmd;
            con.ConnectionString = "user id = sa; password = red.bull1610; Server = WOLFGANGZODAC27\\SQLEXPRESS; database = Bosnjak;";
            cmd.Connection = con;
            DataSet ds = new DataSet();
            ad.Fill(ds);
            listView.DataContext = ds.Tables[0].DefaultView;
            con.Close();
        }

       

       


        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
