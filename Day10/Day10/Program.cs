using System;
using System.Collections.Generic;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            List<int> lst = FileOperations.Read();

            String choice = "";
            PrintLst(lst);


            while (choice != "0")
            {
                Console.Write("0 - Iziet, 1- Pievienot sarakstam, 2 - Dzēst, 3 - Skaitļu summa, 4 - Vidējā vērtība: ");
               choice = Console.ReadLine();
                Console.WriteLine(" ");

                switch (choice)
                {                   
                    case "1":
                        AddElement(lst);
                        PrintLst(lst);
                        break;
                    case "2":
                        RemoveElement(lst);
                        PrintLst(lst);
                        break;
                    case "0":
                        break;
                    case "3":
                        Console.WriteLine("Saraksta skaitļu summa ir " + sumList(lst));
                        Console.WriteLine(" ");
                        break;
                    case "4":
                        double avg = avgList(lst);
                        if (avg!=0)
                        {
                            Console.WriteLine("Saraksta skaitļu vidējais ir " + avg);
                            Console.WriteLine(" ");
                        }
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }

        private static double avgList(List<int> lst)
        {
            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return 0;
            }
            return (sumList(lst)/ (double)lst.Count);
        }

        private static int sumList(List<int> lst)
        {
            int sum = 0;
            foreach (int number in lst)
            {
                sum += number;
            }
            return sum;
        }

        private static void PrintLst(List<int> lst)
        {
            Console.WriteLine();

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + lst[i]);
            }
            Console.WriteLine();
        }
        private static void RemoveElement(List<int> lst)
        {
            Console.WriteLine();

            PrintLst(lst);

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }
            Console.WriteLine("Kuru elementu velaties dzest?");
            int toDelete = InputNumberBetween("Kuru elementu velaties dzest?: ", 0, lst.Count);
            lst.RemoveAt(toDelete - 1);
            FileOperations.Write(lst);
            Console.WriteLine();
        }

        private static void AddElement(List<int> lst)
        {
            Console.WriteLine();
            lst.Add(InputNumber("Ievadiet elementu!: "));
            FileOperations.Write(lst);
            Console.WriteLine();
        }
        private static int InputNumber(String text)
        {
            int number = 0;
            Console.Write(text);
            String input = Console.ReadLine();
            try
            {
                number = Convert.ToInt32(input);
            }
            catch
            {
                return InputNumber("Ievade neatbilst nosacījumiem ! Mēģini vēlreiz: ");
            }
            if (number < 1)
            {
                return InputNumber("Ievade neatbilst nosacījumiem ! Mēģini vēlreiz: ");
            }

            return number;
        }
        private static int InputNumberBetween(String text, int num1, int num2)
        {

            int number = 0;
            Console.Write(text);
            String input = Console.ReadLine();
            try
            {
                number = Convert.ToInt32(input);
            }
            catch
            {
                return InputNumberBetween("Ievade neatbilst nosacījumiem ! Mēģini vēlreiz: ", num1, num2);
            }
            if (number < num1 || number > num2)
            {
                return InputNumberBetween("Ievade neatbilst nosacījumiem ! Mēģini vēlreiz: ", num1, num2);
            }
            return number;
        }
    }
}
