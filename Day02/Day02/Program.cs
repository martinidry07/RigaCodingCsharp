using System;
using System.Threading.Tasks.Dataflow;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample();
            //Task01(InputNumberBetween(0, 59));  // Pieprasa no lietotāja skaitli robežās no 0 līdz 59 
            //                          Izvēlas 10 random skaitļus līdz tam skaitlim, no kuriem atrod lielāko.
            //Task01_extra(); // pieprasa lietotājam 10 skaitļus, atrod lielāko.
            //Task02();   // Zīmē no 1 līdz 4 * rindā
            Task03();   // Pieprasa 5 masīva elementus un izvada tos divās rindās no sākuma līdz beigām
            //              un no beigām līdz sākumam. Pēc tam jāpievieno 6.elements.

        }
        static void Sample()
        {
            Console.WriteLine("Hello World!");
        }
        static void Task03()
        {
            // Pieprasa 5 masīva elementus un izvada tos divās rindās no sākuma līdz beigām
            //   un no beigām līdz sākumam. Pēc tam jāpievieno 6.elements.
            Console.WriteLine("Lūdzu ievadīt 5 masīva elementus - skaitļus.");
            int[] arr = new int[5];
            for (int i=0; i<5;i++)
            {
                //Console.Write((i+1) + ". skaitlis: ");
                arr[i] = InputNumber((i + 1) + ". skaitlis: ");
            }
            Console.WriteLine(" ");
            string output2 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                output2 += arr[arr.Length - i - 1];
                if (i != arr.Length - 1)
                {
                    output2 += (", ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(output2);

            int[] arr2 = new int[6];
            arr.CopyTo(arr2,0);
            Console.WriteLine(" ");
            arr2[5] = InputNumber("Ievadi 6. elementu: ");
            Console.WriteLine(" ");
            output2 = "";
            for (int i = 0; i < arr2.Length; i++)
            {
                output2 += arr2[arr2.Length - i - 1];
                if (i != arr2.Length - 1)
                {
                    output2 += (", ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(string.Join(", ", arr2));
            Console.WriteLine(output2);

        }
        static void Task01(int size)
        {
            //Pieprasa no lietotāja skaitli robežās no 0 līdz 59.
            // Izvēlas 10 random skaitļus līdz tam skaitlim, no kuriem atrod lielāko.
            Random rand = new Random();
            int MaxNumber = int.MinValue;
            Console.WriteLine(" ");
            for (int i = 0; i < 10; i++)
            {
                int number = rand.Next(size);
                Console.Write(number);
                if (i != 9)
                {
                    Console.Write(", ");
                }
                if (MaxNumber < number)
                {
                    MaxNumber = number;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Lielākāis ir " + MaxNumber);

        }
        static void Task02()
            // Zīmē no 1 līdz 4 * rindā
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j=0; j<(i+1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            for (int i = 4; i > 0; i--)
            {
                for (int j = i; j>0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
        static void Task01_extra()
        {
            // pieprasa lietotājam 10 skaitļus, atrod lielāko.
            int MaxNumber = int.MinValue;
            Console.WriteLine("Lūdzu ievadiet 10 veselus skaitļus.");
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + ". skaitlis: ");
                int number = InputNumber("");
                if (MaxNumber < number)
                {
                    MaxNumber = number;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Lielākāis ir " + MaxNumber);

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
    }
}
