using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Rok: ");
            int rok = Convert.ToInt32(Console.ReadLine());
            //funkcja CzyPrzestepny(int r)
            Console.WriteLine(Obliczenia.CzyPrzestepny(rok));
            Console.ReadKey();
        }

    }
}
