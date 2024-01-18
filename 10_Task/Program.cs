namespace _10_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create struct Point:
            // -fields x and y,
            // -method ToString(), which return the Point in format "(x,y)"
            // 
            // Create class Triangle:
            // -fields vertex1, vertex2, vertex3 of type Point
            // -constructors
            // - method Distance() to calculate distance between points
            // - methods Perimeter(), Area(), Print()
            // 
            // In the Main() create list of 3 triangles
            // and write into console the information about these shapes.
            //
            // *Print the triangle with vertex which is the closest to origin(0,0)

            List<Triangle> triangles = new List<Triangle>();

            triangles.Add(new Triangle(
                new Point() { X = 3, Y = 4.5 },
                new Point() { X = 5, Y = 7 },
                new Point() { X = 4, Y = 8 }));

            triangles.Add(new Triangle(
                new Point() { X = 1, Y = 1 },
                new Point() { X = 2, Y = 5 },
                new Point() { X = 8, Y = 1 }));

            triangles.Add(new Triangle(
                new Point() { X = 42, Y = 7 },
                new Point() { X = 2, Y = 13 },
                new Point() { X = 0, Y = 0 }));

            foreach (Triangle triangle in triangles)
            {
                triangle.Print();
            }

            Triangle closetToOriginTriangle = null;
            Point origin = new Point() { X = 0, Y = 0 };
            double lowestDelta = 0;

            foreach (Triangle triangle in triangles)
            {
                List<double> deltas = new List<double>()
                {
                    triangle.Distance(triangle.Vertex1, origin),
                    triangle.Distance(triangle.Vertex2, origin),
                    triangle.Distance(triangle.Vertex3, origin)
                };

                if (deltas.Min() < lowestDelta || lowestDelta == 0)
                {
                    lowestDelta = deltas.Min();
                    closetToOriginTriangle = triangle;
                }
                else
                {
                    continue;
                }
            }

            if (closetToOriginTriangle != null)
            {
                Console.WriteLine("The closet to origin triangle is:\n");
                closetToOriginTriangle.Print();
            }
            else
            {
                Console.WriteLine("Smthing went wrong");
            }

            Console.WriteLine("\ndone");
        }
    }
}
