using System;

namespace Zadanie14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wciśnij S żeby zacząć");
            string start = Console.ReadLine();
            bool koniec = false;
            while (!koniec)
            {
                if (start.ToUpper() == "S")
                {
                    DateTime thisDay = DateTime.Now;
                    Console.WriteLine(thisDay.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Czy chcesz ponownie wyświetlić czas?");
                    Console.WriteLine("Wciśnij klawisz N żeby wyjść . . .");
                    
                }
                else
                {
                    koniec = true;
                }
                break;
            }
            while (Console.ReadKey().Key != ConsoleKey.N) { }
        }
        
    }
}
