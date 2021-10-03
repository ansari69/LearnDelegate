using System;
using System.IO;

namespace FileFolder
{
    class Program
    {
        static void Main(string[] args)
        {



            // Creating a file
            string myfile = "TextFile2.config";

            // Appending the given texts
            using (StreamWriter sw = File.AppendText(myfile))
            {
                sw.WriteLine("Gfg");
                sw.WriteLine("GFG");
                sw.WriteLine("GeeksforGeeks");
            }


            Console.ReadKey();


            //  Console.WriteLine("Hello World!");
        }
    }
}
