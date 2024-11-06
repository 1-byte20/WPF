using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BaseClass;
using virágkötés.Model;

namespace virágkötés.WiewModel
{
    public class ViragViewModel:ViewModelBase
    {
        public Virágbolt v;

        public RelayCommand Calculate {  get; set; }

        public ViragViewModel()
        {
            v= new Virágbolt();
            Calculate = new RelayCommand(execute => Calculation());
        }

        public string Tulipan
        {
            get { return v.Tulipandb.ToString(); }
            set { v.Tulipandb = Convert.ToInt32(value);}
        }

        public string Rozsa
        {
            get { return v.Roszadb.ToString(); }
            set { v.Roszadb = Convert.ToInt32(value); }
        }

        public string Narcisz
        {
            get { return v.Narciszdb.ToString(); }
            set { v.Narciszdb = Convert.ToInt32(value); }
        }

        public string Osszeg
        {
            get 
            { 
                return v.Vegosszeg.ToString();
            }
        }

        public void Calculation()
        {
            OnPropertyChanged("Osszeg");
        }
    }
}
