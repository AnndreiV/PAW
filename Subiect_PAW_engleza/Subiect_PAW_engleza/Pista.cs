using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_PAW_engleza
{
    [Serializable]
    public class Pista
    {
        public List<Zbor> listaZboruri { get; set; }
        public string denumirePista { get; set; }
        
        public Pista()
        {
            listaZboruri= new List<Zbor>();
            this.denumirePista = "Necunoscuta";
        }
        public Pista(List<Zbor> listaZboruri, string denumirePista):this()
        {
            this.listaZboruri = listaZboruri;
            this.denumirePista = denumirePista;
        }
        public override string ToString()
        {
            return "Lista zboruri pentru pista " + denumirePista + Environment.NewLine;
        }
    }
}
