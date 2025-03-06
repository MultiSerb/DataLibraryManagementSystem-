using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for DodajKnjiguWindow.xaml
    /// </summary>
    public partial class DodajKnjiguWindow : Window
    {
        public DodajKnjiguWindow()
        {
            InitializeComponent();
        }

        private void OdabirIkonice_Click(object sender, RoutedEventArgs e)
        {
            string folderIkonica = @"Ikonice\";
            string trenutniDirektorijum = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string putanjaDoIkonica = System.IO.Path.Combine(trenutniDirektorijum, folderIkonica);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ikonice|*.jpg;*.jpeg;*.png";


            // openFileDialog.InitialDirectory = @"Ikonice\";

            openFileDialog.InitialDirectory = putanjaDoIkonica;

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string putanjaDoIkonice = openFileDialog.FileName;
                IkonicaTextBox.Text = putanjaDoIkonice;
            }
        }
        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {
            string sifra = sifraTextBox.Text;
            string naslov = naslovKnjigeTextBox.Text;
            string autor = autorTextBox.Text;
            string zanr = zanrTextBox.Text;
            bool dostupnost = dostupnostCheckBox.IsChecked ?? false;
            string putanjaIkonice = IkonicaTextBox.Text;

            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite dodate knjigu?", "Potvrda", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Knjiga novaKnjiga = new Knjiga(sifra, naslov, autor, zanr, dostupnost, putanjaIkonice);

                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.DodajKnjigu(novaKnjiga);
            }

            Close();

        }

        
    }
}
