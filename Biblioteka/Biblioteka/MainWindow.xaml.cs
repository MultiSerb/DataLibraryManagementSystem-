using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.IO;

namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Knjiga> kolekcijaKnjiga { set; get; }
        public ObservableCollection<Zanr> Zanrovi { get; set; }
        public ObservableCollection<Korisnik> Korisnici { get; set; }




        #region main
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            kolekcijaKnjiga = new ObservableCollection<Knjiga>();
            Korisnici = new ObservableCollection<Korisnik>();
            knjigeListView.ItemsSource = kolekcijaKnjiga;
            knjigestatistika.ItemsSource = kolekcijaKnjiga;//ovo je za 3 tab
            korisnicil.ItemsSource = Korisnici;
            Zanrovi = new ObservableCollection<Zanr>();
            
          // Importzanr("export2.txt"); ovo treba da bude komentarisano mrzi me da brisem
           Importknjige("export.txt");
           ImportKorisnik("export1.txt");
           /*/ ovo otkomentarisati ako hoces podatke od 0 tj bez importa samo gore import komentarisati
            Knjiga k1 = new Knjiga("1", "Na Drini ćuprija", "Ivo Andrić", "Ep", true, @"Ikonice\Ikonica1.png");
            Knjiga k2 = new Knjiga("2", "Prokleta avlija", "Ivo Andrić", "Kratka priča", true, @"Ikonice\Ikonica4.png");
            Knjiga k3 = new Knjiga("3", "Seobe", "Milos Crnjanski", "Epski roman", true, @"Ikonice\Ikonica2.png");
            Knjiga k4 = new Knjiga("4", "Gorski vijenac", "Petrovic Njegos", "Epska poema", true, @"Ikonice\Ikonica5.png");
            Knjiga k5 = new Knjiga("5", "Zlocin i kazna", "Fjodor Dostojevski", "Roman", true, @"Ikonice\Ikonica3.png");
            Knjiga k6 = new Knjiga("6", "Besnilo", "Borislav Pekic", "Roman", true, @"Ikonice\Ikonica2.png");
            Knjiga k7 = new Knjiga("7", "Koreni", "Dobrica Cosic", "Roman", true, @"Ikonice\Ikonica1.png");
            Knjiga k8 = new Knjiga("8", "Alkohol", "Milenko Jergovic", "Zbirka priča", true, @"Ikonice\Ikonica4.png");
            Knjiga k9 = new Knjiga("9", "Sabrana dela", "Desanka Maksimovic", "Poezija", true, @"Ikonice\Ikonica3.png");
            Knjiga k10 = new Knjiga("10", "Deobe", "Dobrica Cosic", "Roman", true, @"Ikonice\Ikonica5.png");
            Knjiga k11 = new Knjiga("11", "Majstor i Margarita", "Mihail Bulgakov", "Roman", true, @"Ikonice\Ikonica3.png");
            Knjiga k12 = new Knjiga("12", "Hari Poter i Kamen mudrosti", "J.K. Rowling", "Fantazija", true, @"Ikonice\Ikonica1.png");
            Knjiga k13 = new Knjiga("13", "Lolita", "Vladimir Nabokov", "Roman", true, @"Ikonice\Ikonica2.png");
            Knjiga k14 = new Knjiga("14", "Rat i mir", "Lav Nikolajevic Tolstoj", "Roman", true, @"Ikonice\Ikonica4.png");
            Knjiga k15 = new Knjiga("15", "Veliki Getsbi", "F. Scott Fitzgerald", "Roman", true, @"Ikonice\Ikonica5.png");
            kolekcijaKnjiga.Add(k1);
            kolekcijaKnjiga.Add(k2);
            kolekcijaKnjiga.Add(k3);
            kolekcijaKnjiga.Add(k4);
            kolekcijaKnjiga.Add(k5);
            kolekcijaKnjiga.Add(k6);
            kolekcijaKnjiga.Add(k7);
            kolekcijaKnjiga.Add(k8);
            kolekcijaKnjiga.Add(k9);
            kolekcijaKnjiga.Add(k10);
            kolekcijaKnjiga.Add(k11);
            kolekcijaKnjiga.Add(k12);
            kolekcijaKnjiga.Add(k13);
            kolekcijaKnjiga.Add(k14);
            kolekcijaKnjiga.Add(k15);
          
            Zanr z1 = new Zanr() { Naziv = "Ep" };
            Zanr z2 = new Zanr() { Naziv = "Kratka priča" };
            Zanr z3 = new Zanr() { Naziv = "Roman" };
            Zanr z4 = new Zanr() { Naziv = "Poezija" };
            Zanr z5 = new Zanr() { Naziv = "Fantazija" };
            Zanr z6 = new Zanr() { Naziv = "Zbirka priča" };
            Zanr z7 = new Zanr() { Naziv = "Epska poema" };
            z1.Knjige.Add(k1);
            z2.Knjige.Add(k2);
            z3.Knjige.Add(k3);
            z7.Knjige.Add(k4);
            z3.Knjige.Add(k5);
            z3.Knjige.Add(k6);
            z3.Knjige.Add(k7);
            z6.Knjige.Add(k8);
            z4.Knjige.Add(k9);
            z3.Knjige.Add(k10);
            z3.Knjige.Add(k11);
            z5.Knjige.Add(k12);
            z3.Knjige.Add(k13);
            z3.Knjige.Add(k14);
            z3.Knjige.Add(k15);
            Zanrovi.Add(z3);
            Zanrovi.Add(z1);
            Zanrovi.Add(z2);
            Zanrovi.Add(z4);
            Zanrovi.Add(z5);
            Zanrovi.Add(z6);
            Zanrovi.Add(z7);


            Korisnik ko1 = new Korisnik("1", "Ognjen", "Sovilj");
            Korisnik ko2 = new Korisnik("2", "Milan", "Tripkovic");
            //  k1.Iznajmljene.Add(new Knjiga("1", "Na Drini ćuprija", "Ivo Andrić", "Ep", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica1.png")));

            // k2.Iznajmljene.Add(new Knjiga("1", "Na Drini ćuprija", "Ivo Andrić", "Ep", true, System.IO.Path.Combine(Environment.CurrentDirectory, "Ikonica1.png")));
            Korisnici.Add(ko1);
            Korisnici.Add(ko2);
           
           /*/
        }
        #endregion main










        #region 1tab
        private void knjigeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (knjigeListView.SelectedItem is Knjiga izabranaKnjiga)
            {
                sifraTextBox.Text = izabranaKnjiga.Sifra;
                naslovTextBox.Text = izabranaKnjiga.NaslovKnjige;
                autorTextBox.Text = izabranaKnjiga.Autor;
                zanrTextBox.Text = izabranaKnjiga.Zanr;
                dostupnostCB.IsChecked = izabranaKnjiga.Dostupnost;
                ikonicaTextBox.Text = izabranaKnjiga.Ikonica;
            }
        }

        public void DodajKnjigu(Knjiga novaKnjiga)
        {


            if (novaKnjiga.NaslovKnjige != "" && novaKnjiga.Sifra != "" && novaKnjiga.Autor != "" && novaKnjiga.Zanr != "")
            {
                //ovde cu dodadati za Id da ne bude isti
                int n = 0;
                foreach (Knjiga k in kolekcijaKnjiga)
                {
                    if (k.Sifra == novaKnjiga.Sifra)
                    {
                        MessageBox.Show("Vec postoji knjiga sa datom sifrom");
                        n = 1;

                    }

                }

                if (n == 0)
                {
                    //ovo je tvoje ispod
                    kolekcijaKnjiga.Add(novaKnjiga);
                    knjigeListView.Items.Refresh();
                    knjigeListView.ItemsSource = kolekcijaKnjiga;
                    //ovde sad dodajem za drugi deo da bi update moje stablo
                    int m = 0;
                    foreach (Zanr z in Zanrovi)
                    {
                        if (z.Naziv == novaKnjiga.Zanr)
                        {
                            z.Knjige.Add(novaKnjiga);
                            zanrdrvo.Items.Refresh();
                            m = 1;
                        }

                    }
                    if (m == 0)//ako je novi zanr
                    {
                        Zanr zn = new Zanr() { Naziv = novaKnjiga.Zanr };
                        zn.Knjige.Add(novaKnjiga);
                        Zanrovi.Add(zn);
                        zanrdrvo.Items.Refresh();
                       


                    }

                }
            }
            else MessageBox.Show("popunite sve ");
        }

        public void Importknjige(string file)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(file);

                while (!sr.EndOfStream)
                {
                    string linija = sr.ReadLine();
                    string[] delovi = linija.Split('|');

                    if (delovi.Length == 7)
                    {
                        string sifra = delovi[0];
                        string naslovKnjige = delovi[1];
                        string autor = delovi[2];
                        string zanr = delovi[3];
                        bool dostupnost = bool.Parse(delovi[4]);
                        string ikonica = delovi[5];
                        int bri = int.Parse(delovi[6]);

                        DodajKnjigu(new Knjiga(sifra, naslovKnjige, autor, zanr, dostupnost, ikonica, bri));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                sr?.Close();
            }
        }
        public void ImportKorisnik(string file)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string data = sr.ReadLine();
                    if (!string.IsNullOrEmpty(data))
                    {

                        Korisnik k = new Korisnik();
                        string[] parts = data.Split('_');


                        string Id = parts[0];
                        string Ime = parts[1];
                        string Prezime = parts[2];
                        k.Id = Id;
                        k.Ime = Ime;
                        k.Prezime = Prezime;


                        int Brk = int.Parse(parts[3]);
                        k.Brk = Brk;


                        string[] knjige = parts[4].Split(',');

                        //  MessageBox.Show(parts[5]);
                        foreach (string knjigaData in knjige)
                        {

                            if (!string.IsNullOrEmpty(knjigaData))
                            {

                                string[] delovi = knjigaData.Split('|');

                                if (delovi.Length == 7)
                                {
                                    string sifra = delovi[0];
                                    string naslovKnjige = delovi[1];
                                    string autor = delovi[2];
                                    string zanr = delovi[3];
                                    bool dostupnost = bool.Parse(delovi[4]);
                                    string ikonica = delovi[5];
                                    int bri = int.Parse(delovi[6]);

                                    k.Iznajmljene.Add(new Knjiga(sifra, naslovKnjige, autor, zanr, dostupnost, ikonica, bri));
                                   
                                }

                            }
                        }
                          
                            if (parts.Length >= 6)
                            {


                                string[] pracenjeData = parts[5].Split('`');
                                foreach (string kvpData in pracenjeData)
                                {
                                    if (!string.IsNullOrEmpty(kvpData))
                                    {
                                        // Split the key-value pair and create corresponding objects
                                        string[] kvpParts = kvpData.Split(',');
                                        if (kvpParts.Length == 2)
                                        {
                                            string[] delovi = kvpParts[0].Split('|');

                                            if (delovi.Length == 7)
                                            {


                                                string sifra = delovi[0];
                                                string naslovKnjige = delovi[1];
                                                string autor = delovi[2];
                                                string zanr = delovi[3];
                                                bool dostupnost = bool.Parse(delovi[4]);
                                                string ikonica = delovi[5];
                                                int bri = int.Parse(delovi[6]);

                                                Knjiga k1 = new Knjiga(sifra, naslovKnjige, autor, zanr, dostupnost, ikonica, bri);

                                                k.iznajmiknjigu2(k1, int.Parse(kvpParts[1][1].ToString()));




                                            }


                                        }
                                    }

                                }
                                Korisnici.Add(k);


                            }
                        }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
        public void Importzanr(string file)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(file);

                while (!sr.EndOfStream)
                {
                    string linija = sr.ReadLine();
                    Zanr z = new Zanr();
                    string[] delovi1 = linija.Split(',');


                    string naziv = delovi1[0];
                    z.Naziv = naziv;
                    string[] knjige = delovi1[0].Split('`');

                    foreach (string knjigaData in knjige)
                    {

                        if (!string.IsNullOrEmpty(knjigaData))
                        {

                            string[] delovi = knjigaData.Split('|');

                            if (delovi.Length == 7)
                            {
                                string sifra = delovi[0];
                                string naslovKnjige = delovi[1];
                                string autor = delovi[2];
                                string zanr = delovi[3];
                                bool dostupnost = bool.Parse(delovi[4]);
                                string ikonica = delovi[5];
                                int bri = int.Parse(delovi[6]);


                                z.Knjige.Add(new Knjiga(sifra, naslovKnjige, autor, zanr, dostupnost, ikonica, bri));






                            }
                        }
                    }
                    Zanrovi.Add(z);



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                sr?.Close();
            }
        }
       
        public void ClearFile(string file)
        {
            try
            {
                File.WriteAllText(file, string.Empty);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error clearing file: " + e.Message);
            }
        }



        private void DodajDugme_Click(object sender, RoutedEventArgs e)
        {
            DodajKnjiguWindow dodajKnjiguWindow = new DodajKnjiguWindow();
            dodajKnjiguWindow.ShowDialog();
        }

        private void IzmeniDugme_Click(object sender, RoutedEventArgs e)
        {


            if (knjigeListView.SelectedItem is Knjiga izabranaKnjiga)
            {

                string originalnaSifra = izabranaKnjiga.Sifra;
                string originalniNaslov = izabranaKnjiga.NaslovKnjige;
                string originalniAutor = izabranaKnjiga.Autor;
                string originalniZanr = izabranaKnjiga.Zanr;
                bool originalnaDostupnost = izabranaKnjiga.Dostupnost;
                string originalnaIkonica = izabranaKnjiga.Ikonica;

                IzmenaKnjigeWindow izmenaWindow = new IzmenaKnjigeWindow(izabranaKnjiga);

                bool? rezultat = izmenaWindow.ShowDialog();

                if (izmenaWindow.DialogResult == true)
                {
                    if (izabranaKnjiga.NaslovKnjige != "" && izabranaKnjiga.Sifra != "" && izabranaKnjiga.Autor != "" && izabranaKnjiga.Zanr != "")
                    {

                        foreach (Knjiga kn in kolekcijaKnjiga)//ovo sam ja dodao radi validacije
                        {
                            if (kn.Sifra == izabranaKnjiga.Sifra)
                            {
                                if (kn != izabranaKnjiga)
                                {
                                    if (izabranaKnjiga.Sifra != originalnaSifra)//da nebi kad se menja nes drugo ovo radilo
                                    {
                                        MessageBox.Show("Vec postoji knjiga sa datom sifrom tako da se knjiga nece izmeniti");
                                        izabranaKnjiga.Sifra = originalnaSifra;
                                        izabranaKnjiga.NaslovKnjige = originalniNaslov;
                                        izabranaKnjiga.Autor = originalniAutor;
                                        izabranaKnjiga.Zanr = originalniZanr;
                                        izabranaKnjiga.Dostupnost = originalnaDostupnost;
                                        izabranaKnjiga.Ikonica = originalnaIkonica;

                                        sifraTextBox.Text = originalnaSifra;
                                        naslovTextBox.Text = originalniNaslov;
                                        autorTextBox.Text = originalniAutor;
                                        zanrTextBox.Text = originalniZanr;
                                        dostupnostCB.IsChecked = originalnaDostupnost;
                                        ikonicaTextBox.Text = originalnaIkonica;
                                    }
                                }
                            }
                            else
                            {
                                knjigeListView.Items.Refresh();//ovo je tvoje samo sam stavio da se izvrsava ako nema isti id

                                


                            }


                        }
                        if (originalniZanr != izabranaKnjiga.Zanr)//ovo sam dodao da bi kod mene promenila zanr
                        {
                            int m = 0;
                            foreach (Zanr z in Zanrovi)
                            {
                                if (z.Naziv == originalniZanr)
                                {
                                    z.Knjige.Remove(izabranaKnjiga);
                                }
                                if (z.Naziv == izabranaKnjiga.Zanr)
                                {
                                    z.Knjige.Add(izabranaKnjiga);
                                    m = 1;
                                }
                            }
                            if (m == 0)
                            {
                                Zanr zn = new Zanr() { Naziv = izabranaKnjiga.Zanr };
                                zn.Knjige.Add(izabranaKnjiga);
                                Zanrovi.Add(zn);
                                zanrdrvo.Items.Refresh();

                            }
                        }


                        // Ažuriranje knjige na osnovu rezultata izmene
                        sifraTextBox.Text = izabranaKnjiga.Sifra;
                        naslovTextBox.Text = izabranaKnjiga.NaslovKnjige;
                        autorTextBox.Text = izabranaKnjiga.Autor;
                        zanrTextBox.Text = izabranaKnjiga.Zanr;
                        dostupnostCB.IsChecked = izabranaKnjiga.Dostupnost;
                        ikonicaTextBox.Text = izabranaKnjiga.Ikonica;
                        knjigeListView.Items.Refresh();
                    }
                    else {
                        izabranaKnjiga.Sifra = originalnaSifra;
                        izabranaKnjiga.NaslovKnjige = originalniNaslov;
                        izabranaKnjiga.Autor = originalniAutor;
                        izabranaKnjiga.Zanr = originalniZanr;
                        izabranaKnjiga.Dostupnost = originalnaDostupnost;
                        izabranaKnjiga.Ikonica = originalnaIkonica;

                        sifraTextBox.Text = originalnaSifra;
                        naslovTextBox.Text = originalniNaslov;
                        autorTextBox.Text = originalniAutor;
                        zanrTextBox.Text = originalniZanr;
                        dostupnostCB.IsChecked = originalnaDostupnost;
                        ikonicaTextBox.Text = originalnaIkonica;


                        MessageBox.Show("ne moze prazan"); }
                }
                else if (izmenaWindow.DialogResult == false)
                {
                    sifraTextBox.Text = originalnaSifra;
                    naslovTextBox.Text = originalniNaslov;
                    autorTextBox.Text = originalniAutor;
                    zanrTextBox.Text = originalniZanr;
                    dostupnostCB.IsChecked = originalnaDostupnost;
                    ikonicaTextBox.Text = originalnaIkonica;
                    // Odbijanje izmena - ne preduzima se ništa
                }
            }
            knjigeListView.ItemsSource = kolekcijaKnjiga;
        }



        private void UkloniDugme_Click(object sender, RoutedEventArgs e)
        {
            if (knjigeListView.SelectedItem is Knjiga izabranaKnjiga)
            {
                MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete knjigu?", "Potvrda brisanja", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {
                    kolekcijaKnjiga.Remove(izabranaKnjiga);


                    sifraTextBox.Text = string.Empty;
                    naslovTextBox.Text = string.Empty;
                    autorTextBox.Text = string.Empty;
                    zanrTextBox.Text = string.Empty;
                    dostupnostCB.IsChecked = false;

                    foreach (Zanr z in Zanrovi)//da bi mi brisalo iz stabla sam ovo dodao
                    {
                        if (z.Naziv == izabranaKnjiga.Zanr)
                        {
                            z.Knjige.Remove(izabranaKnjiga);
                            zanrdrvo.Items.Refresh();


                        }

                    }

                  
                    foreach (Korisnik k in Korisnici)
                    {
                      
                        

                        foreach (Knjiga a in k.Iznajmljene)
                        {
                           
                            if (a.NaslovKnjige == izabranaKnjiga.NaslovKnjige)
                            {
                              //  MessageBox.Show("");
                                k.Iznajmljene.Remove(a);
                                k.Brk = k.Brk - 1;
                                zanrdrvo.Items.Refresh();
                                knjigeListView.Items.Refresh();

                                break;

                            }


                        }
                       
                           
                          



                        
                    }    }
            }
            knjigeListView.Items.Refresh();
            knjigeListView.ItemsSource = kolekcijaKnjiga;

        }

        private void PretraziListuKnjiga_Click(object sender, RoutedEventArgs e)
        {
            if (dostupnostPretragaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Izaberite dostupnost knjige.");
                return;
            }

            string naslov = naslovPretragaTextBox.Text;
            string autor = autorPretragaTextBox.Text;

            string dostupnostPretraga = ((ComboBoxItem)dostupnostPretragaComboBox.SelectedItem)?.Content.ToString();

            List<Knjiga> rezultatiPretrage = kolekcijaKnjiga
                .Where(k =>
                    (string.IsNullOrEmpty(naslov) || k.NaslovKnjige.ToLower().Contains(naslov.ToLower())) &&
                    (string.IsNullOrEmpty(autor) || k.Autor.ToLower().Contains(autor.ToLower())) &&
                    (dostupnostPretraga == "Sve" || (dostupnostPretraga == "Dostupne" && k.Dostupnost) || (dostupnostPretraga == "Nedostupne" && !k.Dostupnost)))
                .ToList();

            knjigeListView.ItemsSource = rezultatiPretrage;
        }
        #endregion 1tab
        #region 2tab
        //ovde su moje
        private void dugme_Click(object sender, RoutedEventArgs e)
        {
            Window1 dodajKorWindow = new Window1();
            dodajKorWindow.ShowDialog();
        }
        public void Dodajkorisnika(Korisnik nkorisnik)
        {
            if (nkorisnik.Id != "" && nkorisnik.Ime != "" && nkorisnik.Prezime != "")
            {
                int m = 0;
                foreach (Korisnik k in Korisnici)
                {
                    if (k.Id == nkorisnik.Id)
                    {
                        MessageBox.Show("Vec postoji korisnik sa ovim ID-jem");
                        m = 1;
                    }
                    else
                    {
                        // m = 1;
                        //Korisnici.Add(nkorisnik);
                        //  korisnicidrvo.Items.Refresh();
                    }

                }
                if (m != 1)
                {
                    Korisnici.Add(nkorisnik);
                    korisnicidrvo.Items.Refresh();
                }
            }
       else MessageBox.Show("unesite sve");
        }


        //drag and drop
        public class DraggedItem
        {
            public object Data { get; set; }
            public TreeViewItem SourceItem { get; set; }
        }
        private DraggedItem draggedItem;

        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T ancestor)
                {
                    return ancestor;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);

            return null;
        }


        private void TreeView1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem treeViewItem = FindAncestor<TreeViewItem>((DependencyObject)e.OriginalSource);
            if (treeViewItem != null)
            {
                draggedItem = new DraggedItem
                {
                    Data = treeViewItem.DataContext,
                    SourceItem = treeViewItem
                };
            }
        }

        private void TreeView1_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && draggedItem != null)
            {
                Point currentPosition = e.GetPosition(zanrdrvo);

                if (Math.Abs(currentPosition.X - draggedItem.SourceItem.ActualWidth / 2) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(currentPosition.Y - draggedItem.SourceItem.ActualHeight / 2) > SystemParameters.MinimumVerticalDragDistance)
                {
                    Knjiga knjiga = draggedItem.Data as Knjiga;
                    if (knjiga != null)//ako pokusa zanr da ne da
                    {
                        DragDrop.DoDragDrop(zanrdrvo, draggedItem, DragDropEffects.Move);
                    }
                }
            }
        }

        private void TreeView2_PreviewDragEnter(object sender, DragEventArgs e)
        {
            // dozvoljava drop samo ako je knjiga

            if (!e.Data.GetDataPresent(typeof(DraggedItem)) || !(e.Source is TreeView))
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = true;
        }

        private void TreeView2_Drop(object sender, DragEventArgs e)
        {
            TreeViewItem targetItem = FindAncestor<TreeViewItem>((DependencyObject)e.OriginalSource);
            if (targetItem != null && draggedItem != null)
            {
                Korisnik korisnik = targetItem.DataContext as Korisnik;
                if (korisnik != null)
                {
                    // uzima privucen podatak
                    Knjiga knjiga = draggedItem.Data as Knjiga;
                    knjiga.Dostupnost = false;
                    draggedItem.SourceItem.IsEnabled = false;


                    knjigeListView.Items.Refresh();//za listu da se update
                    zanrdrvo.Items.Refresh();


                    // drop
                    if (knjiga != null)
                    {
                        korisnik.Iznajmljene.Add(knjiga);
                        korisnik.iznajmiknjigu(knjiga);
                        knjiga.Bri += 1;
                        korisnik.Brk += 1;


                    }
                }

                draggedItem = null;
            }
        }
        private Knjiga selectedBook;

        private void KorisnikTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (korisnicidrvo.SelectedItem is Knjiga selectedBook)
            {
                this.selectedBook = selectedBook;
            }
        }

        private void dugme2_Click(object sender, RoutedEventArgs e)
        {
            if (selectedBook != null)
            {
               
                Korisnik q = new Korisnik();
                foreach (Korisnik k in Korisnici)
                {
                    int n = 0;

                    foreach (Knjiga a in k.Iznajmljene)
                    {
                        if (a == selectedBook)
                        {
                            n = 1;
                            q = k;

                        }


                    }
                    if (n == 1)
                    {
                     
                        q.Iznajmljene.Remove(selectedBook);
                        q.Brk = q.Iznajmljene.Count();
                      
                        foreach(Zanr z in Zanrovi)
                        {
                           
                            foreach (Knjiga f in z.Knjige)
                            {
                              
                                if (f.NaslovKnjige == selectedBook.NaslovKnjige)
                                {
                                  //  MessageBox.Show(selectedBook.ToString());
                                    f.Dostupnost = true;
                                }


                            }


                        }


                        zanrdrvo.Items.Refresh();
                        knjigeListView.Items.Refresh();
                      
                        TreeViewItem itemContainer = nadji(zanrdrvo, selectedBook);
                     
                        if (itemContainer != null)
                        {
                          
                            itemContainer.IsEnabled = true;
                        }
                        selectedBook.Dostupnost = true;


                    }





                }

            }
            else
            {
                MessageBox.Show("izaberite knjigu ako hocete da je vratite");
            }

        }





        private TreeViewItem nadji(ItemsControl drvo, object knjiga)
        {
            if (drvo != null)
            {
                if (drvo.ItemContainerGenerator.ContainerFromItem(knjiga) is TreeViewItem trazen)
                {
                    return trazen;
                }


                for (int i = 0; i < drvo.Items.Count; i++)
                {
                    if (drvo.ItemContainerGenerator.ContainerFromIndex(i) is TreeViewItem trazen2)
                    {
                        TreeViewItem resultContainer = nadji(trazen2, knjiga);
                        if (resultContainer != null)
                        {
                            return resultContainer;
                        }
                    }
                }
            }

            return null;
        }


        #endregion 2tab

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClearFile("export.txt");
            foreach (Knjiga k in kolekcijaKnjiga)
            {
                k.Exportknjgie("export.txt");

            }
            ClearFile("export1.txt");
            foreach (Korisnik k in Korisnici)
            {
                k.Exportkorsinik("export1.txt");

            }
            foreach (Zanr k in Zanrovi)
            {
                k.Exportzanr("export2.txt");

            }
            MessageBox.Show("Fajl je uspesno sacuvan");

        }
    }
   
   
    
    }
