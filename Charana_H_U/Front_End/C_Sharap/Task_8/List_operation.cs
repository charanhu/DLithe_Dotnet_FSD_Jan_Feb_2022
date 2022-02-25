// C# Collections

using System;
using System.Collections;


namespace List_operation_Example
{
    class List_operation
    {
        static void Main()
        {
            var value = new List<string>();             // list collection
            value.Add("Jan");                       // add element
            value.Add("Feb");
            value.Add("March");
            value.Add("Apr");
            value.Add("May");
            value.Add("June");
            value.Remove("May");                  // remove element
            value.Remove("Feb");
            value.Insert(3, "March");              // insert element
            foreach (string st in value)
            {
                Console.WriteLine(st);
                Console.ReadLine();
            }
        }
    }
}