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
        public static void Write()
        {

            try
            {
                
                StreamWriter sw = new StreamWriter(defaultName + "Test.txt", false);
                sw.WriteLine("Hello, Mārtiņ!");
                sw.WriteLine("Es nomainu ierakstu.");

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}
