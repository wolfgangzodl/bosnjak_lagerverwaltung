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
            List<String> AuftragInfos = new List<String>();
            SqlConnection conn = new SqlConnection("Server=WOLFGANGZODAC27\\SQLExpress;Database=Bosnjak;user id = sa; password=red.bull1610");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Jahr, AuftragNummer, b.UnternehmenName, b.Art, b.PLZ, b.Ort, b.Strasse, a.AuftraggeberName, a.PLZ, a.Ort, a.Strasse from Auftrag join Bauvorhaben b on b.BauvorhabenNr = Auftrag.BauvorhabenNr join Auftraggeber a on a.AuftraggeberNr = Auftrag.AuftraggeberNR;", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AuftragInfos.Add(reader.GetString(0));
                //AuftragInfos.Add(reader.GetString(1));
                AuftragInfos.Add(reader.GetString(2));
                //AuftragInfos.Add(reader.GetString(3));
                AuftragInfos.Add(reader.GetString(4));
                AuftragInfos.Add(reader.GetString(5));
                AuftragInfos.Add(reader.GetString(6));
                AuftragInfos.Add(reader.GetString(7));
                AuftragInfos.Add(reader.GetString(8));
                AuftragInfos.Add(reader.GetString(9));
                AuftragInfos.Add(reader.GetString(10));
                //AuftragInfos.Add(reader.GetString(11));
                //AuftragInfos.Add(reader.GetString(12));
                //AuftragInfos.Add(reader.GetString(13));
                //AuftragInfos.Add(reader.GetString(14));
            }
            listView.ItemsSource = AuftragInfos;
            reader.Close();
            conn.Close();
            foreach (String i in AuftragInfos) {
                Console.WriteLine(i);
            }
        }

        public class Auftrag
        {
            private String jahr;
            private String auftragnummer;
            private String pL;
            private String unternehmenNamen;
            private String art;
            private String bPLZ;
            private String bOrt;
            private String bStrasse;
            private String auftraggeberName;
            private String aOrt;
            private String aStrasse;
            private String arbeitsart;
            private String sR;
            private String sZ;
            private String nK;

            public string Jahr
            {
                get
                {
                    return jahr;
                }

                set
                {
                    jahr = value;
                }
            }

            public string Auftragnummer
            {
                get
                {
                    return auftragnummer;
                }

                set
                {
                    auftragnummer = value;
                }
            }

            public string PL
            {
                get
                {
                    return pL;
                }

                set
                {
                    pL = value;
                }
            }

            public string UnternehmenNamen
            {
                get
                {
                    return unternehmenNamen;
                }

                set
                {
                    unternehmenNamen = value;
                }
            }

            public string Art
            {
                get
                {
                    return art;
                }

                set
                {
                    art = value;
                }
            }

            public string BPLZ
            {
                get
                {
                    return bPLZ;
                }

                set
                {
                    bPLZ = value;
                }
            }

            public string BOrt
            {
                get
                {
                    return bOrt;
                }

                set
                {
                    bOrt = value;
                }
            }

            public string BStrasse
            {
                get
                {
                    return bStrasse;
                }

                set
                {
                    bStrasse = value;
                }
            }

            public string AuftraggeberName
            {
                get
                {
                    return auftraggeberName;
                }

                set
                {
                    auftraggeberName = value;
                }
            }

            public string AOrt
            {
                get
                {
                    return aOrt;
                }

                set
                {
                    aOrt = value;
                }
            }

            public string AStrasse
            {
                get
                {
                    return aStrasse;
                }

                set
                {
                    aStrasse = value;
                }
            }

            public string Arbeitsart
            {
                get
                {
                    return arbeitsart;
                }

                set
                {
                    arbeitsart = value;
                }
            }

            public string SR
            {
                get
                {
                    return sR;
                }

                set
                {
                    sR = value;
                }
            }

            public string SZ
            {
                get
                {
                    return sZ;
                }

                set
                {
                    sZ = value;
                }
            }

            public string NK
            {
                get
                {
                    return nK;
                }

                set
                {
                    nK = value;
                }
            }
        }
       

       


        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
