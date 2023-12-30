using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Task
{
    internal class Car
    {
        private string _name;
        private string _color;
        private double _price;
        public const string CompanyName = "Company ltd";

        public Car() : this("no name", "white", 0.0)
        {
        }

        public Car(string name, string color, double price)
        {
            _name = name;
            _color = color;
            _price = price;
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public void Input()
        {
            Console.Write("Input car name -> ");
            _name = Console.ReadLine();
            Console.Write("Input car color -> ");
            _color = Console.ReadLine();
            Console.Write("Input car price - >");
            double.TryParse(Console.ReadLine(), out _price);
        }

        public void Print()
        {
            Console.WriteLine($"The price for the car {_name} of {_color} colour is {_price}");
        }

        public void ChangePrice(double x)
        {
            _price *= 1 + x / 100;
        }

        public static bool operator ==(Car a, Car b)
        {
            return a._name == b._name && a._price == b._price;
        }
        public static bool operator !=(Car a, Car b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return String.Format($"The price for the car {_name} of {_color} colour is {_price}");
        }
    }
}
