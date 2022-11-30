using System;


namespace P10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere");
            string[] t = Console.ReadLine().Split(" ");
            int st, lmax = 0;
            for (int i = 0; i < n-1; i++)
            {
                int l = 0;
                int x = int.Parse(t[i]);
                int y = int.Parse(t[i + 1]);
                if(x == y)
                {
                    int dr;
                    st = i;
                    for(dr=i+2; dr<n ; dr++)
                    {
                        int x1=int.Parse(t[dr]);
                        int y1=int.Parse(t[dr-1]);
                        if (x1 != y1)
                            break;
                        l = dr - st + 1;
                        if(l>lmax)
                            lmax = l;

                    }
                }

            }
            Console.WriteLine(lmax);
        }
    }
}
