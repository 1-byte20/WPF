using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using tegla.Model;
using ViewModels.BaseClass;

namespace tegla.ViewModel
{
    public class TeglalapViewModel:ViewModelBase
    {
        public Teglalap t;
        public RelayCommand CalculateCommand { get; set; }
        public RelayCommand CloseCommand { get; set; }

        public TeglalapViewModel()
        {
            t = new Teglalap();
            CalculateCommand = new RelayCommand(execute => Calculate());
            CloseCommand = new RelayCommand(execute => Close());
        }
        public string Oldal_1
        {
            get { return t.Oldal1.ToString(); }
            set { t.Oldal1 = Convert.ToDouble(value); }
        }
        public string Oldal_2
        {
            get { return t.Oldal2.ToString(); }
            set { t.Oldal2 = Convert.ToDouble(value); }
        }

        public string Terulet
        {
            get { return t.Terulet.ToString(); }
            
        }

        public string Kerulet
        {
            get { return t.Kerulet.ToString(); }

        }

        public string Atlo
        {
            get { return t.Atlo.ToString(); }
        }

        public void Calculate()
        {
            OnPropertyChanged("Terulet");
            OnPropertyChanged("Kerulet");
            OnPropertyChanged("Atlo");
        }

        public void Close()
        {
            Application.Current.MainWindow.Close();
        }

    }

    
}
