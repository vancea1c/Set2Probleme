using System;


namespace P11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere");
            string[] t = Console.ReadLine().Split(" ");
            int suym = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(t[i]);
                suym += Oglindit(x);
            }
            Console.WriteLine(suym);
        }

         public static int Oglindit(int n)
        {
            int ogl=0;
            while (n > 0)
            {
                ogl = ogl * 10 + n % 10;
                n /= 10;
            }
            return ogl;
        }
    }
}
