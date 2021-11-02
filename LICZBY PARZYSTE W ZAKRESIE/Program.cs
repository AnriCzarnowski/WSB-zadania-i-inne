using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE4
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            int x = a;

            while (x <= b)
            {
                if(x%2 == 0)
                {
                    Console.Write(" {0}",x);
                }
                x++;
            }
            Console.ReadKey();
        }
    }
}
