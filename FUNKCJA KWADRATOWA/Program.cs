using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x, y;
            Console.Write("podaj wartość a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj wartość b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj wartość c: ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            if (delta > 0)
            {
                x = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                y = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("pierwsiastek pierwszy: {0} pierwiastek drugi {1}", x, y);
            }
            else if(delta == 0) 
            {
                x = (-1 * b) / (2 * a);
                Console.WriteLine("pierwiastek: {0}", x);
            }
            else if(delta < 0)
            {
                Console.WriteLine("funkcja nie ma miejsc zerowych");
            }
            Console.ReadKey();
        }
    }
}
