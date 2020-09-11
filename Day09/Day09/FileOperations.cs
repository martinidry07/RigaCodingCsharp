using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day09
{
    class FileOperations
    {
        private const String defaultName = @"D:\Github\";
        public static List<String> Read(string name)
        {
            List<String> lst = new List<String>();
            try
            {
                System.IO.StreamReader sr = new StreamReader(defaultName + name + ".txt");

                String line = sr.ReadLine();

                while (line != null)
                {
                    lst.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }
            return lst;
        }
        public static void Write(String name, String line)
        {
            
                try
                {
                    StreamWriter sw = new StreamWriter(defaultName + name + ".txt", true);
                    sw.WriteLine(line);

                    sw.Close();
                }
                catch
                {
                    Console.WriteLine("Neizdevas ierakstit faila!");
                }
            
        }
    }
}
