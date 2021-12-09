using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), st = 0, dr = n - 1, mij, k,poz=-1;
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            mij = (st + dr) / 2;
            for(int i=0;i<n;i++)
            {
                v[i]= int.Parse(Console.ReadLine());
            }
           
              while(st<=dr)
            {
                mij = (st + dr) / 2;
                if(v[mij]==k)
                {
                    poz = mij;
                }
                else if(v[mij]>k)
                {
                    dr = mij - 1;
                }
                else if(v[mij]<k)
                {
                    st = mij + 1;
                }
            }
           
                Console.Write("poz");
        }
    }
}
