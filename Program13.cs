using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for(int k=1;k<n;k++)
            {
                int x;
                x = v[k];
                int j = k - 1;
                while(j>=0 && x<=v[j])
                {
                    v[j + 1] = v[j];
                    j = j - 1;
                }
                v[j + 1] = x;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}
