using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,mare=0,mic=100000,i,poz_mare=0,poz_mic=0;
            n = int.Parse(Console.ReadLine());
         
            int[] v = new int[n];
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());

                if(mare<v[i])
                {
                    mare = v[i];
                    poz_mare = i;
                }
                if(mic>v[i])
                {
                    mic = v[i];
                    poz_mic = i;
                }
            }
            Console.WriteLine($"{poz_mic},{poz_mare}");
        }
    }
}
