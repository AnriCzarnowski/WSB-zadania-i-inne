using System;

namespace Pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            string n= Console.Readline();
            int dlugosc = n.Length;
            Console.WriteLine(dlugosc);
            if (dlugosc != 11)
            {
                Console.WriteLine("Nieprawidłowy pesel");
            }
            else
            {
                int suma = n[0] + n[4] + n[8] + n[10];
                for (int i = 0; i < dlugosc; i++)
                {
                    Console.WriteLine(n[i]);
                    int iloczyn = n[i];
                    if (i == 1)
                    {
                        iloczyn = iloczyn * 3;
                        suma = suma + iloczyn;
                    }
                    if (i == 2)
                    {
                        iloczyn = iloczyn * 7;
                        suma = suma + iloczyn;
                    }
                    if (i == 3)
                    {
                        iloczyn = iloczyn * 9;
                        suma = suma + iloczyn;
                    }

                    if (i == 5)
                    {
                        iloczyn = iloczyn * 3;
                        suma = suma + iloczyn;
                    }
                    if (i == 6)
                    {
                        iloczyn = iloczyn * 7;
                        suma = suma + iloczyn;
                    }
                    if (i == 7)
                    {
                        iloczyn = iloczyn * 9;
                        suma = suma + iloczyn;
                    }
                    if (i == 9)
                    {
                        iloczyn = iloczyn * 3;
                        suma = suma + iloczyn;
                    }

                }
                Console.WriteLine(suma);
                string essa = Convert.ToString(suma);
                if (essa[essa.Length -1] == '0')
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("N");
                }
                
            }
        }
    }
}
