using System;

namespace Day04
{
    class Day04_Clases

    {
        static void Main(string[] args)
        {
            //samples();
            InputNumber("Ievadi to: ");
            Sample.TestPrint();
        }
        static void samples()
        {
            Console.WriteLine("Hello World!");
        }
        static int InputNumberBetween(int num1, int num2)
        {
            Boolean BadInput;
            int number = 0;
            do
            {
                BadInput = false;
                Console.Write("Ieveadi veselu pozitīvu skaitli robežās stap " + num1 + " un " + num2 + ": ");
                String input = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(input);
                }
                catch
                {
                    BadInput = true;
                }
                if (number < num1 || number > num2 || BadInput)
                {
                    Console.WriteLine("ievade neatbilst nosacījumiem !");
                    BadInput = true;
                }
            } while (BadInput);
            return number;
        }
        static int InputNumber(String text)
        {
            Boolean BadInput;
            int number = 0;
            do
            {
                BadInput = false;
                Console.Write(text);
                String input = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(input);
                }
                catch
                {
                    BadInput = true;
                    Console.WriteLine("Ievade neatbilst nosacījumiem !");
                }
            } while (BadInput);
            return number;
        }
    }
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
