using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.PointOfService;

namespace SWDprojekt
{
    class Booking
    {
        public ObservableCollection<Deltager> Deltagere { get; set; }
        public DateTime Dato{ get; set; }
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
    }
}
