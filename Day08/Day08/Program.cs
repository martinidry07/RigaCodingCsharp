using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            sample();
            //Task01();
            //Extra();
        }

        private static void Extra()
        {
            List<int> listA = new List<int>() { 1, 2, 3, 4 };
            List<int> listB = new List<int>() { 99, 1, 7, 3 };
            List<int> result = new List<int>();

            foreach (int element in listA )
            {
                for (int i=0; i<listB.Count; i++)
                {
                    if (element==listB[i])
                    {
                        result.Add(element);
                        break;
                    }
                }
            }

            Console.WriteLine(" ");
            Console.Write("Abu sarakstu kopīgie elementi ir: ");
            foreach (int rez in result )
            {
                Console.Write(rez + " ");
            }

        }

        private static void Task01()
        {
            List<Taisnsturis> listOfRectangle = new List<Taisnsturis>();
            Console.WriteLine("Lūdzu ievadiet malu garumus (veselus skaitļus) 10 taisnstūriem:");
            int Xedge = 0;
            int Yedge = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine((i + 1) + ".taisnstūris.");
                Xedge = InputNumber("x malas garums: ");
                Yedge = InputNumber("y malas garums: ");
                listOfRectangle.Add(new Taisnsturis(Xedge, Yedge));
            }

            Console.WriteLine(" ");
            Console.WriteLine("Pavisam " + listOfRectangle.Count + " taisnstūri:");
            foreach (Taisnsturis rec in listOfRectangle)
            {
                rec.PrintInfo();
            }
        }
        private static void sample()
        {
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");
            System.IO.DirectoryInfo dirInfo = di.RootDirectory;
            System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

            foreach (System.IO.DirectoryInfo d in dirInfos)
            {
                Console.WriteLine(d.Name);
            }
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
