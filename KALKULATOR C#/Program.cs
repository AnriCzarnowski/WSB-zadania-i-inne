using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalk
{
    class Kalkulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź odpowiednią liczbę");
            Console.WriteLine("1 zeby dodac");
            Console.WriteLine("2 zeby odjac");
            Console.WriteLine("3 zeby pomnozyc");
            Console.WriteLine("4 zeby podzielic \n");
            int wlaczenie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadz pierwsza liczbe");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadz druga liczbe");
            int b = Convert.ToInt32(Console.ReadLine());
            int Rezultat = 0;
            switch (wlaczenie)
            {
                case 1:
                    {
                        Rezultat = Dodawanie(a , b);
                        break;
                    }
                case 2:
                    {
                        Rezultat = Odejmowanie(a , b);
                        break;
                    }
                case 3:
                    {
                        Rezultat = Mnozenie(a , b);
                        break;
                    }
                case 4:
                    {
                        Rezultat = Dzielenie(a , b);
                        break;
                    }
                default:
                    Console.WriteLine("Blad");
                    break;

            }
            Console.WriteLine("wynik to {0}", Rezultat);
            Console.ReadKey();
        }
        public static int Dodawanie(int a , int b) //Dodawanie
        {
            int Rezultat = a + b;
            return Rezultat;
        }
        public static int Odejmowanie(int a, int b) //Odejmowanie
        {
            int Rezultat = a - b;
            return Rezultat;
        }
        public static int Mnozenie(int a, int b) //Mnożenie
        {
            int Rezultat = a * b;
            return Rezultat;
        }
        public static int Dzielenie(int a, int b) //Dzielenie
        {
            int Rezultat = a / b;
            return Rezultat;
        }

    }
}
