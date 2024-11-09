using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GulaMVVM.model
{
    public class Gula
    {
        public double alapTerulet;
        public double magassag;
        public double terfogat;
        public double felszin;

        public double AlapTerulet
        {

            get => alapTerulet;
            set
            {
                alapTerulet = value;
                OnPropertyChanged();
                SzamoljEredmenyek();
            }
        }

        public double Magassag
        {
            get => magassag;
            set
            {
                magassag = value;
                OnPropertyChanged();
                SzamoljEredmenyek();
            }
        }

        public double Terfogat
        {
            get => terfogat;
            private set
            {
                terfogat = value;
                OnPropertyChanged();
            }
        }

        public double Felszin
        {
            get => felszin;
            private set
            {
                felszin = value;
                OnPropertyChanged();
            }
        }

        public Gula()
        {
            // Kezdőértékek
            alapTerulet = 0;
            magassag = 0;
        }

        private void SzamoljEredmenyek()
        {
            var gula = new Gula(AlapTerulet, Magassag);
            Terfogat = gula.SzamoljTerfogat();
            Felszin = gula.SzamoljFelszin(OldallapTeruletekOsszege()); // Oldal területek összegének megadása
        }

        // Oldallapok területeinek példakénti kiszámítása (feltételezett értékek)
        private double OldallapTeruletekOsszege()
        {
            return 4 * 10; // Példaérték: 4 oldallap, mindegyik 10 egységnyi területtel
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Gula(double alapTerulet, double magassag)
        {
            AlapTerulet = alapTerulet;
            Magassag = magassag;
        }

        // Térfogat kiszámítása
        public double SzamoljTerfogat()
        {
            return (1.0 / 3.0) * AlapTerulet * Magassag;
        }

        // Felszín kiszámítása (példa háromszög alapú gúla esetén)
        public double SzamoljFelszin(double oldalTeruletekOsszege)
        {
            return AlapTerulet + oldalTeruletekOsszege;
        }
    }
}

