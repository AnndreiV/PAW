using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_PAW_engleza
{
    [Serializable]
    public class Zbor:IComparable<Zbor>
    {
        public int nrZbor { get; set; }
        public string destinatie { get; set; }
        public int capacitate { get; set; }

        public Zbor()
        {
            nrZbor = 0;
            destinatie = "Necunoscuta";
            capacitate = 0;
        }
        public Zbor(int nrZbor, string destinatie, int capacitate)
        {
            this.nrZbor = nrZbor;
            this.destinatie = destinatie;
            this.capacitate = capacitate;
        }

        public int CompareTo(Zbor other)
        {
            return this.capacitate.CompareTo(other.capacitate);
        }

        public override string ToString()
        {
            return "Zbor: " + nrZbor + " Destinatie: " + destinatie + " Capacitate: " + capacitate + Environment.NewLine;

        }
    }
        
}
