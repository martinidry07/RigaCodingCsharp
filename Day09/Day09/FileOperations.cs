using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day09
{
    class FileOperations
    {
        private const String defaultName = @"D:\Github\";
        public static void Read(String name)
        {
            try
            {
                System.IO.StreamReader sr = new StreamReader(defaultName + name + ".txt");

                String line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }
        }
        public static void Write(List<String> lst)
        {
            string[] files = System.IO.Directory.GetFiles(@"D:\Github\", "Test.txt");
            if (files.Length==0)
            {
                Console.WriteLine("Neizdevas ierakstit failā");
            }
            else
            {
                StreamWriter sw = new StreamWriter(defaultName + "Test.txt", false);
                foreach (String line in lst)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
            }
            


        }
    }
}
