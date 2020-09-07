using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample();
        }
        private static void Sample()
        {
            Console.WriteLine("Hello World!");
        }
        private static void ListSample()
        {
            List<String> lst = new List<String>();
            String choise = "";

            while (choise!="0")
            {
                Console.WriteLine("1 - Izvadīt");
                Console.WriteLine("2 - Pievienot");
                Console.WriteLine("0 - Iziet");
                choise = Console.ReadLine();
                
                switch(choise)
                {
                    case "0":
                        break;
                    case "1":
                        break;
                    case "2":
                        
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
