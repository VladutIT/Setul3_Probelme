using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i;
            n = int.Parse(Console.ReadLine());
            k= int.Parse(Console.ReadLine());
            

            int[] v = new int[n];
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n-1; i++)
            {
                if(i==k)
                {
                    v[i] = v[i + 1];
                }
                Console.Write($"{v[i]} ");
            }

        }
    }
}
