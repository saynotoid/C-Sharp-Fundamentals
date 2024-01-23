using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace _12_Task
{
    [Serializable]
    public class Triangle
    {
        private Point vertex1;
        private Point vertex2;
        private Point vertex3;

        [JsonPropertyName("V1")]
        public Point Vertex1 { get { return vertex1; } set { vertex1 = value; } }
        [JsonPropertyName("V2")]
        public Point Vertex2 { get { return vertex2; } set { vertex2 = value; } }
        [JsonPropertyName("V3")]
        public Point Vertex3 { get { return vertex3; } set { vertex3 = value; } }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
        }

        public Triangle()
            : this(
                  new Point() { X = 0, Y = 0 },
                  new Point() { X = 0, Y = 0 },
                  new Point() { X = 0, Y = 0 })
        {

        }

        public double Perimeter()
        {
            return vertex1.DistanceTo(vertex2) + vertex2.DistanceTo(vertex3) + vertex3.DistanceTo(Vertex1);
        }

        public double Area()
        {
            // формула Герона
            double perimeterHalved = Perimeter() / 2;

            double deltaA = perimeterHalved - vertex1.DistanceTo(vertex2);
            double deltaB = perimeterHalved - vertex2.DistanceTo(Vertex3);
            double deltaC = perimeterHalved - vertex3.DistanceTo(vertex1);

            double area = Math.Sqrt(
                perimeterHalved
                * deltaA
                * deltaB
                * deltaC);

            return area;
        }

        public Point ClosestVertexToOrigin()
        {
            List<Point> vertices = new List<Point>() { Vertex1, Vertex2, Vertex3 };

            return vertices
                .Aggregate((closest, next)
                => closest.DistanceToOrigin() <= next.DistanceToOrigin() ? closest : next);
        }

        public void Print()
        {
            Console.WriteLine($"Triangle vertices: {Vertex1}, {Vertex2}, {Vertex3}" +
                $"\nPerimeter: {Perimeter()}" +
                $"\nArea: {Area()}");
        }

        public string Serialize()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }

        public static Triangle Deserialize(string s)
        {
            return JsonSerializer.Deserialize<Triangle>(s);
        }

        public void SerializeBinary()
        {
            //            using (Stream sr = new FileStream("SerializeBinary.txt",
            //                FileMode.Create, FileAccess.Write, FileShare.None))
            //            {
            //#pragma warning disable SYSLIB0011 // Type or member is obsolete
            //                IFormatter formatter = new BinaryFormatter();
            //#pragma warning restore SYSLIB0011 // Type or member is obsolete

            //                formatter.Serialize(sr, this);
            //            }
            Console.WriteLine("SerializeBinary Invoked file created");
        }

        public void SerializeXml()
        {
            using (Stream sw = new FileStream("SerializeXml.xml", FileMode.Create))
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(Triangle));
                xmlser.Serialize(sw, this);
            }

            Console.WriteLine("SerializeXml Invoked file created");
        }

        public static Triangle DeserializeXml(string s)
        {
            using (Stream sr = new FileStream(s, FileMode.Open))
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(Triangle));
                return xmlser.Deserialize(sr) as Triangle;

            }
        }
    }
}
