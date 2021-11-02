using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("podaj wartość podstawy: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj wartość pierwszego odcinka: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj wartość drugiego odcinka: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Z odcinków i podstawy można zbudować trójkąt");      
            }
            else
            {
                Console.WriteLine("Z odcinków i podstawy nie można zbudowac trójkąta");
            }
            Console.ReadKey();
        }
    }
}
