using System;
using System.Runtime.Intrinsics.X86;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n apoi n numere");
            int n=int.Parse(Console.ReadLine());
            int cnt=0;
            string[] t = Console.ReadLine().Split(" ");
            for(int i=0; i<n; i++)
            {
                int x=int.Parse(t[i]);
                if (x % 2 == 0)
                    cnt++;
            }
            Console.WriteLine($"Avem {cnt} numere pare");



        }
    }
}