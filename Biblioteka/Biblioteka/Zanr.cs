using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using System.IO;

namespace Biblioteka
{

    public class Zanr : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string naziv;
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                if (naziv != value)
                {
                    naziv = value;
                    OnPropertyChanged("Naziv");
                }
            }
        }


        public ObservableCollection<Knjiga> Knjige
        {
            get;
            set;
        }

        public Zanr()
        {
            Naziv = "";
            Knjige = new ObservableCollection<Knjiga>();

        }


        public override string ToString()
        {
            string ret = naziv + ",";
            foreach (Knjiga k in Knjige)
            {
                ret = ret + k + "`";

            }


            return ret;
        }

        public void Exportzanr(string file)
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

