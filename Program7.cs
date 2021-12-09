using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int []v=new int[n];

            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n/2; i++)
            {
                int aux;
                aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }

        }
    }
}
