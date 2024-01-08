using System.Drawing;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Data;
using System.Text;

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

            string writePath = 
                @"O:\!!SoftServe\202312 C#.Net Fundamentals\C-Sharp-Fundamentals\07_Task\DirectoryC.txt";

            string driveName = @"D:\";
            string dirName = @"D:\\";

            DriveInfo drive = new DriveInfo(driveName);

            bool inMood = false;

            try
            {
                if (drive.IsReady)
                {
                    //main code

                    inMood = true;
                    try
                    {
                        if (Directory.Exists(dirName))
                        {
                            string[] dirs = Directory.GetDirectories(dirName);
                            string[] files = Directory.GetFiles(dirName);

                            //writing to the file

                            try
                            {
                                using (StreamWriter sw = new StreamWriter(writePath))
                                {
                                    sw.WriteLine($"Dirs:\n{"name",-25}\t{"creation time",-15}\n");
                                    foreach (string dir in dirs)
                                    {
                                        sw.WriteLine(DirInfoCombiner(new DirectoryInfo(dir)));
                                    }
                                    sw.WriteLine($"\n\nFiles:\n{"name",-25}\t{"type",-15}\t{"size",-15}\n");
                                    foreach (string file in files)
                                    {
                                        sw.WriteLine(FileInfoCombiner(new FileInfo(file)));
                                    }
                                }
                            }
                            catch (FileNotFoundException ex)
                            {
                                Console.WriteLine("File not found...........");
                            }
                            catch (Exception ex)
                            {
                                throw;
                            }
                        }
                        else
                        {
                            throw new DirectoryNotFoundException("O M G dir not found");
                        }
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        Console.WriteLine("im in mood tho! but dir is not... T.T");
                        throw;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    throw new DriveNotFoundException("not ready");
                }
            }
            catch (DriveNotFoundException ex) when (inMood)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("\nWork is DONE!");
                Console.ReadKey();
            }
        }

        static string DirInfoCombiner(DirectoryInfo dir)
        {
            return String.Format($"{(dir.Name.Length > 20 ? dir.Name.Remove(20) : dir.Name),-25}" +
                $"\t{dir.CreationTime,-15}");
        }
        static string FileInfoCombiner(FileInfo file)
        {
            return String.Format($"{(file.Name.Length > 20 ? file.Name.Remove(20) : file.Name),-25}" +
                $"\t{file.Extension,-15}\t{file.Length,-15}");
        }

        static void Task3()
        {
            // Select from directory D only.txt files and print the text from it into console.
            // Catch appropriative exceptions.


        }
    }
}
