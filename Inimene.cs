using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_loomine_tsekotina
{
    class Inimene
    {
        string eesnimi;
        string perenimi;
        string staatus;
        string palk_staatus;
        int vanus;
        string inimene_sugu;
        int palk;
        Emakeel emakeel;
        public Inimene() { }
        public Inimene(string Perenimi, Emakeel emakeel)
        {
            perenimi = Perenimi;
            this.emakeel = emakeel;
        }
        public Inimene(string Nimi, string Perenimi, int Vanus)
        {
            eesnimi = Nimi;
            perenimi = Perenimi;
            vanus = Vanus;
        }

        public Emakeel Emakeel
        {
            get { return emakeel; }
        }
        public string Nimi
        {
            set { eesnimi = value; }
            get { return eesnimi; }
        }
        public string Perenimi
        {
            set { if (perenimi == null) perenimi = value; }
            get { return perenimi; }
        }
        public int Vanus
        {
            set
            {
                vanus = value;
            }
            get { return vanus; }
        }
        public string Staatus
        {
            get
            {
                if (vanus < 7)
                {
                    staatus = "laps";
                }
                else if (vanus < 17)
                {
                    staatus = "koolilaps";
                }
                else if (vanus < 24)
                {
                    staatus = "ülikoolilaps";
                }
                else if (vanus < 60)
                {
                    staatus = "tööline";
                }
                else
                {
                    staatus = "pensionäär";
                }
                return staatus;
            }
        }
        public string Inimene_sugu
        {
            set { inimene_sugu = value; }
            get { return inimene_sugu; }
        }
        public int Palk
        {
            set
            {
                palk = value;
                if (palk < 600)
                {
                    palk_staatus = "väike tulud ";
                }
                else if (palk > 600)
                {
                    palk_staatus = "keskmine tulud ";
                }
                else if (palk > 1000)
                {
                    palk_staatus = "head tulud ";
                }
                else if (palk > 5000)
                {
                    palk_staatus = "suur tulud ";
                }
            }

            get { return palk; }
        }
        public void Tervitamine()
        {
            if (perenimi != null && eesnimi != null)
            {
                Console.WriteLine("Tere! Minu nimi on {0} {1} ", eesnimi, perenimi);
            }
            else if (perenimi == null && eesnimi != null)
            {
                Console.WriteLine("Tere! Minu perenimi on " + eesnimi);
            }
            else if (eesnimi == null && perenimi != null)
            {
                Console.WriteLine("Tere! Minu perenimi on " + perenimi);
            }
            else
            {
                Console.WriteLine("Tere!");
            }

            //Console.WriteLine("Tere! Minu perenimi on "+perenimi);
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}", vanus, Staatus);
        }
        public void Head_aega()
        {
            Console.WriteLine("Minu palk on {0} ja see on {1}. Head aega!", palk, palk_staatus);
        }
        public double Sotsialmaks()
        {
            double sots = 0;
            sots = Palk * 0.33;
            return sots;
        }
    }
}
