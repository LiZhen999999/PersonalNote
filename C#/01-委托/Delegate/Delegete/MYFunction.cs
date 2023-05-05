using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class MYFunction
    {
        public void TestFunction()
        {
            Func<string> fction = TestFunction1;
            Console.WriteLine(fction());

            Func<string,string> fction1 = TestFunction2;
            Console.WriteLine(fction1("KKK"));
        }

        private static string  TestFunction1()
        {
            return "TEST FUNCTION";
        }

        private static string TestFunction2(string x)
        {
            return "TEST FUNCTION" + x; 
        }
    }
}
