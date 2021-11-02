using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("*** Iteracja Pętli nr: {0}", i);
                Console.WriteLine("Bierząca wartość s: {0}", s);
                s = s + i;
                Console.WriteLine("Bierząca wartość i: {0}", i);
            }
            Console.WriteLine("Końcowa wartość zmiennej s to {0}", s);
            Console.ReadKey();
        }
    }
}
