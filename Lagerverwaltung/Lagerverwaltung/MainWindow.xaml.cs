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

namespace Lagerverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         public MainWindow()
         {
             InitializeComponent();
         }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            TextBox textBox = sender as TextBox;
            //Auftragsnummer.Text = today

    }
}
