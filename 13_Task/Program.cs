using System.IO;
using System.IO.Enumeration;

namespace _13_Task
{
    internal class Program
    {
        //static FileStream fs;

        static void Main(string[] args)
        {
            #region Task
            // 1) Create a class Fruit that contains:
            //  - fields: name and color,
            //  - properties for fields,
            //  - constructor with parameters,
            //  - virtual methods Input() and Print(), for reading data from the console
            //  and outputting data to the console (overload the input-output options from the file).
            //  - override the method ToString().
            // 2) Create a class Citrus derived from the class Fruit, that contains:
            // - field - vitamin C (content in grams),
            // - property,
            // - constructor with parameters,
            // - override Input() and Print() methods.
            // 3) Create a list of fruits and add 5 different fruits and citrus to it.
            // - Print data about 'yellow' fruits.
            // - Sort the list of fruits by name and output the result to a file
            // - Handle exceptions
            // - Serialize-deserialize the list in Xml/Json format
            // - Add unit tests for class methods
            #endregion

            List<Fruit> fruits = new List<Fruit>();

            fruits.Add(new Citrus("Orange", "yellow", 3.4));
            fruits.Add(new Citrus("Lemon", "yellow", 12.5));
            fruits.Add(new Fruit("Kiwi", "orange"));
            fruits.Add(new Fruit("Banana", "yellow"));
            fruits.Add(new Fruit("Watermelon", "green"));

            const string FILE_NAME = "13_Task_test.json";

            using (FileStream fs = new(FILE_NAME, FileMode.Append))
            {
                foreach (var fruit in fruits)
                {
                    fruit.Print(fs);
                }
            }

            Console.WriteLine("List of fruits:");

            List<Fruit> fruitsResult = [];

            //trycatch exists
            using (FileStream fs = new(FILE_NAME, FileMode.Open))
            {
                Citrus c = new();

                while (true)
                {
                    c.Input(fs);
                    if (c.Name == "")
                    {
                        break;
                    }
                    if (c.VitaminC == 0)
                    {
                        fruitsResult.Add(new Fruit(c.Name, c.Color));
                    }
                    else
                    {
                        fruitsResult.Add(c);
                    }
                }
            }

            foreach (var fruit in fruitsResult)
            {
                fruit.Print();
            }

            //string serialized = fruits[2].Serialize();
            //Console.WriteLine(serialized);
            //var deserializedFruit = Citrus.Deserialize(serialized);
            //Console.WriteLine(deserializedFruit.Name);
            //Console.WriteLine(deserializedFruit.Color);
            //Console.WriteLine(deserializedFruit.VitaminC);


            Console.WriteLine("\nList of fruits of color 'yellow':");

            foreach (var fruit in fruits.Where(f => f.Color == "yellow"))
            {
                //cw none if count 0
                fruit.Print();
            }

            Console.WriteLine("\nPress anykey...");
            Console.ReadKey();
        }
    }
}
