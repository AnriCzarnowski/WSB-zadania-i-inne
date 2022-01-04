using System;

namespace Rekurencja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(f(3));
            Console.WriteLine(f(7));
            Console.WriteLine(f(f(3)));
        }
        static int f(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return 2 * f(n - 1)+ 1;
            
        }
    }
}
