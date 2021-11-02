using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LICZBA_PIERWSZA
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if(n == 2 || n == 3)
            {
                Console.WriteLine("Liczba jest liczbą pierwszą");
            }
            if (n < 2)
            {
                Console.WriteLine("Liczba mniejsza od 2 nie jest liczbą pierwszą");
            }
            else 
            {
                int i = 2;
                while (i <= Math.Sqrt(n))
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Liczba nie jest liczbą pierwszą");
                    }
                    else
                    {
                        Console.WriteLine("Liczba jest liczbą pierwszą");
                    }
                    break;
                    
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
