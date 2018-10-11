using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 34, 45, 2, 12, 454, 643, 23,1000 };
            int sum = 0;
            int total = 0;
            int avg = 0;
            foreach (int i in Numbers)
            {
                sum = sum + i;
                total = total + 1;
            }
            avg = sum / total;
            Console.WriteLine("The Sume will be " + total);
            Console.WriteLine("The Sume will be " +sum);
            Console.WriteLine("The Average will be " + avg);

            Console.ReadKey();

        }
    }
}
