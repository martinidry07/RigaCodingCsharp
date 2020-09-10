using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            //sampleCar();
            //Task02();
            //sampleList();
            MD();
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

            for ( int i=0; i<5; i++)
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
        
        private static void MD()
        {
            List<Student> listOfStudents = new List<Student>();            

            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine(" "); 
                Console.Write("Lūdzu izvēlieties darbību (1- Izvadīt, 2- Pievienot, 3- Izdzēst, 0- Iziet: ");                
                choice = Console.ReadLine();
                Console.WriteLine(" ");

                switch (choice)
                {
                    case "1":
                        if (listOfStudents.Count == 0)
                        {
                            Console.WriteLine("Saraksts ir tukšs !");
                        }
                        else
                        {
                            foreach (Student ST in listOfStudents )
                            {
                                ST.PrintInfo();
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Lūdzu ievadiet studentu: ");
                        Console.Write("Vārds: ");
                        String name = Console.ReadLine();
                        Console.Write("Uzvārds: ");
                        String surname = Console.ReadLine();
                        int course = InputNumber("Kurss: ");
                        listOfStudents.Add(new Student(name, surname, course));
                        break;
                    case "3":
                        RemoveElement(listOfStudents);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
            
        }
        private static void RemoveElement(List<Student> lst)
        
        {
            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukšs !");
            }
            else
            {
                Console.WriteLine("Studentu saraksts: ");
                for (int i = 0; i < lst.Count; i++)
                {
                    int j = i + 1;
                    Console.Write("students Nr " + j + " - " );
                    lst[i].PrintInfo();
                }
                int rem = InputNumberBetween("Lūdzu izvēlaties izdzēšamo studentu numuru: ", 1, lst.Count) - 1;
                lst.RemoveAt(rem);
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
