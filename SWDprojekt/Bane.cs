using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDprojekt
{
    class Bane
    {
        public int BaneID{ get; set; }
        public bool Bander{ get; set; }

        public Bane(int baneId, bool bander){
            BaneID = baneId;
            Bander = bander;
        }
    }
}
