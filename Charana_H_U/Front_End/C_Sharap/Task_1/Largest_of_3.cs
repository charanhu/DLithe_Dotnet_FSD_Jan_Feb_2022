using System;

namespace Program4
{
    class Largest_of_3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            int var1 = Convert.ToInt32(s1);
            int var2 = Convert.ToInt32(s2);
            int var3 = Convert.ToInt32(s3);
            if (var1 > var2)
            {
                if (var1 > var3)
                {
                    Console.WriteLine("Largest Number is: " + var1);
                }
                else
                {
                    Console.WriteLine("Largest: " + var3);
                }
            }
            else
            {
                if (var2 > var3)
                {
                    Console.WriteLine("Largest: " + var2);
                }
                else
                {
                    Console.WriteLine("Largest: " + var3);
                }
            }

        }
    }
}
