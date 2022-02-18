using System;

namespace TwoDArray
{
    class ArrayTwo
    {
        static void Main()
        {
            int[,] a = new int[,]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {6, 7, 8, 9 }
            };
            string[,] b = new string[,]
            {
                {"a", "b", "c", "d"},
                {"e", "f", "g", "h"},
                {"i", "j", "k", "m"}
            };
            Console.WriteLine("Two Dimensional Integer Array");
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.Write(a[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Two Dimensional String Array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
