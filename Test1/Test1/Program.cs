using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(30));
            Console.WriteLine(FeetToInches(120));
        }
        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
