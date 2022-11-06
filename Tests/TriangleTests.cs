using Shapes;

namespace Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Constructor_CreatesTriangle_ReturnTriangle()
        {
            Triangle triangle1 = new Triangle(3,4,5);

            Assert.IsInstanceOfType(triangle1, typeof(Triangle));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Length of a side has to be less than the sum of the lengths of other two sides")]
        public void Constructor_CreatesTriangle_ThrowsArgumentException()
        {
            new Triangle(3, 4, 8);
        }

        [DataTestMethod]
        [DataRow(3.0,4.0,5.0)]
        [DataRow(6.0, 3.0, 7.0)]
        [DataRow(11.0, 15.0, 6.0)]
        public void Area_CountsArea_ReturnArea(double a, double b, double c)
        {
            var triangle = new Triangle(a,b,c);

            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            var area = triangle.Area();
            Assert.IsTrue(Math.Abs(area - s) <= 1e-7);
        }

        [TestMethod]
        public void IsRectangled_CheckIfRectangled_ReturnTrue()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(triangle.IsRectangled());
        }

        public void IsRectangled_CheckIfRectangled_ReturnFalse()
        {
            var triangle = new Triangle(3, 4, 3);

            Assert.IsFalse(triangle.IsRectangled());
        }
    }
}
