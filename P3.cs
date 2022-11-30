using System;


namespace P3
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            long sn = (n * (n + 1)) / 2;
            int prd = factorial(n);
            Console.WriteLine($"Suma primelor {n} numere este {sn}");
            Console.WriteLine($"Produsul primelor {n} numere este {prd}");
        }
        static int factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n*factorial(n-1);
        }
    }
}
