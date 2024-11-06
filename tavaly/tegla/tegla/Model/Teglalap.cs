using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tegla.Model
{
    public class Teglalap
    {
        public double oldal_1;
        public double oldal_2;
        public double terulet;
        public double kerulet;
        public double atlo;

        public Teglalap()
        {
            oldal_1 = 1;
            oldal_2 = 2;
        }

        public double Oldal1
        {
            get { return oldal_1; }
            set { oldal_1 = value; }
        }

        public double Oldal2
        {
            get { return oldal_2; }
            set { oldal_2 = value; }
        }

        public double Terulet
        {
            get { double ered= oldal_1*oldal_2; return ered; } 
        }

        public double Kerulet
        {
            get { double ered = 2 * (oldal_1 + oldal_2); return ered; }
        }

        public double Atlo
        {
            get { double ered = Math.Sqrt(Math.Pow(oldal_1,2) +Math.Pow(Oldal2,2)); return ered; }
        }
    }
}
