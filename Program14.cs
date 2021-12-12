using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int cnt = 0;
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if(v[i]==0)
                {
                    cnt++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] != 0)
                {
                    Console.Write($"{v[i]} ");
                }
            }

                for (int i=0;i<cnt;i++)
            {
                Console.Write("0 ");
            }
          
         
        }
    }
}
