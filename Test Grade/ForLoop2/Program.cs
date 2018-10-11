using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            int i,j;
            int prve = 0;

            for(i =1; i<=6;i++)            
            {
                prve = +i;
                Console.Write(prve+""+i);
                for (j = 1; j <= 7 - i; j++)
                    Console.Write("*");
                    Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
