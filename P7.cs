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
            int maxi=int.MinValue;
            int mini=int.MaxValue;
            string[] t = Console.ReadLine().Split(" ");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(t[i]);
                if(x > maxi)
                    maxi = x;
                if(x < mini)
                    mini = x;
            }
            Console.WriteLine($"{maxi} este cea mai mare valuare din sir");
            Console.WriteLine($"{mini} este cea mai mica valuare din sir");
        }
    }
}
