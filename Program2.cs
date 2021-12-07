using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k,i;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
               if(v[i]==k)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (i == n)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
