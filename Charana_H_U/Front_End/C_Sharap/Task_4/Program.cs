using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)              // []
        {
            int SNO, MARK1, MARK2, MARK3, AVERAGE;               // ;
            string SNAME;                                        // ;
            Console.WriteLine("ENTER THE STUDENT DETAILS");
            Console.WriteLine("ENTER THE STUDENT NO");
            SNO = int.Parse(Console.ReadLine());                // int.Parse(Console.ReadLine());  
            Console.WriteLine("ENTER THE STUDENT NAME");
            SNAME = Console.ReadLine();
            Console.WriteLine("ENTER THE MARKS OF 3 SUBJECTS");
            MARK1 = int.Parse(Console.ReadLine());             // Mark 1
            MARK2 = int.Parse(Console.ReadLine());
            MARK3 = int.Parse(Console.ReadLine());
            int TOTAL = MARK1 + MARK2 + MARK3;                 // int
            AVERAGE = TOTAL / 3;                              // /3
            Console.WriteLine("\n\n\nTHE STUDENT DETAILS ARE GIVEN BELOW :");
            Console.WriteLine("THE STUDENT NO IS: " + SNO);               // +
            Console.WriteLine("THE STUUDENT NAME IS: " + SNAME);
            Console.WriteLine("TOTAL MARKS IS : " + TOTAL);
            Console.WriteLine("AVEARGE MAARK IS: " + AVERAGE);
            Console.ReadKey();
        }
    }
}
