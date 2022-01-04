using System;

namespace System4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wartość dziesiętna: {0}", przelicz(n));
        }
        static int przelicz(int n)
        {
            if (n < 4)
            {
                return n;
            }
            return 4 * przelicz(n / 10) + n % 10;
        }
    }
}
