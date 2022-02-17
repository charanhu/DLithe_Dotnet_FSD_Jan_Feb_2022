// Inheritance

using System;

namespace Inheritance
{


    class School
    {
        protected int s_id;
        protected string s_name;

        public void student_info(int s_id, string s_name)
        {
            this.s_id = s_id;
            this.s_name = s_name;
            Console.WriteLine("Student ID: " + s_id);
            Console.WriteLine("Student NAME: " + s_name);
        }
    }

    class Student : School
    {
        public StudentDetails()
        {
            Console.WriteLine("Student Details are");
        }
    }

    class Main_Class
    {
        static void Main(String[] args)
        {

        }
    }

 }