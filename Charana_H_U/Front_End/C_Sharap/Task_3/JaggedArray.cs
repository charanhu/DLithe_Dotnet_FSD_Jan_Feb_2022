using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class JaggedArray
    {
        static void Main()
        {
            int[][] jagged_array = new int[4][];
            jagged_array[0] = new int[] { 1, 2, 3, 4};
            jagged_array[1] = new int[] { 10, 20};
            jagged_array[2] = new int[] { };
            jagged_array[3] = new int[] { 100, 200, 300};
            for (int i = 0; i<jagged_array.Length; i++)
            {
                Console.Write("Row({0}): ", i);
                for (int j = 0; j< jagged_array[i].Length; j++)
                {
                    Console.Write("{0} ", jagged_array[i][j]);

                }
                Console.WriteLine();
            }
        }
    }
}
