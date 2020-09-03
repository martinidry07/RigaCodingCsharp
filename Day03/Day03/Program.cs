using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample();
            //Task01();
            //Task02();
            extra();
        }
        static void extra()
        {
            int[] arr = FillArr(InputNumberBetween(10, 20));
            printArr(arr);
            sort(arr);
            printArr(arr);
        }
        static void sort(int [] arr)
        {
            int cup = Int32.MaxValue;
            int cupPoz= 0;
            for (int i = 0; i< arr.Length-1; i++)
            {
                for(int j =i; j<arr.Length; j++)
                {
                    if (cup > arr[j])
                    {
                        cup = arr[j];
                        cupPoz = j;                        
                    }                  
                }
                cup = arr[i];
                arr[i] = arr[cupPoz];
                arr[cupPoz] = cup;
                cup = Int32.MaxValue;
            }
        }

        static void Task02()
        {
            String[] strArr = { "vāze", "āva", "piens", "kumēdiņi", "automobīlis", "puķe", "sniegpulkstenīte", "ir", "bailes", "nazis" };
            Console.WriteLine(String.Join(" ",strArr));
            Console.WriteLine("Masīva elementu burtu skaita summa ir " + strLenSum(strArr));


        }
        static int strLenSum(String [] arr)
        {
            int len = 0;
            for (int i =0; i< arr.Length; i++)
            {
                len += (arr[i].Length);
            }
            return len;
        }

        static void Task01()
        {

            int[] arr = FillArr(InputNumberBetween(1, 10));
            printArr(arr);
            nullArr(arr);
            printArr(arr);

        }

        static int[] FillArr(int arrLen)
        {
            int[] arr = new int[arrLen];
            Random rand = new Random();

            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = rand.Next(101);
            }

            return arr;
        }
        static void nullArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 50)
                {
                    arr[i] = 0;
                }

            }
        }
        static void printArr(int[] arr)
        {
            Console.WriteLine(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" ");
        }

        static void Sample()
        {
            Console.WriteLine("Hello World!");
        }
        static int InputNumberBetween( int num1, int num2)
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
