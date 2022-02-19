//using System;

//namespace PropertyDemo
//{
//    class Example2
//    {
//        private int _empid, _eage;
//        private string _ename, _eaddress;
//        public int empid
//        {
//            set
//            {
//                _empid = value;              // _empid
//            }
//            get
//            {
//                return _empid;
//            }
//        }
//        public int eage
//        {
//            set
//            {
//                _eage = value;
//            }
//            get
//            {
//                return _eage;
//            }
//        }
//        public string ename
//        {
//            set
//            {
//                _ename = value;
//            }
//            get
//            {
//                return _ename;
//            }
//        }
//        public string eaddress
//        {
//            set
//            {
//                _eaddress = value;
//            }                                     // get method
//            get
//            {
//                return _eaddress;
//            }
//        }
//        static void Main()                           // Main method
//        {
//            Example example = new Example();                
//            example._empid = 101;
//            example._eage = 22;
//            example._ename = "Charan";
//            example._eaddress = "Shivamogga";
//            Console.WriteLine("EMP ID: "+example.empid);
//            Console.WriteLine("EMP AGE: "+example.eage);
//            Console.WriteLine("EMP NAME: "+example.ename);
//            Console.WriteLine("EMP ADDRESS: "+example.eaddress); 
//        }
//    }
//}
