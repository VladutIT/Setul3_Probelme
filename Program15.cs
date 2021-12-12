using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),i;
            int[] v = new int[n];

            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            for ( i = 0; i < n-1; i++)
            {
              
               if(v[i]!=v[i+1])
                {
                    Console.Write($"{v[i]} ");
                }
               else
                {
                    i++;
                }
            }

            if(v[n-1]!=v[n-2])
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}
