using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gúla.Model
{
    public class Gula
    {
        private double alapterulet;
        private double palast;
        private double magasv;

        public Gula()
        {
            alapterulet = 0;
            palast = 0;
            magasv = 0;
        }
        public double Alapterulet
        {
            set
            {
                alapterulet = value;
                OnPropertyChanged("Gúla");
            }
        }
        public double Palast
        {
            set
            {
                palast = value;
                OnPropertyChanged("Gúla");
               
            }
        }

        public double Magasv
        {
            set
            {
                magasv = value;
                OnPropertyChanged("BetegAdatok");
            
            }
        }

        public double Felsz
        {
            get
            {
                double felsz = alapterulet + palast;
                return felsz;
            }
        }

        public double Terfog
        {
            get
            {
                double terfog = (alapterulet + magasv) / 3;
                return terfog;
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
