using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaEncapsulamento
{
    class Notas
    {
        public double NP1 { get; set; }
        public double NP2 { get; set; }
        public double PIM { get; set; }
        public double MeP { get; set; }

        public Notas()
        {
            NP1 = 0;
            NP2 = 0;
            PIM = 0;
            MeP = 0;
        }

        public void CalculaMedia()
        {
            MeP = (NP1 * 0.4) + (NP2 * 0.4) + (PIM * 0.2); 
        }




        #region Metodo Professor
        //private double np1;
        //private double np2;
        //private double pim;
        //private double mp;

        //public Notas()
        //{
        //    this.np1 = 0;
        //    this.np2 = 0;
        //    this.pim = 0;
        //    this.mp = 0;
        //}

        //public double NP1 { get; set; }

        //public double NP2 { get; set; }
        //public double PIM { get; set; }
        //public double MP { get; set; }


        //
        //public double getNP1()
        //{
        //    return np1;
        //}

        //public void setNP1(double np1)
        //{
        //    this.np1 = np1 * 0.4;
        //}
        //public double getNP2()
        //{
        //    return np2;
        //}

        //public void setNP2(double np2)
        //{
        //    this.np2 = np2 * 0.4;
        //}

        //public double getPIM()
        //{
        //    return pim;
        //}

        //public void setPIM(double pim)
        //{
        //    this.pim = pim * 0.2;
        //}

        //public void CalculaMedia()


        //{
        //    this.mp = np1 + np2 + pim;
        //}

        //public double getMP()
        //{
        //    return mp;
        //}
        #endregion
    }
}
