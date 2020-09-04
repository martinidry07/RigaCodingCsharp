﻿using System;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample();
            Console.WriteLine("Lūdzu ievadiet divus skaitļus, ar kuriem veikt darbības -");
            double num1 =InputDouble("Pirmais: ");
            double num2 = InputDouble("Otrais: ");
            Console.WriteLine("Ļūdzu izvēlieties, kādu darbību veikt -");
            Console.WriteLine("1 - saskaitīšana,");
            Console.WriteLine("2 - atņemšana,");
            Console.WriteLine("3 - reizināšana,");
            Console.WriteLine("4 - dalīšana,");
            int whatToDo = InputNumberBetween("ko darīsim? - : ", 1, 4);
            double result=0;
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
        static void sample()
        {
            Console.WriteLine("Hello World!");
        }
        static int InputNumberBetween(String text, int num1, int num2)
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
            static double InputDouble(String text)
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
