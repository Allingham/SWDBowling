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

        public Booking(ObservableCollection<Deltager> delagere, DateTime dato, Bane valgtBane){
            Deltagere = delagere;
            Dato = dato;
            ValgtBane = valgtBane;
        }

     

        public void Add(String name, bool voksen)
        {
            Deltagere.Add(new Deltager(name, voksen));
        }
    }
}
