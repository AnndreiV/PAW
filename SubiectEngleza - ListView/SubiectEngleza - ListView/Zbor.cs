using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectEngleza___ListView
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
            capacitate = 0;
            destinatie = "Necunoscuta";
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
            return "Numar zbor: " + nrZbor + " Destinatie: " + destinatie + " Capacitate: " + capacitate + Environment.NewLine;
        }


    }
}
