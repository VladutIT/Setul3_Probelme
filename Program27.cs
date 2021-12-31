using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int[] v1 = new int[n1];
            int index = int.Parse(Console.ReadLine());
            int ok = 0;
            for(int i=0;i<n1;i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            do
            {
                ok = 1;
                for (int i = 0; i < n1 - 1; i++)
                {
                    if (v1[i] > v1[i + 1])
                    {
                        int aux = v1[i];
                        v1[i] = v1[i + 1];
                        v1[i + 1] = aux;
                        ok = 0;
                    }
                }
            } while (ok != 1);

            for(int i=0;i<n1;i++)
            {
                if(i==index)
                {
                    Console.Write(v1[i]);
                    break;
                }
            }
        }
    }
}