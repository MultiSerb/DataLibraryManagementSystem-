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
using System.Windows.Shapes;

namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {
            string Id = IDTextBox.Text;
            string Ime = ImeTextBox.Text;
            string Prezime = PrezimeTextBox.Text;
            Korisnik nkorisnik = new Korisnik(Id,Ime,Prezime);


            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.Dodajkorisnika(nkorisnik);

            Close();
        }
    }
}
