﻿namespace _10_HomeWork
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

            triangles.Add(new Triangle(new Point(0, 0), new Point(1, 0), new Point(0, 1)));
            triangles.Add(new Triangle(new Point(0, 0), new Point(2, 0), new Point(1, 2)));
            triangles.Add(new Triangle(new Point(1, 1), new Point(4, 1), new Point(1, 3)));

            foreach (Triangle triangle in triangles)
            {
                triangle.Print();
            }

            Console.WriteLine("\nTriangle with a vertex closest to the origin:");

            triangles
                .Aggregate((closest, next) 
                => closest.ClosestVertexToOrigin().DistanceToOrigin()
                    <= next.ClosestVertexToOrigin().DistanceToOrigin()
                    ? closest : next)
                .Print();
        }
    }
}
