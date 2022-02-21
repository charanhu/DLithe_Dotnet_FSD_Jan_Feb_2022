using System;

namespace InterfaceDemo
{
    interface interface1   // replace public with interface
    {
        void Test();
        void Show();
    }
    interface interface2   // replace public with interface
    {
        void Test();
        void Show();
    }
    class ImplementInterafce : interface1, interface2   // Capital letter
    {

        public void Test()                                          // replace overide with void
        {
            Console.WriteLine("Test method is implemented");
        }
        public void Show()                                          // replace overide with void
        {
            Console.WriteLine("Show method is implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementInterafce obj = new ImplementInterafce();
            obj.Test();
            obj.Show();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
