using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaEncapsulamento
{
    class Notas
    {
        private double np1;
        private double np2;
        private double pim;
        private double media;

        public Notas()
        {
            np1 = 0;
            np2 = 0;
            pim = 0;
            media = 0;
        }

        public double NP1
        {
            get { return np1; }
            set { this.np1 = value; }
        }

        public double NP2
        {
            get { return np2; }
            set { this.np2 = value; }
        }

        public double PIM
        {
            get { return pim; }
            set { this.pim = value; }
        }

        public double Media
        {
            get { return media; }
        }


        public void CalculaMedia()
        {
            media = (NP1 * 0.4) + (NP2 * 0.4) + (PIM * 0.2); 
        }
    }
}
