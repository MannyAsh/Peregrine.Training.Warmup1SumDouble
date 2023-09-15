using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup1SumDouble
{
    internal class Program
    {
        static void Main(string[] args) {

            Console.WriteLine(sumDouble(2, 2));
            Console.WriteLine(sumDouble(2, 5));
            Console.ReadLine();
        }

        static int sumDouble(int a, int b) {

            if (a == b)
            {

                int sum = (a + b) * 2;
                return sum;

            }

            else {

                int sum = a + b;
                return sum;
            
            }
        
        }
    }
}
