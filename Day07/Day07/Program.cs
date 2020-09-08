using System;
using System.Collections.Generic;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            //sampleCar();
            Task02();
            //sampleList();

        }

        private static void sampleList()
        {
            List<Car> listOfCars = new List<Car>();

            listOfCars.Add(new Car("Audi", "Coupe", "Blue"));
            listOfCars.Add(new Car("Opel", "Kadet", "Red"));

            listOfCars [0].color = "Black";

            foreach (Car car in listOfCars)
            {
                car.PrintInfo ();
            }
        }
        private static void sampleCar()
        {
            Car car1 = new Car("BMW", "M3", "White");
            car1.PrintInfo();

            Car c2 = new Car();
            c2.PrintInfo();
        }

        private static void Task02()

        {
            List<Student> listOfStudents = new List<Student >();
            String name = "";
            String surname = "";
            int course = 0;

            for ( int i=0; i<2; i++)
            {
                int j = i + 1;
                Console.WriteLine("Ievadam studentu Nr. " + j + ":");
                Console.Write("Vārds: ");
                name = Console.ReadLine();
                Console.Write("Uzvārds: ");
                surname = Console.ReadLine();
                course = InputNumber("Kurss: ");
                listOfStudents.Add(new Student(name, surname, course));
            }

            Console.WriteLine(" ");
            Console.WriteLine("Izvade:");


            foreach (Student  st in listOfStudents )
            {
                st.PrintInfo();
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
            ;
            return number;
        }
    }
}
