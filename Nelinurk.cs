using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_loomine_tsekotina
{
    class Nelinurk
    {
        int korgus;
        int laius;

        public Nelinurk() { }
        public Nelinurk(int Korgus, int Laius)
        {
            korgus = Korgus;
            laius = Laius;
        }
        public string Tuup
        {
            get
            {
                var tuup = " ";
                if (laius == korgus)
                {
                    tuup = "ruut";
                }
                else
                {
                    tuup = "ristküülik";
                }

                return tuup;
            }
        }
        public int Korgus
        {
            set { korgus = value; }
            get { return korgus; }
        }
        public int Laius
        {
            set { laius = value; }
            get { return laius; }
        }
        public int P
        {
            get
            {
                int P = 0;
                P = korgus + laius;
                return P;
            }
        }
        public int S
        {
            get
            {
                int S = 0;
                S = korgus * laius;
                return S;
            }
        }
        public void Tüüp()
        {
            Console.WriteLine("See on {0}", Tuup);
        }
        public void P_S()
        {
            Console.WriteLine("Tema P = {0} cm ja tema S = {1} cm2", P, S);
        }





    }
}