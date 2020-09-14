using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day10
{
    class FileOperations
    {
        private const String defaultPath = @"D:\Github\";
        private const String filename = "Test.txt";
        public static List<int> Read()
        {
            List<int> lstOfElements = new List<int>();
            List<int> bugs = new List<int>();
            int lineCount = 0;
            int number = 0;
            try
            {

                StreamReader sr = new StreamReader(defaultPath + filename);

                String line = sr.ReadLine();

                while (line != null)
                {
                    lineCount++;
                    number = returnInt(line);
                    if (number == Int32.MinValue)
                    {
                        bugs.Add(lineCount);
                    }
                    else
                    {
                        lstOfElements.Add(number);
                    }
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }
            if (bugs.Count !=0)
            {
                foreach (int bug in bugs)
                {
                    Console.Write("{0}. ", bug);
                }
                Console.WriteLine("rindā kļūda!");
                Console.WriteLine(" ");
                Write(lstOfElements);
            }
            return lstOfElements;
        }
        private static int returnInt (String line)
        {
            int returnWalue = 0;
            try
            {
                returnWalue  = Convert.ToInt32(line);
            }
            catch
            {
                returnWalue = Int32.MinValue;
            }
            return returnWalue;
        }

        public static void Write(List<int> lst)
        {

            try
            {
                StreamWriter sw = new StreamWriter(defaultPath + filename, false);

                foreach (int el in lst)
                {
                    String line = el + "";
                    sw.WriteLine(line);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}
