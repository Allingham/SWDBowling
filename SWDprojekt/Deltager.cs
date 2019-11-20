using Windows.UI.Xaml.Controls;

namespace SWDprojekt{
    public class Deltager{
        public string Navn{ get; set; }
        public bool Voksen{ get; set; }
        

        public Deltager(string navn, bool voksen)
        {
            Navn = navn;
            Voksen = voksen;
        }
    }
}