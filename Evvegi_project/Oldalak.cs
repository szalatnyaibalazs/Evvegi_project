using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evvegi_project
{
    class Oldalak
    {
        string oldal;
        string szoveg;
        public string Oldal { get { return oldal; } }
        public string Szoveg { get { return szoveg; } }


        public Oldalak(string oldal, string szoveg)
        {
            this.oldal = oldal;
            this.szoveg = szoveg;
        }
    }
}
