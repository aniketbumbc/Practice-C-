using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int i,j;
            for (i = 1; i <= 6; i++)
            {
                Console.Write(i);
                for (j = 1; j <= 7 - i; j++)
                {
                    Console.Write(i + "*");
                    Console.Write("\n");
                }
                   


            }          

            Console.ReadKey();
        }
    }
}
