using System;
using System.Collections.Generic;

namespace Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample();
            Task01();
        }

        private static void Task01()
        {
            List<Taisnsturis> listOfRectangle = new List<Taisnsturis>();
            Console.WriteLine("Lūdzu ievadiet malu garumus (veselus skaitļus) 10 taisnstūriem:");
            int Xedge = 0;
            int Yedge = 0;

            for (int i=0; i<10; i++)
            {
                int j = i + 1;
                Console.WriteLine(" ");
                Console.WriteLine(j + ".taisnstūris.");
                Xedge = InputNumber((i+1) + "x malas garums: ");
                Yedge = InputNumber("y malas garums: ");
                listOfRectangle.Add(new Taisnsturis(Xedge, Yedge));
            }

            Console.WriteLine(" ");
            Console.WriteLine("Pavisam " + listOfRectangle.Count + ".taisnstūri:");
            foreach (Taisnsturis rec in listOfRectangle)
            {
                rec.PrintInfo();
            }
        }
        private static void sample()
        {
            Console.WriteLine("Hello World!");
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
