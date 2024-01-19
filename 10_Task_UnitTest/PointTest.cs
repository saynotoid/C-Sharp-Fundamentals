using _10_Task;

namespace _10_Task_UnitTest
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void ToStringTestMethod()
        {
            string expectedResult = string.Format("");// $"({x},{y})");

            string actualResult = "";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsInstanceofTypeTestMethod(Point point, Triangle triangle)
        {

        }
    }
}