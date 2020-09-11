using System;
using System.Collections.Generic;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            Task03(); 
            //Task02();
            //Task01();
            //sampleFileOperations();
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
            FileOperations.Write("new", newLst );

        }
        private static void Task02()
        {
            List<String> lst = new List<String>() { "Ābols","Burkāns","Tomāts","Redīs","Gurķis","Biete","Kartupelis"};
            FileOperations.Write("Test", lst);
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
            Console.Write("Izvēies, kuru failu atvērt, ieraksti faila numuru: ");

            for (int i = 0; i < files.Length; i++)
            {
                // Create the FileInfo object only when needed to ensure
                // the information is as current as possible.
                System.IO.FileInfo fi = null;
                try
                {
                    fi = new System.IO.FileInfo(files[i]);
                }
                catch (System.IO.FileNotFoundException e)
                {
                    // To inform the user and continue is
                    // sufficient for this demonstration.
                    // Your application may require different behavior.
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("{0} : {1}", i + 1, fi.Name);
            }
            Console.Write("Izvēies, kuru failu atvērt, ieraksti faila numuru: ");

        }
    }
}
