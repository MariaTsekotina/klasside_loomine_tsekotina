using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasside_loomine_tsekotina
{
    class Program
    {
        static void Main(string[] args)
        {
            Nelinurk a = new Nelinurk();
            Console.WriteLine("Kirjutage kõrgus: ");
            a.Korgus = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjutage laius: ");
            a.Laius = int.Parse(Console.ReadLine());
            a.Tüüp();
            var vastus = "";
            Console.WriteLine("Kas tahate tema P ja S leida?");
            vastus = Console.ReadLine();
            if (vastus == "JAH" || vastus == "Jah" || vastus == "jah")
            {
                a.P_S();
            }
            else
            {
                Console.Write("Ok, head aega!");
            }


            Inimene naine = new Inimene();
            naine.Nimi = "Maria";
            naine.Perenimi = "Kask";
            Console.WriteLine("Kirjuta oma vanus - ");
            naine.Vanus = int.Parse(Console.ReadLine());
            naine.Tervitamine();
            Console.WriteLine("Kirjuta oma palk: ");
            naine.Palk = int.Parse(Console.ReadLine());
            double s = naine.Sotsialmaks();
            Console.WriteLine(s);
            naine.Head_aega();

            Inimene mees = new Inimene();
            mees.Perenimi = "Tamm";
            mees.Vanus = 45;
            Console.WriteLine(mees.Perenimi + " on " + mees.Vanus + " aastane mees");
            mees.Tervitamine();

            Inimene[] inimesed = new Inimene[5];
            for (int i = 0; i < 5; i++)
            {
                inimesed[i] = new Inimene();
                Console.WriteLine("Kirjuta perenimi: ");
                inimesed[i].Perenimi = Console.ReadLine();
                Console.WriteLine("Kirjuta vanus: ");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.Tervitamine();
            }

            Console.ReadKey();
        }
    }
}
