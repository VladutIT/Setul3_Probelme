using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mare = 0, mic = 100000, i,cnt1=0,cnt2=0;
            n = int.Parse(Console.ReadLine());
         
            int[] v = new int[n];
            for(i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());

                if(mare<v[i])
                {
                    mare = v[i];
                    cnt1 = 1;
                }
                if(mare==v[i])
                {
                    cnt1++;
                }

                if(mic>v[i])
                {
                    mic = v[i];
                    cnt2 = 1;
                }
                if(mic==v[i])
                {
                    cnt2++;
                }
            }
            Console.WriteLine($"{mic},{mare} apar in vectori de {cnt2},{cnt1}");
        }
    }
}
