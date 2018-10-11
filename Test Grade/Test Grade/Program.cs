using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Result ");
            int quize;
            int midTerm;
            int finalExam;
            int avgScore;

            Console.WriteLine("Please Enter Quize Marks ");
            quize = int.Parse (Console.ReadLine());

            Console.WriteLine("Please Enter Midterm Marks ");
            midTerm = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter finalExam Marks ");
            finalExam = int.Parse(Console.ReadLine()); 

            avgScore = ((quize + midTerm + finalExam) / 3);

            Console.WriteLine(" The avgScore of Student is " + avgScore);
            if(avgScore >= 90)
            {
                Console.WriteLine(" Student Got A Grade ");
            }
            if(avgScore <=90 && avgScore>=70)
            {
                Console.WriteLine(" Student Got B Grade ");
            }
            if(avgScore <= 70 && avgScore >= 50)
            {
                Console.WriteLine(" Student Got C Grade ");
            }
            else
            {
                Console.WriteLine(" Student Got D Grade ");
            }
             Console.ReadKey();
        }
    }
}
