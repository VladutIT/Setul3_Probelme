using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int []v = new int [n];
            int poz = 0;
            while(n!=0)
            {
                v[poz] = n % b;
                n = n / b;
                poz++;
            }
            for(int i=poz-1;i>=0;i--)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}
