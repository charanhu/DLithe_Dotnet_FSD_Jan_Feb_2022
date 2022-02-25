// C# Collections
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorted_List_Example
{
    class Sorted_List
    {
        static void Main()
        {
            var value = new SortedList<string, int>();            // sortedlist collection
            value.Add("Sunday", 10);                                               // add element
            value.Add("monday", 20);
            value.Add("Tuesday", 25);
            value.Add("Wednesday", 30);
            value.Add("Friday", 35);
            value.Add("Satuarday", 40);
            //value.Clear();
            foreach (var pair in value)
            {
                Console.WriteLine(pair);
                Console.ReadLine();
            }
        }
    }
}