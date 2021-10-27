using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forowanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbę liczb podzielnych przez 7: ");
            int a;
            int liczba = 0;
            a = Convert.ToInt32(Console.ReadLine());
            //for (i=0;i<=a;i++)
            {
                for (liczba = 0; liczba < a * 7; liczba += 7)
                {
                    Console.WriteLine(liczba);
                }
            }
            Console.ReadKey();
        }
    }
}
