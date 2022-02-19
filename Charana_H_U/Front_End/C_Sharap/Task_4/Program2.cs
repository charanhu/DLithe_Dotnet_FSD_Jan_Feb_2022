using System;

namespace PropertyDemo
{
    public class Example
    {
        private int _empid, _eage;
        private string _ename, _eaddress;
        public int empid
        {
            set
            {
                _empid = value;              // _empid
            }
            get
            {
                return _empid;
            }
        }
        public int eage
        {
            set
            {
                _eage = value;
            }
            get
            {
                return _eage;
            }
        }
        public string ename
        {
            set
            {
                _ename = value;
            }
            get
            {
                return _ename;
            }
        }
        public string eaddress
        {
            set
            {
                _eaddress = value;
            }
            get
            {
                return _eaddress;
            }
        }
        static void Main(string[] args)
        {
            Example obj = new Example();
            obj.empid = 101;
            obj.ename = "pranaya";
            obj.eage = 27;
            obj.eaddress = "bbsr";
            Console.WriteLine("Employee details are:");
            Console.WriteLine("employee id:" + obj.empid);
            Console.WriteLine("employee name:" + obj.ename);
            Console.WriteLine("employee age:" + obj.eage);
            Console.WriteLine("employee address:" + obj.eaddress);
            Console.ReadKey();
        }
    }
}
