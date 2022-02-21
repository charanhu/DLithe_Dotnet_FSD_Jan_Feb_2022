using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    class PartialClass2
    {
    }
    public partial class Employee
    {
        public void Emphoyees() { }
        public partial void InitializeEmployee()
        {
            string str = "Employee Details";
            Console.WriteLine(str);
        }
    }
    public partial class EmployeeDetails
    {
        public void PrintEmployeeInfo()
        {
            Console.WriteLine("Employee ID:" + empID);
            Console.WriteLine("Employee Name:" + empName);
        }
    }
}