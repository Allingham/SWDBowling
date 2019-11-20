using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.PointOfService;
using SWDprojekt.Annotations;

namespace SWDprojekt
{
    class Booking : INotifyPropertyChanged
    {
        private DateTime _dato;
        public ObservableCollection<Deltager> Deltagere { get; set; }

        public DateTime Dato{
            get => _dato;
            set { _dato = value;
                OnPropertyChanged();
            }
        }

        public Bane ValgtBane{ get; set; }
        public ObservableCollection<Bane> Baner { get; set; }

        public Booking(){
            Deltagere = new ObservableCollection<Deltager>();
            Baner = new ObservableCollection<Bane>();
            Dato = DateTime.Now;

            Baner.Add(new Bane(1,false));
            Baner.Add(new Bane(2,true));

        }
        
     

        public void Add(String name, bool voksen)
        {
            Deltagere.Add(new Deltager(name, voksen));
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
