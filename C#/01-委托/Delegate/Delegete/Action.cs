using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class MYAction
    {
        public void TestAction() 
        {
            Action action = TestAction1;
            action();

            Action<string> action1 = TestAction2;
            action1("TEST");
        }

        private static void TestAction1()
        {
            Console.WriteLine("Test Action");
        }

        private static void TestAction2(string x)
        {
            Console.WriteLine("Test Action" + x);
        }


    }
}
