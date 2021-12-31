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
            int i, j,S=0,Dif=0,P,nr1=0,nr2=0;
            int[] v1 = new int[n1];
            int[] v2 = new int[n2];

            for(i=0;i<n1;i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
                nr1 = nr1 * 10 + v1[i];
            }

            for(j=0;j<n2;j++)
            {
                v2[j] = int.Parse(Console.ReadLine());
                nr2 = nr2 * 10 + v2[j];
            }
            S = nr1 + nr2;
            Dif = Math.Abs(nr1 - nr2);
            P = nr1 * nr2;
            Console.Write($"{S},{Dif},{P}");

        
        }
    }
}