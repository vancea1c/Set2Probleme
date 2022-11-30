using System;

namespace P2
{
    internal class P2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n apoi n numere");
            int n=int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(" ");
            int cntp= 0;
            int cntn = 0;
            int cntz = 0;
            for(int i=0; i<n; i++)
            {
                int x = int.Parse(t[i]);
                if(x>0)
                    cntp++;
                if (x == 0)
                    cntz++;
                if(x<0)
                    cntn++;
            }
            Console.WriteLine($"Avem {cntn} numere negative, {cntz} numere care sunt egale cu 0 si {cntp} numere pozitive");


            
        }
    }
}
