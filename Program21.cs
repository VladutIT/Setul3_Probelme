using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s1 = new int[50];
            int[] s2= new int[50];
            int n1, n2,ok=1,i=0,j=0;
            n1 = int.Parse(Console.ReadLine());
            for(i=0;i<n1;i++)
            {
                s1[i] = int.Parse(Console.ReadLine());
            }
            n2 = int.Parse(Console.ReadLine());
            for (j = 0; j < n2; j++)
            {
                s2[j] = int.Parse(Console.ReadLine());
            }
            i = 0;
            j = 0;
           while(i<n1 || j<n2)
            {
                if(s1[i]==s2[j])
                {
                    i++;
                    j++;
                    ok = 0;
                }
               else if(s1[i]<s2[j])
                {
                    ok = 2;
                    break;
                }
                else if(s2[j]<s1[i])
                {
                    ok = 3;
                    break;
                }
                if(ok==1)
                {
                    i++;
                    j++;
                }
            }
            if(ok==2)
            {
                Console.WriteLine("Primul sir este lexicografic");
            }
            else if(ok==3)
            {
                Console.WriteLine("Al doilea sir este lexicografic");
            }
        }
    }
}
