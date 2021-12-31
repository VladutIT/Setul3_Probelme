using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[50];
            int[] p = new int[50];
            int n1, n2,cnt=0,i=0,j=0;
            n1 = int.Parse(Console.ReadLine());
            for(i=0;i<n1;i++)
            {
                s[i] = int.Parse(Console.ReadLine());
            }
            n2 = int.Parse(Console.ReadLine());
            for (j = 0; j < n2; j++)
            {
                p[j] = int.Parse(Console.ReadLine());
            }
           j = 0;

            for (i = 0; i < n1; i++)
            {
              if(s[i]==p[j])
                {
                    j++;
                }
              else
                {
                    j = 0;
                }
              if(j==n2)
                {
                    cnt++;
                    j = 0;
                    if(s[i]==p[j])
                    {
                        j++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
