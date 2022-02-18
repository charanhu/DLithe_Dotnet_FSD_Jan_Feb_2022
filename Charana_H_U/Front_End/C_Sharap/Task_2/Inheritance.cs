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
            Console.WriteLine("Base Student ID: " + s_id);
            Console.WriteLine("Base Student NAME: " + s_name);
        }
    }

    class Student : School
    {
        //School sc=new School();
        //sc.s_id = 1;
        //sc.s_name = "charan";
        public void StudentDetails()//parameters can also be possible here
        {
            Console.WriteLine("Student Details are");
            int  s_1 = 12;
            string s_2 = "Arista";
            School sc=new School();
            sc.student_info(s_1, s_2);
            Console.WriteLine("Derived Student ID: " + s_1);
            Console.WriteLine("Derived Student NAME: " + s_2);
        }
    }

    class Main_Class
    {
        static void Main(String[] args)
        {
            Student student = new Student();
            student.StudentDetails();
        }
    }

 }