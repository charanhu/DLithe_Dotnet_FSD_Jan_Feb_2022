using System;

namespace String_Demo
{
    class String
    {
        static void Main()
        {
            // Strings 
            string var1 = "Hello!, I'm Charan";
            Console.WriteLine(var1);

            // string length
            string var2 = "This is Bootcamp";
            Console.WriteLine("String Length: " + var2.Length);

            // string concatenation
            Console.WriteLine(var1 + var2);

            // string interpolation
            string var3 = "String1";
            string var4 = "String2";
            string var5 = $"{var3} and {var4}";
            Console.WriteLine(var5);
            Console.WriteLine();

            // Access string
            string var6 = "This is Welcome Meassage";
            Console.WriteLine("String Access: " + var6[5]);

            // IndexOf()
            string var7 = "This is Welcome Meassage";
            Console.WriteLine("First Index: " + var7.IndexOf("M"));

            // LastIndexOf
            string var8 = "This is Welcome Meassage";
            Console.WriteLine("Last Index: "+var8.LastIndexOf("e"));

        }
    }
}