using System;
using System.Collections.Generic;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {

            Task04(); 
            //Task02();
            //Task01();
            //sampleFileOperations();
            //getFileNnames();

        }


        private static void Task04()
        {
            List<String> myList = new List<String>();
            int whatToDo=0 ;

            do
            {
                Console.Write("Lūdzu izvēlieties darbību (1- pievienot elementu, 2- izvadīt Listu, 3- iziet : ");
                whatToDo = InputNumberBetween("", 1, 3);
                switch (whatToDo)
                {
                    case 1:
                        Console.Write("Ievadiet List elementu: ");
                        FileOperations.Write("Test", Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine();
                        myList = FileOperations.Read("Test");
                        if (myList.Count == 0)
                        {
                            Console.WriteLine("Lists ir tukšs");
                        }
                        else
                        {
                            Console.WriteLine(string.Join(", ", myList));
                        }
                        Console.WriteLine();
                        break;
                }
            } while (whatToDo!=3);
        }
        private static void Task03()
        {
            List<String> lst= new List<String>();
            List<String> newLst = new List<String>();
            lst = FileOperations.Read("Test");
            for (int i=lst.Count-1; i>-1; i--)
            {
                newLst.Add(lst[i]);
            }
            //FileOperations.Write("new", newLst );

        }
        private static void Task02()
        {
            List<String> lst = new List<String>() { "Ābols","Burkāns","Tomāts","Redīs","Gurķis","Biete","Kartupelis"};
            //FileOperations.Write("Test", lst);
            FileOperations.Read("Test");
        }
        private static void sampleFileOperations()
        {
            //FileOperations.Write();

            FileOperations.Read("Test");
        }
        private static void Task01()
        {
            Console.Write("Ieraksti faila nosaukumu: ");
            String name = Console.ReadLine();
            FileOperations.Read(name);
        }
        private static void getFileNnames()
        {
            string[] files = System.IO.Directory.GetFiles(@"D:\Github\", "*.txt");

            for (int i = 0; i < files.Length; i++)
            {
                System.IO.FileInfo fi = null;
                try
                {
                    fi = new System.IO.FileInfo(files[i]);
                }
                catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("{0} : {1}", i + 1, fi.Name);
            }
            Console.WriteLine(" ");
            Console.Write("Izvēies, kuru failu atvērt, ieraksti faila numuru: ");

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
