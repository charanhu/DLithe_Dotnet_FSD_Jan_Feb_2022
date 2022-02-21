using System;

namespace EmployeeInfo
{
    class PartialClass1
    {
    }
    public partial class EmployeeDetails
    {
        private int empID;
        private string empName;
        public EmployeeDetails(int empID, string empName)
        {
            this.empID = empID;
            this.empName = empName;
        }
    }
    public partial class Employee
    {
        public partial void InitializeEmployee();
        public void Emp1() { }
        public void Emp2() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails ed = new EmployeeDetails(101, "Charan");
            ed.PrintEmployeeInfo();
            Employee emp = new Employee();
            emp.InitializeEmployee();
            Console.ReadLine();
        }
    }
}