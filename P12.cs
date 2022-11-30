using System;

namespace P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere");
            string[] t = Console.ReadLine().Split(" ");
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(t[i]);
                if (x != 0)
                {
                    cnt++;
                    int aux = x;
                    while (aux!=0 &&i<n-1)
                    {
                        i++;
                        aux = int.Parse(t[i]);
                    }
                }

            }
            Console.WriteLine(cnt);
        }
    }
}
/*
 


3 4 1 2
4 1 2 3
1 2 3 4
2 3 4 1


 */