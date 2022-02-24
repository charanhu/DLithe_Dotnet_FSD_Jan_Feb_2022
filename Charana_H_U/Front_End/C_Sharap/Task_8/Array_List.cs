// C# Collections

using System;
using System.Collections;


namespace ArrayListExample
{
    class ArrayListDemo
    {
        static void Main()
        {
            var data = new ArrayList();
            Console.WriteLine("ArrayList")
            data.Add(1);
            data.Add(2);   
            data.Add(3);
            data.Add(4);
            data.Add(55.12);
            data.Add(45);
            data.Remove(3);
            foreach (var item in data)
            {
                Console.WriteLine(item);
                Console.ReadLine(); 
            }
        }
    }
}