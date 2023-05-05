using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate  void Test();
        delegate double Test2(double x);
        static void Main(string[] args)
        {
            Test test = null;
            test = TestDelegate;
            //test();

            Test2 test2 = TestDelegate2;
            //Console.WriteLine(test2(100));

            Test2[] test2s = { TestDelegate2 , TestDelegate3 };
            //foreach(Test2 test21 in test2s) 
            //{
            //    Console.WriteLine(test21(100));
            //}

            MYAction mYAction = new MYAction();
            mYAction.TestAction();

            MYFunction mYFunction = new MYFunction();
            mYFunction.TestFunction();

            Console.ReadLine();
        }

        public static void TestDelegate()
        {
            Console.WriteLine("TestDelegate");
        }

        public static double TestDelegate2(double x)
        { 
            return x+1;
        }

        public static double TestDelegate3(double x)
        {
            return x + 2;
        }


    }
}
