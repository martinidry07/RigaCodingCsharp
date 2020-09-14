using Serilog;
using System;
using System.Collections.Generic;

namespace AboutFilesFoldersDrives
{
    class Program
    {
        public class RecursiveFileSearch
        {
            private static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();


            static void Main(string[] args)
            {
                //aboutSystemDrive();
                //otherDrives();
                test();
            }
            private static void test()
            {
                string[] drives = System.Environment.GetLogicalDrives();
                System.IO.DirectoryInfo[] subDirs = null;

                foreach (string dr in drives)
                {
                    System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

                    // Here we skip the drive if it is not ready to be read. This
                    // is not necessarily the appropriate action in all scenarios.
                    if (!di.IsReady)
                    {
                        Console.WriteLine("The drive {0} could not be read", di.Name);
                        continue;
                    }
                    System.IO.DirectoryInfo rootDir = di.RootDirectory;
                    Console.WriteLine(di.Name );
                    subDirs = rootDir.GetDirectories();
                    foreach (System.IO.DirectoryInfo dir in subDirs)
                    {
                        Console.WriteLine(dir.Name); // Name ir direktorijas nosaukums, bet FullName pilns nosaukums sākot no diska
                        //Console.WriteLine(dir.FullName);
                    }
                }
            }
            
            private static void otherDrives()
            {
                // Start with drives if you have to search the entire computer.
                string[] drives = System.Environment.GetLogicalDrives();

                foreach (string dr in drives)
                {
                    System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

                    // Here we skip the drive if it is not ready to be read. This
                    // is not necessarily the appropriate action in all scenarios.
                    if (!di.IsReady)
                    {
                        Console.WriteLine("The drive {0} could not be read", di.Name);
                        continue;
                    }
                    System.IO.DirectoryInfo rootDir = di.RootDirectory;
                    WalkDirectoryTree(rootDir);
                }

                // Write out all the files that could not be processed.
                Console.WriteLine("Files with restricted access:");
                foreach (string s in log)
                {
                    Console.WriteLine(s);
                }
                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key");
                Console.ReadKey();
            }

            static void WalkDirectoryTree(System.IO.DirectoryInfo root)
            {
                System.IO.FileInfo[] files = null;
                System.IO.DirectoryInfo[] subDirs = null;

                // First, process all the files directly under this folder
                try
                {
                    files = root.GetFiles("*.*");
                }
                // This is thrown if even one of the files requires permissions greater
                // than the application provides.
                catch (UnauthorizedAccessException e)
                {
                    // This code just writes out the message and continues to recurse.
                    // You may decide to do something different here. For example, you
                    // can try to elevate your privileges and access the file again.
                    //Log.Add(e.Message);
                }

                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }

                if (files != null)
                {
                    foreach (System.IO.FileInfo fi in files)
                    {
                        // In this example, we only access the existing FileInfo object. If we
                        // want to open, delete or modify the file, then
                        // a try-catch block is required here to handle the case
                        // where the file has been deleted since the call to TraverseTree().
                        Console.WriteLine(fi.FullName);
                    }

                    // Now find all the subdirectories under this directory.
                    subDirs = root.GetDirectories();

                    foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                    {
                        // Resursive call for each subdirectory.
                        WalkDirectoryTree(dirInfo);
                    }
                }
            }
            private static void aboutSystemDrive()
            {
                // You can also use System.Environment.GetLogicalDrives to
                // obtain names of all logical drives on the computer.
                System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");
                Console.WriteLine(di.TotalFreeSpace);
                Console.WriteLine(di.VolumeLabel);

                // Get the root directory and print out some information about it.
                System.IO.DirectoryInfo dirInfo = di.RootDirectory;
                Console.WriteLine(dirInfo.Attributes.ToString());

                // Get the files in the directory and print out some information about them.
                System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*");

                foreach (System.IO.FileInfo fi in fileNames)
                {
                    Console.WriteLine("{0}: {1}: {2}", fi.Name, fi.LastAccessTime, fi.Length);
                }

                // Get the subdirectories directly that is under the root.
                // See "How to: Iterate Through a Directory Tree" for an example of how to
                // iterate through an entire tree.
                System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

                foreach (System.IO.DirectoryInfo d in dirInfos)
                {
                    Console.WriteLine(d.Name);
                }

                // The Directory and File classes provide several static methods
                // for accessing files and directories.

                // Get the current application directory.
                string currentDirName = System.IO.Directory.GetCurrentDirectory();
                Console.WriteLine(currentDirName);

                // Get an array of file names as strings rather than FileInfo objects.
                // Use this method when storage space is an issue, and when you might
                // hold on to the file name reference for a while before you try to access
                // the file.
                string[] files = System.IO.Directory.GetFiles(currentDirName, "*.txt");

                foreach (string s in files)
                {
                    // Create the FileInfo object only when needed to ensure
                    // the information is as current as possible.
                    System.IO.FileInfo fi = null;
                    try
                    {
                        fi = new System.IO.FileInfo(s);
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        // To inform the user and continue is
                        // sufficient for this demonstration.
                        // Your application may require different behavior.
                        Console.WriteLine(e.Message);
                        continue;
                    }
                    Console.WriteLine("{0} : {1}", fi.Name, fi.Directory);
                }

                // Change the directory. In this case, first check to see
                // whether it already exists, and create it if it does not.
                // If this is not appropriate for your application, you can
                // handle the System.IO.IOException that will be raised if the
                // directory cannot be found.
                if (!System.IO.Directory.Exists(@"C:\Users\Public\TestFolder\"))
                {
                    System.IO.Directory.CreateDirectory(@"C:\Users\Public\TestFolder\");
                }

                System.IO.Directory.SetCurrentDirectory(@"C:\Users\Public\TestFolder\");

                currentDirName = System.IO.Directory.GetCurrentDirectory();
                Console.WriteLine(currentDirName);

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
