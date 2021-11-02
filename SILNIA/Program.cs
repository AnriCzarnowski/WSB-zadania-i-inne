using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILNIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, silnia = 1, i = 1;
            Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                silnia = silnia * i;
                i++;
            }
            while (n == 0)
            {
                silnia = 1;
            }
            Console.WriteLine(silnia);
            Console.ReadKey();
        }   
    }
}
