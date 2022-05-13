using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Gestiunea_Cheltuielilor
{
    class Program
    {
        public static int NR_MINIM_SALARII = 0;
        public static int NR_MAXIM_SALARII = 5;
        static void Main(string[] args)
        {
            int nrSalariati, contor = 0;
            do
            {
                Console.WriteLine("introduceti nr salariilor calculate: ");
                Int32.TryParse(Console.ReadLine(), out nrSalariati);
            } while (nrSalariati <= NR_MINIM_SALARII || nrSalariati > NR_MAXIM_SALARII);
            Calcule[] salariati = new Calcule[nrSalariati];

            string optiune;
            do
            {
                Console.WriteLine("A. Introduceti Veniturile si calculati cheltuielile: ");  
                Console.WriteLine("S. Afisare calcule");
                Console.WriteLine("X. Iesire din program");
                Console.WriteLine(" ");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        int chel;
                        int econ;
                        int ven;
                        Console.WriteLine("introdu veniturile: ");
                        do
                        { 
                            ven = Convert.ToInt32(Console.ReadLine());
                        } while (ven < 0);
                        chel = (ven * 45) / 100;
                        econ = (ven * 55) / 100;
                        Calcule salariu = new Calcule(ven,chel,econ);
                        salariati[contor++] = salariu;
                        break;

                    case "S":
                        foreach (Calcule cl in salariati)
                        {
                            Console.WriteLine(cl.ConversieLaSir);
                        }
                       
                        break; 

                    case "X":

                        return;

                }
            }
            while (optiune.ToUpper() != "X");

        }

    }
}

