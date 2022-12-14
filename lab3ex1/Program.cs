using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //suma cifrelor unui numar
            Console.WriteLine("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma este " + SumaCifre(numar));
        }

        static  int SumaCifre(int numar)
        {
            int suma=0;
            while(numar!=0)
            {
                suma += numar % 10;
                numar /= 10;
            }
            return suma;
        }
    }
}
