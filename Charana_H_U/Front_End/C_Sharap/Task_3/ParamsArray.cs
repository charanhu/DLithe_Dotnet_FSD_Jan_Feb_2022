using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class ParamsArray
    {
        public static int Addition(params int[] Numbers)
        {
            int total = 0;
            foreach (int num in Numbers)
            {
                total += num;
            }
            return total;
        }

        public static void Main()
        {
            int y = Addition(10, 20, 30, 40);
            Console.WriteLine("Total Sum is: "+y);
        }
    }
}
