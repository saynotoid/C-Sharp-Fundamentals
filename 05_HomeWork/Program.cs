using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System;

namespace _05_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create interface IDeveloper with property Tool, methods Create() and Destroy()
            //
            // Create two classes
            // Programmer(with field language) and
            // Builder(with field tool),
            // which implement this interface.
            //
            // Create array or list of IDeveloper.
            // Add some Programmers and Builders to it.
            // Call Create() and Destroy() methods for all of it
            //
            // Implement interface IComparable for clases and sort array or list of IDeveloper
            
            IDeveloper builder1 = new Builder();
            IDeveloper builder2 = new Builder();
            IDeveloper programmer = new Programmer();
            builder1.Tool = "hammer";
            builder2.Tool = "saw";
            programmer.Tool = "C#";
            IDeveloper[] devs = { builder1, builder2, programmer };

            TeamWork.SortTeamMembers(devs);

            builder1.CompareTo(builder2);

            Console.WriteLine(devs[0].Tool);
            Console.WriteLine(devs[1].Tool);
            Console.WriteLine(devs[2].Tool);

            //
            // Create Console Application project in VS.
            // In the Main() method declare Dictionary<uint, string>.
            // Add to Dictionary from Console 7 pairs(ID, Name) of some persons.
            // Ask user to enter ID, then find and write corresponding Name from your Dictionary.
            // If you can't find this ID - say about it to user.

            //Create class Meeting with private field people of type Dictionary<uint, string>.
            //Add method Initialize to the Meeting class which adds to Dictionary 7 pairs(ID, Name)
            //of some persons from the console.
            //(For each person method should ask "Please, enter Id",
            //then read an Id from the console, then ask "Please, enter name"
            //and read name from the console).
            //
            //Add method FindPerson to the Meeting class.
            //The method should ask user to enter Id,
            //then find and write the corresponding Name from the people field to the console.
            //
            //If this ID can't be found - "not found" should be printed.

            Meeting meeting = new Meeting();

            meeting.Initialize();
            meeting.FindPerson();
        }
    }
}
