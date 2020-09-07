using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pozitīvs - Negatīvs
            Console.Write("Ieveadi 1 skaitli: ");
            String input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine(IsPositive(number));

            // Jautā cik skaitļi, pieprasa to ievadi un atgriež šo skaitļu summu
            Console.WriteLine(" ");
            Task02(InputNumberBetween(1, 10));

            // kāpināšana
            Console.WriteLine(" ");
            Console.WriteLine("Tagad būs jāievada divi skaitļi - kāpināmais un kapinātājs.");
            Console.WriteLine("Pimais jāievada kāpināmais.");
            int toBeRaised = InputNumberBetween(1, 30);
            Console.WriteLine("Otrais jāievada kāpinātājs.");
            int booster = InputNumberBetween(2, 6);
            int result = Raising(toBeRaised, booster);
            Console.WriteLine(" ");
            Console.WriteLine(toBeRaised + " kāpināts " + booster + ".pakāpē ir vienāds ar " + result);
        }

        static void Task01()
        {
            Console.Write("Ieveadi 1 skaitli: ");
            String input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            Console.WriteLine(" ");
            if (number > 5)
            {
                Console.WriteLine(" **");
            }
            else
            {
                Console.WriteLine(" *");
            }
        }

        static void Task02(int HowMuch)
        {
            Console.WriteLine("Ieveadi " + HowMuch + " skaitļus: ");

            int summa = 0;

            for (int i = 1; i <= HowMuch; i++)
            {
                Console.Write(i + ".skaitlis: ");
                String input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                summa += number;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Skaitļu summa ir: " + summa);
        }

        static Boolean IsPositive(int number)
        {
            Boolean answer = true;
            if (number < 0) 
            {
                answer = false;
            }
            return answer;
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

        static int Raising(int toBeRaised, int booster)
        {
            int result = toBeRaised;
            for (int i = 1; i < booster; i++)
            {
                result *=  toBeRaised;
            }
            // float result = MathF.Pow((float)toBeRaised, (float)booster);   variants izmantojot iebūvēto
            //return (int)result;
            return result;
        }

        static void Sample(string[] args)
        {
            int skaitlis = 5;
            Console.WriteLine("Ieveadi skaitli: ");
            String input = Console.ReadLine();
            int number = 0;
            try
            {
                number = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Ievade nav ok");
            }
            Console.WriteLine("Pirmais skaitlis: " + skaitlis + ", otrais number: " + number);
        }

    }
}
