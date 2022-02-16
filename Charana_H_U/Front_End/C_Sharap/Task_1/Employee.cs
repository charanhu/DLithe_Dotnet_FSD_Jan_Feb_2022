using System;

namespace Program1
{
    class Employee
    {
        static void Main(string[] args)
        {
            //to get how many employees 
            Console.WriteLine("Enter How many employess Data to store");
            string val = Console.ReadLine();
            int n = Convert.ToInt32(val);

            //to store all employees id
            String[] emp_id = new String[n];

            //to store all employees name
            String[] emp_name = new String[n];

            //To read employee details
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Employee "+(i+1)+" ID");
                emp_id[i]= Console.ReadLine();
                Console.WriteLine("Enter Employee  Name");
                emp_name[i] = Console.ReadLine();
            }
            
            //To dispaly the employee deatils
            Console.WriteLine("Employee Details are");
            Console.WriteLine("-----------------------");
            Console.WriteLine("ID\t Name");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(emp_id[i]+"\t"+emp_name[i]);
            }
        }
    }
}