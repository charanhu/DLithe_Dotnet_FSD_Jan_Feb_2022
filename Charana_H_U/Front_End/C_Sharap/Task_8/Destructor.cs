using System;
namespace CsharpDestructor
{

    class Person
    {

        string name;

        void getName()
        {
            Console.WriteLine("Name: " + name);
        }

        // destructor
        ~Person()
        {
            Console.WriteLine("Destructor called.");
        }

        public static void Main(string[] args)
        {

            // creates object of Person
            Person p1 = new Person();

            p1.name = "Charan";
            p1.getName();
        }
    }
}