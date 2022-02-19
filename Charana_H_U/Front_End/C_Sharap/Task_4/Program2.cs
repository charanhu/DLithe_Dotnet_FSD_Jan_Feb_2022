using System;

namespace PropertyDemo
{
    class Example
    {
        private int _empid, _eage;
        private string _ename, _eaddress;
        public int empid
        {
            set
            {
                empid = value;
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
            }                                     // get method
            get
            {
                return _eaddress;
            }
        }
        static void Main()                           // Main method
        {
            Example example = new Example();                
            example._empid = 1;
            example._eage = 2;
            example._ename = "a";
            example._eaddress = "b";
            Console.WriteLine(example.empid);
            Console.WriteLine(example.eage); 
            Console.WriteLine(example.eaddress);
            Console.WriteLine(example.ename);
        }
    }
}
