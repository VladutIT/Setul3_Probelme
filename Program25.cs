using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int i, j;
            int[] v1 = new int[n1];
            int[] v2 = new int[n2];
            for(i=0;i<n1;i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            for(j=0;j<n2;j++)
            {

            }
            i = 0;
            j = 0;
            while(i<n1 || j<n2)
            {
                if(v1[i]<v2[j])
                {
                    Console.Write(v1[i]);
                    Console.Write(" ");
                    i++;
                }
                else if(v1[i] > v2[j])
                {
                    Console.Write(v2[j]);
                    Console.Write(" ");
                    j++;
                }
                else if(v1[i] == v2[j])
                {
                    Console.Write(v1[i]);
                    Console.Write(" ");
                    Console.Write(v2[j]);
                    Console.Write(" ");
                    j++;
                    i++;
                }
            }

            for(int poz=i;poz<n1;poz++)
            {
                Console.Write(v1[poz]);
                Console.Write(" ");
            }
            for (int poz = j; poz < n2; poz++)
            {
                Console.Write(v2[poz]);
                Console.Write(" ");
            }
        }
    }
}