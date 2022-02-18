using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class ArrayMethods
    {
        static void Display(int[] arr)
        {
            foreach (Object ele in arr)
            {
                Console.WriteLine(ele+" ");
            }
        }
        static void Main()
        {
            int[] vs = { 10, 3, 215, 45, 0 };
            Console.WriteLine("Original Array");
            foreach (int i in vs)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sorted Array");
            Array.Sort(vs);
            Display(vs);
            Console.WriteLine("Reverse Array");
            Array.Reverse(vs);
            Display(vs);
        }
    }
}
