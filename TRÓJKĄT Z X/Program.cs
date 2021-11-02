using System;

namespace ZADANIE3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj n");
            n = Convert.ToInt32(Console.ReadLine());
            n--;
            for (int wiersz = 0; wiersz <= n; wiersz++)
            {
                int lwierszy = n;
                for (int kolumna = 0; kolumna <= n; kolumna++)
                {
                    int lkolumn = n;
                    if ((kolumna == lwierszy) || (wiersz == lwierszy) || (kolumna == lkolumn - wiersz))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();   
            
            
        }
    }
}
