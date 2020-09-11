using System;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            Task01();
            //sampleFileOperations();
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
    }
}
