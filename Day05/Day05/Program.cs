using System;
using System.Collections.Generic;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample();
            //Task01();
            Task02();

        }
        private static void Task02()
        {
            List<String> myList = new List<String> ();
            Boolean dan = false;
            do
            {
                Console.Write("Lūdzu izvēlieties darbību (1- pievienot elementu, 2- izvadīt Listu, 3- iziet : ");
                int whatToDo = InputNumberBetween("", 1, 3);
                switch (whatToDo)
                {
                    case 1:
                        Console.Write("Ievadiet List elementu: ");
                        myList.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine();
                        if (myList.Count == 0)
                        {
                            Console.WriteLine("Lists ir tukšs");
                        }
                        else
                        {
                            Console.WriteLine(string.Join(", ", myList));
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        dan = true;
                        break;
                }
            } while (!dan);
        }

        private static void Task01()
        {
            Console.WriteLine("Lūdzu ievadiet divus skaitļus, ar kuriem veikt darbības -");
            double num1 = InputDouble("Pirmais: ");
            double num2 = InputDouble("Otrais: ");
            Console.WriteLine("Ļūdzu izvēlieties, kādu darbību veikt -");
            Console.WriteLine("1 - saskaitīšana,");
            Console.WriteLine("2 - atņemšana,");
            Console.WriteLine("3 - reizināšana,");
            Console.WriteLine("4 - dalīšana,");
            int whatToDo = InputNumberBetween("ko darīsim? - : ", 1, 4);
            double result = 0;
            switch (whatToDo)
            {
                case 1:
                    result = MyCalculator.numCounting(num1, num2);
                    break;
                case 2:
                    result = MyCalculator.numSubtract(num1, num2);
                    break;
                case 3:
                    result = MyCalculator.numMultiplay(num1, num2);
                    break;
                case 4:
                    result = MyCalculator.numDivide(num1, num2);
                    break;
            }
            Console.WriteLine("Rezultāts ir " + result);
        }
        private static void sample()
        {
            List<String> lst = new List<String>() { "a", "b" };
            foreach (String value in lst)
            {
                Console.WriteLine(value);
            }
        }
        private static void sampleWithArray()
        {
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(" ", array));
            array = addLine(array, 3);
            Console.WriteLine(string.Join(" ", array));
        }
        private static int[] addLine(int[] newArr, int howMany)
        {
            int[] arr2 = new int[newArr.Length + howMany];
            newArr.CopyTo(arr2, 0);
            return arr2;
        }
        private static int InputNumberBetween(String text, int num1, int num2)
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
                }
                if (number < num1 || number > num2 || BadInput)
                {
                    Console.WriteLine("ievade neatbilst nosacījumiem !");
                    BadInput = true;
                }
            } while (BadInput);
            return number;
        }
        private static int InputNumber(String text)
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
        private static double InputDouble(String text)
        {
            Boolean BadInput;
            double number = 0;
            do
            {
                BadInput = false;
                Console.Write(text);
                String input = Console.ReadLine();
                try
                {
                    number = Convert.ToDouble(input);
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

}
