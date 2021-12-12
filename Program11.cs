using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int []v=new int[100000];
            for(int i=0;i<n;i++)
            {
                v[i] = 0;
            }
            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if (v[i] == 0)
                {
                    for (int j = 2; j <= n / 2; j++)
                    {
                        v[i * j] = 1;
                    }
                }
            }
            for(int i=2;i<=n;i++)
            {
                if(v[i]==0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
