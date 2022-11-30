using System;


namespace P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul pe care doriti sa il cautati");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere");
            int poz = -1;
            string[] t = Console.ReadLine().Split(" ");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(t[i]);
                if (x == a)
                    poz = i;

            }
            Console.WriteLine($"{a} se afla in sirul n pe pozitia {poz}");
        }
    }
}
