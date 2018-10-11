using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrregate_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 34, 4564, 67, 23, 454, 57, 8, 3, 1343, 2346, 232, 5, 23, 676, 34 };
            int minNumber = Numbers.Min();
            int evenNumber = Numbers.Where(s => s % 2 == 0).Min();
            int largeNumber = Numbers.Max();
            int countNumber = Numbers.Count();
            int sumNumber = Numbers.Sum();

            string[] Countries = { "UK", "USA", "Canada", "Germany" };

            Console.WriteLine(" The lenght is " + Countries.Min(c => c.Length));
            Console.WriteLine(" The lenght is " + Countries.Max(c => c.Length));



            Console.WriteLine(" The result is " + evenNumber);
            Console.WriteLine(" The result is " + minNumber);
            Console.WriteLine(" The result is " + largeNumber);
            Console.WriteLine(" The result is " + countNumber);
            Console.WriteLine(" The result is " + sumNumber);
            Console.ReadKey();
        }
    }
}
