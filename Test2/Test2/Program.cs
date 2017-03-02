using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            for (int i = 0; i < 300; i++)
            {
                n++;
                for (int j=0; j<i; i++)
                {
                    n++;
                    if (n > 20)
                    {
                        Console.WriteLine(n);
                    } 
                }
            }
        }
    }
}
