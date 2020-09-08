using System;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            sample();
            //Task01();

        }
        private static void sample()
        {
            Car car1 = new Car("BMW", "M3", "White");
            car1.PrintInfo();

            Car c2 = new Car();
            c2.PrintInfo();
        }

        private static void Task01()
        {
            Console.WriteLine("Ievadam studentu Nr.1:");

            Console.Write("Vārds: ");
            String name = Console.ReadLine();
            Console.Write("Uzvārds: ");
            String surname = Console.ReadLine();
            int course = InputNumber("Kurss: ");
            Student student1 = new Student(name, surname, course);

            Console.WriteLine("Ievadam studentu Nr.2:");
            Console.Write("Vārds: ");
            name = Console.ReadLine();
            Console.Write("Uzvārds: ");
            surname = Console.ReadLine();
            course = InputNumber("Kurss: ");
            Student student2 = new Student(name, surname, course);

            Console.WriteLine(" ");
            Console.WriteLine("Izvade:");
            student1.PrintInfo();
            student2.PrintInfo();
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
