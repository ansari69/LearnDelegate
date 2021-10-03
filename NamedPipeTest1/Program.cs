using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Pipes;

namespace NamedPipeTest1
{
    class Program
    {
        delegate void ArithmeticDelegate(int num1, int num2);

        static void Add(int x, int y)
        {
            Console.WriteLine("Sum is {0}.", x + y);
        }

        static void Add1(int x, int y)
        {
            Console.WriteLine("Sum is {0}.", x + y + 2);
        }

        static void Main(string[] args)
        {

            ArithmeticDelegate Operation /*= Add*/;
             Operation = new ArithmeticDelegate(Add);

             Operation(10, 5);
             Operation += Add1;

            Operation(30, 30);

            //  Operation.Invoke(10, 10); 

            Console.ReadKey();

            #region
            //using (NamedPipeServerStream pipeServer =
            //   new NamedPipeServerStream("testpipe", PipeDirection.Out))
            //{
            //    Console.WriteLine("NamedPipeServerStream object created.");

            //    // Wait for a client to connect
            //    Console.Write("Waiting for client connection...");
            //    pipeServer.WaitForConnection();

            //    Console.WriteLine("Client connected.");
            //    try
            //    {
            //        // Read user input and send that to the client process.
            //        using (StreamWriter sw = new StreamWriter(pipeServer))
            //        {
            //            sw.AutoFlush = true;
            //            Console.Write("Enter text: ");
            //            sw.WriteLine(Console.ReadLine());
            //        }
            //    }
            //    // Catch the IOException that is raised if the pipe is broken
            //    // or disconnected.
            //    catch (IOException e)
            //    {
            //        Console.WriteLine("ERROR: {0}", e.Message);
            //    }
            //}


            // Console.WriteLine("Hello World!");

            #endregion
        }


    }
}
