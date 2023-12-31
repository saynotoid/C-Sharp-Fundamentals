﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HomeWork
{
    internal class Meeting
    {
        private Dictionary<uint, string> people;

        public void Initialize()
        {
            people = new Dictionary<uint, string>();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Please, enter Id");
                uint.TryParse(Console.ReadLine(), out uint id);
                Console.WriteLine("Please, enter name");
                string name = Console.ReadLine();
                people.Add(id, name);
            }
        }

        public void FindPerson()
        {
            Console.WriteLine("Please, enter Id");
            uint.TryParse(Console.ReadLine(), out uint id);

            if (people.TryGetValue(id, out string name))
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
    }
}
