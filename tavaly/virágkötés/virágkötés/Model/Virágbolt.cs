using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virágkötés.Model
{
    public class Virágbolt
    {
        public int tulipan;
        public int rosza;
        public int narcisz;
        public int osszeg;

        public Virágbolt()
        {
            tulipan = 1;
            rosza = 1;
            narcisz = 1;
        }

        public int Tulipandb
        {
            get { return tulipan; }
            set { tulipan = value; }
        }

        public int Roszadb
        {
            get { return rosza; }
            set { rosza = value; }
        }

        public int Narciszdb
        {
            get { return narcisz; }
            set { narcisz = value; }
        }

        public int Vegosszeg
        {
            get 
            {
                int osszeg = (300 * tulipan) + (500 * rosza) + (400 * narcisz);
                return osszeg;
            }
        }
    }
}
