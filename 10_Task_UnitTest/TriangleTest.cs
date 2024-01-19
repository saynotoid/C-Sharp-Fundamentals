using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _10_Task;

namespace _10_Task_UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void DistanceTestMethod1()
        {
            Triangle triangle = new Triangle(
                new Point() { X = 0, Y = 0 },
                new Point() { X = 4, Y = 0 },
                new Point() { X = 0, Y = 3 });

            double expectedResult = 4.0;

            double actualResult = triangle.Distance(triangle.Vertex1,triangle.Vertex2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DistanceTestMethod2()
        {
            Triangle triangle = new Triangle(
                new Point() { X = 0, Y = 0 },
                new Point() { X = 4, Y = 0 },
                new Point() { X = 0, Y = 3 });

            double expectedResult = 3.0;

            double actualResult = triangle.Distance(triangle.Vertex1, triangle.Vertex3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DistanceTestMethod3()
        {
            Triangle triangle = new Triangle(
                new Point() { X = 0, Y = 0 },
                new Point() { X = 4, Y = 0 },
                new Point() { X = 0, Y = 3 });

            double expectedResult = 5.0;

            double actualResult = triangle.Distance(triangle.Vertex2, triangle.Vertex3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DistanceTestMethod4()
        {
            Triangle triangle = new Triangle(
                new Point() { X = -2, Y = 0 },
                new Point() { X = 2, Y = 0 },
                new Point() { X = -2, Y = 3 });

            double expectedResult = 5.0;

            double actualResult = triangle.Distance(triangle.Vertex2, triangle.Vertex3);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
