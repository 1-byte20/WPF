using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulaProjekt.Model
{
    public class Gula : INotifyPropertyChanged
    {
        public double alaplap;
        public double palast;
        public double magassag;
        public double felszin;
        public double terfogat;

        public Gula()
        {
            alaplap = 1;
            palast=1;
            magassag = 1;
        }

        public double Alaplap
        {
            get { return alaplap;}
            set { alaplap = value; }
        }

        public double Palast
        {
            get { return palast; }
            set { palast = value; }
        }

        public double Magassag
        {
            get { return magassag; }
            set { magassag = value; } 
        }

        public double Felszin
        {
            get { double equal = Alaplap + Palast; return equal; }

        }

        public double Terfogat
        {
            get { double equal = (Alaplap * Magassag) / 3; return equal; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }


}
