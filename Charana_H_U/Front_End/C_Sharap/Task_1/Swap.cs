using System;

namespace Program3
{
    class Swap
    {
        static void Main(String[] args)
        {
            Console.WriteLine("a: ");
            string a=Console.ReadLine();
            int val1=Convert.ToInt32(a);  //20
            Console.WriteLine("b: ");
            string b=Console.ReadLine();
            int val2=Convert.ToInt32(b);  //10
            Console.WriteLine("Before Swap:");
            Console.WriteLine("a: " + val1);
            Console.WriteLine("b: " + val2);
            val1 = val1 + val2;            // 30=20+10
            val2 = val1 - val2;           // 20=30-10
            val1 = val1 - val2;           // 10=30-20
            Console.WriteLine("After Swap:");
            Console.WriteLine("a: " + val1);
            Console.WriteLine("b: " + val2);
        }


    }
}
