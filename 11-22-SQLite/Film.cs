using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_22_SQLite
{
    class Film
    {
        int id;
        string cim;
        int hossz;
        DateTime kiadas;
        int rendezo_id;

        public Film(int id, string cim, int hossz, DateTime kiadas, int rendezo_id)
        {
            this.id = id;
            this.cim = cim;
            this.hossz = hossz;
            this.kiadas = kiadas;
            this.rendezo_id = rendezo_id;
        }

        public int Id { get => id; }
        public string Cim { get => cim; set => cim = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public DateTime Kiadas { get => kiadas; set => kiadas = value; }
        public int Rendezo_id { get => rendezo_id; set => rendezo_id = value; }

        public override string ToString()
        {
            return cim;
        }
    }
}
