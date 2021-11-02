using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Pierwsza liczba: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Druga liczba: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(a%b == 0)
            {
                Console.WriteLine("Liczba {0} jest dzielnikeim liczby {1}.", b, a);
            }
            else
            {
                Console.WriteLine("Liczba {0}  nie jest dzielnikeim liczby {1}.", b, a);
            }
            Console.WriteLine();
            Console.Write("Dzielnikami liczby {0} są liczby:", a);
            for(int i = 1; i <=a; i++)
            {
                if (a % i == 0)
                {
                    Console.Write(" {0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
