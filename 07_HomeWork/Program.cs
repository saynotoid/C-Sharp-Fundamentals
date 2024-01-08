using System.Text.RegularExpressions;


namespace _07_HomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // In Main() method declare Dictionary PhoneBook for keeping pairs PersonName-PhoneNumber.  

            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            try
            {
                // 1) From file "phones.txt" read 9 pairs into PhoneBook.
                //  Write only PhoneNumbers into file "Phones.txt". 

                string readPath = "phones.txt";

                using (StreamReader sr = new StreamReader(readPath))
                {
                    for (int i = 0; i < 9; i++)
                    {
                        try
                        {
                            //string[] str = sr.ReadLine().Split('-');
                            string line = sr.ReadLine();
                            if (line == null)
                            {

                            }
                            else
                            {
                                string[] str = line.Split(' ');
                                if (str.Length < 4)
                                {
                                    throw new Exception("File data - wrong format");
                                }
                                else
                                {
                                    PhoneBook.Add(str[0] + " " + str[1], str[3]);
                                }
                            }
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }

                string writePath = "onlyPhones.txt";

                using (StreamWriter sr = new StreamWriter(writePath))
                {
                    foreach (KeyValuePair<string, string> entry in PhoneBook)
                    {
                        // btw thats a useless if statement (misunderstood the Task)
                        if (entry.Key != "")
                        {
                            sr.WriteLine(entry.Value);
                        }
                    }
                }

                // 2) Find and print phone number by the given name (name input from console)

                //Console.WriteLine("Enter Name");
                //string name = Console.ReadLine();

                string readPathInputNames = "names.txt";

                try
                {
                    using (StreamReader sr = new StreamReader(readPathInputNames))
                    {
                        string name = sr.ReadLine();
                        while (name != null)
                        {
                            if (PhoneBook.ContainsKey(name))
                            {
                                Console.WriteLine($"The phone number of {name} is: {PhoneBook[name]}");
                            }
                            else
                            {
                                Console.WriteLine($"Name {name} was not found in phone book.");
                            }
                            name = sr.ReadLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                // 3) Change all phone numbers,
                // which are in format 80######### into new format +380#########.
                // The result write into file «New.txt»

                string writePathNew = "newPhones.txt";

                if (!File.Exists(writePathNew))
                    //{
                    File.Create(writePathNew).Close();
                //Console.WriteLine($"File {writePathNew} was successfully created");
                //}
                //else
                //{
                //    Console.WriteLine($"File {writePathNew} was not created");
                //}


                using (StreamWriter sr = new StreamWriter(writePathNew))
                {
                    foreach (KeyValuePair<string, string> entry in PhoneBook)
                    {
                        if (Regex.Match(entry.Value, @"80#########", RegexOptions.IgnoreCase).Success)
                        {
                            PhoneBook[entry.Key] = "+3" + entry.Value;
                        }
                        sr.WriteLine(entry.Key + " - " + PhoneBook[entry.Key]);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
