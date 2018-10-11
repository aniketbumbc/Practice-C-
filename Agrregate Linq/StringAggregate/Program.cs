using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "India", "Pak", "Shrilankha", "USA", "UK" };
            string result = " ";

            foreach(string str in teams)
            {
                result = result + str + ",";
            }

            int lastIndex = result.LastIndexOf(",");
            result = result.Remove(lastIndex);

            Console.Write(result);
            Console.WriteLine(" ");

            //using Linq

            string linquResult = teams.Aggregate((a, b) => a + "@" + b);
            Console.Write(linquResult);

            Console.ReadKey();
        }
    }
}
