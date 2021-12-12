using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ok = 0;
            int[] v = new int[n];

            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            while(ok!=1)
            {
                ok = 1;

                for(int i=0;i<n-1;i++)
                {
                    if(v[i]>v[i+1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = 0;
                    }
                }
            }

            for(int i=0;i<n;i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}
