using System;

namespace Nullable_Demo
{
    class Nullable
    {
        static void Main()
        {
            // Nullable
            Nullable<int> var1 = null;
            Console.WriteLine(var1);

            // HasValue
            if (var1.HasValue)
            {
                Console.WriteLine("HasValue: "+var1.Value);
            }
            else
            {
                Console.WriteLine("HasValue: NULL");
            }

            // GetValueOrDefault
            Console.WriteLine();
            Console.WriteLine("GetValueOrDefault: "+var1.GetValueOrDefault());

            // Shorthand
            int? var2 = null;
            double? var3 = null;
            Console.WriteLine(var2);
            Console.WriteLine(var3);

        }
    }
}