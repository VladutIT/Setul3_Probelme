using System;

namespace Setul3_Probelme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),ok=1;
            int[] v = new int[n];
            int nr = 0;
            v[0] = int.Parse(Console.ReadLine());
            int x;
            x = v[0];
            int cmd=0;

            for(int i=1;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if(ok==1)
                {
                    nr = v[i];
                }
                else
                {
                    x = v[i];
                }
                if (x > nr)
                {
                    while (nr != 0)
                    {
                        int aux = x % nr;
                        x = nr;
                        nr = aux;
                    }
                    cmd = x;
                }
                if (x < nr)
                {
                    while (nr != 0)
                    {
                        int aux = nr%x;
                        nr = x;
                        x= aux;
                    }
                    cmd = nr;
                }
                if(x==0)
                {
                    x = v[i];
                    ok = 1;
                }
                else if(nr==0)
                {
                    nr = v[i];
                    ok = 0;
                }
            }
            Console.WriteLine(cmd);
        }
    }
}
