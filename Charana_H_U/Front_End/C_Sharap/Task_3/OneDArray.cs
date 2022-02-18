using System;

namespace Program1
{
    class OneDArray
    {
        static void Main()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] b = { "January", "February", "March", "Appril", "May", "June", "July" };
            Console.WriteLine("One Dimensional Integer Array");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nOne Dimensional String Array");
            foreach (string j in b)
            {
                Console.WriteLine(j);
            }

        }
    }
}