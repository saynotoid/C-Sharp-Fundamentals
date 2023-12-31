using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System;

namespace _04_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define class Person. Class Person should consist of:
            // a) two private fields: name and birthYear(the birthday year).
            //      (As a type for this field you may use DataTime type.)
            // b) two properties for access to these fields(can use only get)
            // c) default constructor and constructor with 2 parameters
            // d) methods: - Age() - to calculate the age of person
            // 	  - Input() - to enter data about person from console
            // 	  - ChangeName() - to change the name of person
            // 	  - ToString()
            // 	  - Output() - to output information about person(call ToString())
            // 	  - operator== (equal by name)
            // 	
            // In the method Main() create 6 objects of Person type and enter information about them.
            // Then calculate and output on the console name and Age of each person;
            // Change the name of persons, which Age is less then 16, to "Very Young".
            // Output information about all persons on the console.
            // Find and output information about Persons with the same names (use ==).

            Person[] persons = new Person[6];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person();
                persons[i].Input();
            }

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"{persons[i].Name} is {persons[i].Age()} years old.");
            }


            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Age() < 16)
                    persons[i].ChangeName("Very Young");
            }
            Console.WriteLine("\nInformation about all persons:");
            foreach (var item in persons)
            {
                item.Output();
            }

            Console.WriteLine("\nPersons with the same names:");
            bool areThereSame = false;
            for (int i = 0; i < persons.Length - 1; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        persons[i].Output();
                        persons[j].Output();
                        areThereSame = true;
                        break;
                    }
                }
            }
            if (!areThereSame)
                Console.WriteLine("\nabsent");
        }
    }
}
