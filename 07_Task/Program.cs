using System.Drawing;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace _07_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Task2();

            Task3();

        }

        static void Task1()
        {
            // Read and write all data from data.txt into rez.txt files,
            // by using (Catch appropriative exceptions):
            //  StreamReader StreamWriter
            //  File.WriteAllText

            string readPath = @"O:\!!SoftServe\202312 C#.Net Fundamentals\C-Sharp-Fundamentals\07_Task\data.txt";
            string writePath = @"O:\!!SoftServe\202312 C#.Net Fundamentals\C-Sharp-Fundamentals\07_Task\rez.txt";
            string text = "Hello";

            try
            {
                using (StreamReader sr = new StreamReader(readPath))
                {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File\n\t{readPath}\nnot found, im so sorry ♥");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            FileInfo fileInf = new FileInfo(writePath);
            try
            {
                if (fileInf.Exists)
                {
                    Console.WriteLine($"File\n\t{writePath}\nexists, do u want to overwrite it?\ny/n?");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        System.IO.File.WriteAllText(writePath, text + "\n EVIL addition mwahaha...");
                    }
                    else
                    {
                        throw new Exception("WRONG CHOICE, DUDE. MWAHAHAHA");
                    }
                }
                else
                {
                    throw new FileNotFoundException("im so sorry m8... here take a cookie ♥");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //FileInfo fileInf = new FileInfo(readPath);
            //FileStream fileStream = null;
            //try
            //{
            //    if (fileInf.Exists)
            //    {
            //        fileStream = fileInf.OpenRead();
            //        byte[] buffer = new byte[];
            //        text = fileStream.Read()
            //    }
            //    else
            //    {
            //        throw new FileNotFoundException("im so sorry m8... here take a cookie ♥");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //finally
            //{
            //    fileStream.Close();
            //}            
            //System.IO.File.WriteAllText()
        }

        static void Task2()
        {
            // Write into file ‘DirectoryC.txt’ information(e.g.name, type, size)
            // about all directories and files from disc D on your computer.
            // Catch appropriative exceptions.



        }

        static void Task3()
        {
            // Select from directory D only.txt files and print the text from it into console.
            // Catch appropriative exceptions.

        }
    }
}
