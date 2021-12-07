using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, e,i;
            n = int.Parse(Console.ReadLine());
            k= int.Parse(Console.ReadLine());
            e= int.Parse(Console.ReadLine());

            int[] v = new int[n];
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                   if(k==i)
                {
                    v[i] = e;
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

        }
    }
}
