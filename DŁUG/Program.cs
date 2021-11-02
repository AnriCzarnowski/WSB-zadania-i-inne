using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dlug = 80;
            double janek = 50;
            double karol = 40;
            double splata = 0;
            int i = 0;
            do
            {
                i++;
                splata = splata + ((karol * 0.2) + (janek * 0.2));
                Console.WriteLine("dzień nr: {0}, spłata łączna tego dnia wynosi: {1}", i, splata);
            }
            while (splata <= dlug);
            Console.WriteLine("Koledzy spłacili dług po {0} dniach", i);
            Console.ReadKey();
        }
        
    }
}
