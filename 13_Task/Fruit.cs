using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _13_Task
{
    internal class Fruit
    {
        // 1) Create a class Fruit that contains:
        //  - fields: name and color,
        //  - properties for fields,
        //  - constructor with parameters,
        //  - virtual methods Input() and Print(), for reading data from the console
        //  and outputting data to the console (overload the input-output options from the file).
        //  - override the method ToString().

        #region fields/props/ctors
        private string _name;
        private string _color;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Color
        {
            get => _color; set { _color = value; }
        }

        public Fruit(string name, string color)
        {
            _name = name;
            _color = color;
        }
        #endregion

        public virtual void Input()
        {
            Console.Write("Input fruit name -> ");
            Name = Console.ReadLine();

            Console.Write("Input fruit color -> ");
            Color = Console.ReadLine();
        }

        public virtual void Input(Stream stream)
        {
            #region no serialization
            //using (StreamReader sr = new StreamReader(stream))
            //{
            //    string[] s = sr.ReadLine().Split(' ');
            //    Name = s[2];
            //    Color = s[5];
            //}
            #endregion

            using (StreamReader sr = new(stream))
            {
                Fruit f = Deserialize(sr.ReadLine());
                Name = f.Name;
                Color = f.Color;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine(this);
        }

        public virtual void Print(Stream stream)
        {
            #region no serialization
            //using (StreamWriter sr = new StreamWriter(stream))
            //{
            //    sr.WriteLine(this);
            //}
            #endregion

            using StreamWriter sr = new(stream, leaveOpen: true);
            sr.WriteLine(Serialize());
        }

        public virtual string Serialize()
        {
            return JsonSerializer.Serialize(this);
            //, new JsonSerializerOptions { WriteIndented = true });
        }

        public static Fruit Deserialize(string s)
        {
            return JsonSerializer.Deserialize<Fruit>(s);
        }

        public override string ToString()
        {
            return $"Fruit {Name} is of {Color} color";
        }
    }
}
