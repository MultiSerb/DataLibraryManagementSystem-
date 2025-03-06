using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.IO;

namespace Biblioteka

{
  
    public class Korisnik : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private string id;
        private string ime;
        private string prezime;
        private int brk;
        private ObservableCollection<Knjiga> iznajmljene = new ObservableCollection<Knjiga>();
        private Dictionary<Knjiga, int> pracenje=new Dictionary<Knjiga, int>();
        private Knjiga oknjiga;

       



        public Knjiga Oknjiga
        {
            get { return oknjiga; }
            set
            {
                oknjiga = value;
                OnPropertyChanged("Oknjiga");

            }
        }
        public int Brk
        {
            get { return brk; }
            set
            {
                brk = value;
                OnPropertyChanged("brk");

            }
        }
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");

            }
        }

        public string Ime
        {
            get { return ime; }
            set 
            { 
                ime = value;
                OnPropertyChanged("Ime");

            }
        }
        public string Prezime
        {
            get { return prezime; }
            set
            {
                prezime = value;
                OnPropertyChanged("Prezime");

            }
        }


        public ObservableCollection<Knjiga> Iznajmljene
        {
                get
                {
                    return iznajmljene;
                }
                set
                {
                iznajmljene = value;

                 }
            }
        public Korisnik()
        {
            Id = "";
            Ime = "";
            Prezime = "";
            Brk = 0;
           
          

        }
        public Korisnik(string s, string n, string a)
        {
            Id = s;
            Ime = n;
            Prezime = a;
            Brk = 0;
           

        }
        public void iznajmiknjigu(Knjiga book)
        {
            if (pracenje.ContainsKey(book))
            {
                pracenje[book]++;
            }
            else
            {
                pracenje.Add(book, 1);
            }

            // bira omiljenu
            Oknjigaf();
        }
        public void iznajmiknjigu2(Knjiga book,int a)
        {
            if (pracenje.ContainsKey(book))
            {
                pracenje[book]++;
            }
            else
            {
                pracenje.Add(book, a);
            }

            // bira omiljenu
            Oknjigaf();
        }
        private void Oknjigaf()
        {
            Oknjiga = pracenje.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        }

        public override string ToString()
        {
            string ret = Id + "_" + Ime + "_" + Prezime + "_" + Brk+"_";

            foreach (Knjiga knjiga in iznajmljene)
            {
                ret = ret + knjiga+",";
            }
            ret = ret + "_";
            foreach (KeyValuePair<Knjiga, int> kvp in pracenje)
            {
                ret = ret + kvp+"`";
            }



            return ret;
        }

        public void Exportkorsinik(string file)
        {


            try
            {


                using (StreamWriter writer = new StreamWriter(file, true))
                {
                    writer.WriteLine(this);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
