using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    public class befektetes:INotifyPropertyChanged
    {
        public double osszeg;
        public double kamatlab;
        public double ido;
        public double eredmeny;

        public double Osszeg
        {
            get { return osszeg;}
            set { osszeg =value; OnPropertyChanged("Eredmeny"); }
        }

        public double Kamatlab
        {
            get { return kamatlab;}
            set { kamatlab = value; OnPropertyChanged("Eredmeny"); }
        }

        public double Ido
        {
            get { return ido;}
            set { ido = value; OnPropertyChanged("Eredmeny"); }
        }

        public double Eredmeny
        {
            get 
            {
                double er =osszeg * Math.Pow((1 + (kamatlab / 100)), ido);
                return er;

            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
