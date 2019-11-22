using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_22_SQLite
{
    class Rendezo
    {
        int id;
        string nev;
        string szarmazas;
        DateTime szul_datum;

        public Rendezo(int id, string nev, string szarmazas, DateTime szul_datum)
        {
            this.id = id;
            this.nev = nev;
            this.szarmazas = szarmazas;
            this.szul_datum = szul_datum;
        }

        public int Id { get => id; }
        public string Nev { get => nev; set => nev = value; }
        public string Szarmazas { get => szarmazas; set => szarmazas = value; }
        public DateTime Szul_datum { get => szul_datum; set => szul_datum = value; }

        public override string ToString()
        {
            return nev;
        }
    }
}
