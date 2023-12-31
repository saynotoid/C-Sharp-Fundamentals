using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _05_Task
{
    internal class Bird : IFlyable
    {
        private string _name;
        private bool _canFly;

        public Bird(string name, bool canFly)
        {
            _name = name;
            _canFly = canFly;
        }

        public Bird() : this("defaultName", false)
        {

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool CanFly
        {
            get => _canFly;
            set => _canFly = value;
        }

        public void Fly()
        {
            if (_canFly)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"This bird named {_name} can fly :)");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"This bird named {_name} can't fly :)");
                Console.ResetColor();
            }
        }
    }
}
