using System;


namespace P9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere");
            string[] t = Console.ReadLine().Split(" ");
            bool cresc = true;
            bool desc=true;
            for (int i = 0; i < n-1; i++)
            {
                int x = int.Parse(t[i]);
                int y = int.Parse(t[i+1]);
                if (y < x)
                    cresc = false;
                if (y>x)
                    desc = false;
            }
            if (cresc)
                Console.WriteLine("Sirul este monoton crescator");
            if (desc)
                Console.WriteLine("Sirul este monoton descrescator");
            if (!cresc && !desc)
                Console.WriteLine("Sirul nu este monoton");
        }
    }
}
