using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[50];
            int[] v2 = new int[50];
            int n1, n2, i = 0, j = 0;
            n1 = int.Parse(Console.ReadLine());
            int m1 = 0, m2 = 0, minn = 10000, maxx = 0;
            for (i = 0; i < n1; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            n2 = int.Parse(Console.ReadLine());
            for (j = 0; j < n2; j++)
            {
                v2[j] = int.Parse(Console.ReadLine());
            }
            i = 0;
            j = 0;

            while (i < n1 || j < n2)
            {
                if (v1[i] == v2[j] && m1 != 0)
                {
                    m1 = v1[i];
                }
                if (v1[i] == v2[j])
                {
                    m2 = v1[i];
                }
                if (minn > v1[i])
                {
                    minn = v1[i];
                }
                if (minn > v2[i])
                {
                    minn = v2[i];
                }
                if (maxx < v1[i])
                {
                    maxx = v1[i];
                }
                if (maxx < v2[i])
                {
                    maxx = v2[i];
                }
                i++;
                j++;
            }
            Console.WriteLine($"Intersectia este {m1} {m2}");
            Console.WriteLine($"Reuniunea este {minn} {maxx}");
        }
    }
}