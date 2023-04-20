using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectEngleza___ListView
{
    [Serializable]
    public class Pista
    {
        public string denumire { get; set; }
        public List<Zbor> listaZboruri { get; set; }
        public Pista()
        {
            listaZboruri= new List<Zbor>();
            denumire = "Bucuresti International Airport";
        }
        public Pista(string denumire, List<Zbor> listaZboruri):this()
        {
            this.denumire = denumire;
            this.listaZboruri = listaZboruri;
        }

        public override string ToString()
        {
            return denumire + Environment.NewLine;
        }
    }
}
