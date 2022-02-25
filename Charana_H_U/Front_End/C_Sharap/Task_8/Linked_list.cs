// C# Collections
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linked_list_Example
{
    class Linked_list
    {
        static void Main()
        {
            var value = new LinkedList<int>();             // linkedlist collection
            value.AddLast(100);          // add element
            value.AddLast(200);
            value.AddLast(300);
            value.AddLast(400);
            value.AddLast(500);
            value.AddFirst(600);
            value.AddFirst(700);
            LinkedListNode<int> node = value.Find(500);         // find the node
            value.AddBefore(node, 450);
            foreach (int num in value)
            {
                Console.WriteLine(num);
                Console.ReadLine();
            }
        }
    }
}