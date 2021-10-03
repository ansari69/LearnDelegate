using System;

namespace LearnDelagate1
{
    class Program
    {
        // delegate void Aa(params int[] a);
        // delegate void Aa(int a, int b=20);

        //  delegate void Bb(int a, int b);

        //delegate int Bb(int a, int b);
        delegate TResult Del1<T1, T2, TResult>(T1 a, T2 b);

        static void Main(string[] args)
        {

            Del1<int, int, int> del1 = delegate(int a, int b) { return a + b; };
            var rr = del1(8, 8);

            Action<string> action1 = a => Console.WriteLine(a); 

            action1("gggggggg");

            #region

            //////   Bb bb = delegate (int x, int y) { return x + y; };
            ////Bb bb = (x, y) => x + y;

            ////var result = bb(100, 100);

            //Bb bb = new Bb(test1);
            //bb(60, 60);

            //test2(bb, 50, 50);

            //Aa aa = test1;

            //aa += test1;
            //aa += test1;
            //aa(10, 10);

            //aa(10);


            //Aa aa = test1;

            //aa += test2;
            //aa += test2;


            //aa(10,10,10);

            #endregion

            Console.WriteLine("Hello World! " + rr);
            Console.ReadKey();
        }





        //private static void test1(int a, int b)
        //{
        //    Console.WriteLine("-- " + (a + b));
        //}

        //private static void test2(Bb bb ,int a, int b = 20)
        //{
        //    bb(a,b);
        //   // Console.WriteLine("-- " + (a + b));
        //}

        //private static void test1(int a, int b = 20)
        //{
        //    Console.WriteLine("-- " + (a+b));
        //}

        //private static void test1(params int [] a)
        //{
        //    Console.WriteLine( "-- " + (a[0] + a[1]));
        //}

        //private static void test2(params int[] a)
        //{
        //    Console.WriteLine("-- " + (a[0] + a[1]));
        //}
    }
}
