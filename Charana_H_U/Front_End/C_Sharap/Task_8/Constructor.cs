using System;
namespace Constructor
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
        public Employee(int a)
        {
            Console.WriteLine("Parameter Constructor 1 Invoked");
        }
        public Employee(int a, string b)
        {
            Console.WriteLine("Parameter Constructor 2 Invoked");
        }
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee(10);
            Employee e3 = new Employee(20, "Charan");
        }
    }
}
