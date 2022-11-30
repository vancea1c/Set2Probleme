using System;


namespace P6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere");
            bool ok=true;
            string[] t = Console.ReadLine().Split(" ");
            for (int i = 0; i < n-1; i++)
            {
                int x=int.Parse(t[i]);
                int y=int.Parse(t[i+1]);
                if (y < x)
                    ok=false;

            }
            if (ok)
                Console.WriteLine("Numerele din sir sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele din sir nu sunt in ordine crescatoare");
        }
    }
}
