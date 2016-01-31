﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Lagerverwaltung
{
    /// <summary>
    /// Interaktionslogik für AddAuftrag.xaml
    /// </summary>
    public partial class AddAuftrag : Window
    {
        public AddAuftrag()
        {
            InitializeComponent();
            
        }

        public void insertBauvorhaben() {
            string unternehmenname = UnternehmenNamentextbox.Text;
            string art = Arttextbox.Text;
            string plz = PLZtextbox.Text;
            string ort = Orttextbox.Text;
            string strasse = Strassetextbox.Text;
            string bemerkung = Bemerkungtextbox.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = WOLFGANGZODAC27\\SQLExpress; Database = Bosnjak; user id = bosnjak_dev; password = developer";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Insert into bauvorhaben values (@unternehmenname, @art, @plz, @ort, @strasse, @bemerkung);";
            cmd.Parameters.AddWithValue("@unternehmenname", unternehmenname);
            cmd.Parameters.AddWithValue("@art", art);
            cmd.Parameters.AddWithValue("@plz", plz);
            cmd.Parameters.AddWithValue("@ort", ort);
            cmd.Parameters.AddWithValue("@strasse", strasse);
            cmd.Parameters.AddWithValue("@bemerkung", bemerkung);
            cmd.ExecuteNonQuery();


            conn.Close();

        }



        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void addBauvorhaben_Click(object sender, RoutedEventArgs e)
        {
            insertBauvorhaben();
            MessageBox.Show("Das Bauvorhaben wurde hinzugefuegt.","Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
