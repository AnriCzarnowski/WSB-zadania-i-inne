using System;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Liczba przejść n : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nLiczby nieparzyste: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nSuma nieparzystych liczb naturalnych przez {0} przejść wynosi: {1} \n", n, sum);
        }
    }
}
