using System;


namespace P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere");
            int cnt = 0;
            string[] t = Console.ReadLine().Split(" ");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(t[i]);
                if (x == i)
                    cnt++;

            }
            Console.WriteLine($"{cnt} numere au aceeasi valuare cu pozitia pe care se afla in sir");
        }
    }
}
