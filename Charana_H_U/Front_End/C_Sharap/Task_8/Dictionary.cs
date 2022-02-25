// C# Collections
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionary_Example
{
    class Dictionary
    {
        static void Main()
        {
            var pair = new Dictionary<string, string>();           // dictionary collection
            pair.Add("KA", "Karnataka");                                                // add keys and values
            pair.Add("KL", "Kerala");
            pair.Add("MH", "Maharastra");
            pair.Add("UP", "Uttar Pradesh");
            pair.Add("TN", "Tamil Nadu");
            pair.Add("AP", "Andhra Pradesh");
            Console.WriteLine("Keys present in the dictionary:");
            var key = new List<string>(pair.Keys);
            foreach (string k in key)
            {
                Console.WriteLine("{0}", k);
            }
            Console.WriteLine("Values present in the dictionary:");
            var value = new List<string>(pair.Values);
            foreach (string val in value)
            {
                Console.WriteLine("{0}", val);
            }
            Console.ReadLine();
        }
    }
}