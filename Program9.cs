using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),var1=0,var2=0,k;
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0;i<n;i++)
            {
                v[i]= int.Parse(Console.ReadLine());
            }
            for (int j = 1; j <= k; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {   
                    if(i==0)
                    {
                        var1 = v[0];
                    }
                    var2 = v[i];
                    v[i] = v[i + 1];
                    v[i + 1] = var2;
                    if(i==n-1)
                    {
                        v[n - 1] = var1;
                    }
                }
            }
            v[n - 1] = var1;
            for(int i=0;i<n;i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}
