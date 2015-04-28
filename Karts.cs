using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Karsu_Spele1
{
    public enum Masts { Pikis, Kreicis, Ercens, Karavs }
    public enum Vertiba { Divi, Tris, Cetri, Pieci, Sesi, Septini, Astoni, Devini, Desmit, Kalps, Dama, Kungs, Duzis}
    public class Karts
    {
        Masts masts;
        Vertiba vertiba;
        Image attels;

        internal Masts Masts
        {
            get { return masts; }
            set { masts = value; }
        }

        internal Vertiba Vertiba
        {
            get { return vertiba; }
            set { vertiba = value; }
        }

        public Image Attels
        {
            get { return attels; }
            set { attels = value; }
        }

        public Karts(Masts m, Vertiba v){
            this.Masts = m;
            this.Vertiba = v;
            this.Attels = KartsAtteli.GetAttelu(this.Masts+"_"+this.Vertiba);
        }

        public override string ToString()
        {
            return masts + " " + vertiba;
        }

    }
}

