using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05_Task
{
    internal class Plane : IFlyable
    {
        private string _mark;
        private bool _highFly;

        public Plane(string mark, bool highFly)
        {
            _mark = mark;
            _highFly = highFly;
        }

        public Plane() : this("defaultMark", false)
        {

        }

        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public bool HighFly
        {
            get => _highFly;
            set => _highFly = value;
        }

        public void Fly ()
        {
            if (_highFly)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"This plane marked {_mark} can high fly :)");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"This plane marked {_mark} can't high fly :)");
                Console.ResetColor();
            }

        }
    }
}
