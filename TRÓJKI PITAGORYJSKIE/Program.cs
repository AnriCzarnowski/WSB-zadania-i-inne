using System;

namespace Zadanie6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj zakres w formacie pierwsza liczba spacja druga liczba");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int m = ar[0];
            int n = ar[1];
            for (int a = m; a <= n - 2; a++)
                for (int b = a + 1; b <= n - 1; b++)
                    for (int c = b + 1; c <= n; c++)
                        if (a * a + b * b == c * c)
                            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
