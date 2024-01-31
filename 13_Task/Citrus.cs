using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _13_Task
{
    internal class Citrus : Fruit
    {
        // 2) Create a class Citrus derived from the class Fruit, that contains:
        // - field - vitamin C (content in grams),
        // - property,
        // - constructor with parameters,
        // - override Input() and Print() methods.

        #region fields/props/ctors
        private double _vitaminC;

        public double VitaminC
        {
            get { return _vitaminC; }
            set {  _vitaminC = value; }
        }

        public Citrus(string name = "", string color = "", double vitaminC = 0.0) : base(name, color)
        {
            _vitaminC = vitaminC;
        }
        #endregion

        public override void Input()
        {
            base.Input();

            Console.Write("Input fruit VitaminC contains in gram -> ");
            Color = Console.ReadLine();
        }

        public override void Input(Stream stream)
        {
            //base.Input(stream); only if reading 1 line per property

            // this = $"Fruit {Name} is of {Color} color";
            // this + $" and contains {VitaminC} gram of vitamin C"

            #region no serialization
            //using (StreamReader sr = new StreamReader(stream))
            //{
            //    string[] s = sr.ReadLine().Split(' ');
            //    Name = s[2];
            //    Color = s[5];
            //    //trycatch if Convert
            //    double.TryParse(s[9], out double vitC);
            //    VitaminC = vitC;
            //}
            #endregion

            using (StreamReader sr = new(stream, leaveOpen: true))
            {
                //.EndOfStream(
                sr.DiscardBufferedData();
                string input = sr.ReadLine();
                Citrus c = Deserialize(input);
                Name = c.Name;
                Color = c.Color;
                VitaminC = c.VitaminC;
            }
        }

        public override void Print()
        {
            // this = $"Fruit {Name} is of {Color} color";
            Console.WriteLine(this + $" and contains {VitaminC} gram of vitamin C");
        }

        public override void Print(Stream stream)
        {
            base.Print(stream);

            #region no serialization
            //using (StreamWriter sr = new StreamWriter(stream))
            //{
            //    sr.WriteLine(this + $" and contains {VitaminC} gram of vitamin C");
            //}
            #endregion
        }

        public override string Serialize()
        {
            return JsonSerializer.Serialize(this);
        }

        public static Citrus Deserialize(string s)
        {
            return JsonSerializer.Deserialize<Citrus>(s);
        }
    }
}
