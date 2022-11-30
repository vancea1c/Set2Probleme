using System;

namespace P8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar");
            int n=int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(0);
                return;
            }
            if (n == 2 || n == 3) 
            { 
                Console.WriteLine(1);
                return;
            }
            int f1 = 1;
            int f2 = 1;
            int fn = 0;
            for(int i=4; i<=n; i++)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
            }
            Console.WriteLine($"Termenul de pe pozitia {n} din sirul lui Fibonacci este {fn}");
            
        }
    }
}
