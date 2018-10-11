using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Grade
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Hello");
            Console.WriteLine("Enter Pattren of String");
            String pattern;
            pattern =Console.ReadLine();


            switch (pattern)
            {
                case "int 1x=10":
                    Console.WriteLine("This is correct");
                    break;
                case "int x=10":
                    Console.WriteLine("This is correct");
                    break;
                case "float x=10.0f":
                    Console.WriteLine("This is wrong");
                    break;
                case "string x ='10'":
                    Console.WriteLine("This is correct");
                    break;
                default:
                    Console.WriteLine("Not a Valid Case");
                    break;
            }


            Console.ReadKey();
        }
            
    }
}
