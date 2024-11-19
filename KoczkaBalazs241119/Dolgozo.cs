using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoczkaBalazs241119
{
    internal class Dolgozo
    {
        public string Nev { get; set; }
        public bool Nem { get; set; }
        public string Reszleg { get; set; }
        public int BelepesEv { get; set; }
        public int Ber { get; set; }
        public override string ToString() =>
        $"{Nev} [{(Nem ? "Férfi" : "Nő")}] ({Reszleg}) Belépés: {BelepesEv} Bér: {Ber} Ft";
        public Dolgozo(string mhfu)
        {
            var c = mhfu.Split(';');
            Nev = c[0];
            Nem = c[1] == "férfi";
            Reszleg = c[2];
            BelepesEv = int.Parse(c[3]);
            Ber = int.Parse(c[4]);
        }
    }
}
