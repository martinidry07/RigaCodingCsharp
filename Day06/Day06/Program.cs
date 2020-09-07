﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample();
            Task01();
        }
        private static void Sample()
        {
            Car car1 = new Car();   // Izasaucam konstruktoru un izsaucam jaunu ..
            car1.SetColor("Red");
            car1.brand = "Volkswagen";
            car1.model = "Jetta";
            Car car2 = new Car();
            car2.SetColor("White");
            car2.brand = "BMW";
            car2.model = "M3";

            car1.PrintInfo();
            car2.PrintInfo();
        }
        private static void Task01()
        {
            Console.WriteLine("Ievadam studentu Nr.1:" );
            Student student1 = new Student();
            Console.Write("Vārds: ");
            student1.name = Console.ReadLine();
            Console.Write("Uzvārds: ");
            student1.surname = Console.ReadLine();
            student1.course = InputNumber("Kurss: ");

            Console.WriteLine("Ievadam studentu Nr.2:");
            Student student2 = new Student();
            Console.Write("Vārds: ");
            student2.name = Console.ReadLine();
            Console.Write("Uzvārds: ");
            student2.surname = Console.ReadLine();
            student2.course = InputNumber("Kurss: ");

            Console.WriteLine(" ");
            Console.WriteLine("Izvade:");
            student1.PrintInfo();
            student2.PrintInfo();

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
            ;
            return number;
        }

    }
}
