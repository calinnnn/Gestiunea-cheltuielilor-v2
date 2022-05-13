using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiunea_Cheltuielilor
{
    class Calcule
    {
        public int venituri { get; set; }
        public int cheltuieli { get; set; }
        public int economii { get; set; }


        public Calcule()
        {
            venituri = 0;
            cheltuieli = 0;
            economii = 0;
        }

        public Calcule(int ven, int chel, int econ)
        {
            venituri = ven;
            cheltuieli = chel;
            economii = econ;
        }

        
        public string ConversieLaSir
        {
            get
            {
                return "veniturile sunt " + venituri+"lei, din care " + cheltuieli + " sunt taxele la stat, astfel va ramane: " + economii;
            }
        }
    }
}
