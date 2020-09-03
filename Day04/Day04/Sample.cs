using System;
using System.Collections.Generic;
using System.Text;

namespace Day04
{
    class Sample
    {
        public static void TestPrint()
        {
            Console.WriteLine("Hello World!");
            PrivatePrint();
        }
        private static void PrivatePrint()
        {
            Console.WriteLine("This is private print!");
        }
    }
}
