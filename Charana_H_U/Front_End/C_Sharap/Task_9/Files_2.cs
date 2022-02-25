using System;
using System.IO;  // include the System.IO namespace

namespace Files
{
    class Files_2
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!, I'm Charan.";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}