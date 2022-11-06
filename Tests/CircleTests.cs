using Shapes;

namespace Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Constructor_CreatesCircle_ReturnCircle()
        {
            Circle circle1 = new Circle(15);
            
            Assert.IsInstanceOfType(circle1, typeof(Circle));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Radius value should be greater than 0")]
        public void Constructor_CreatesCircle_ThrowsArgumentException()
        {
            new Circle(-15);
        }

        [DataTestMethod]
        [DataRow(1.0)]
        [DataRow(100.0)]
        [DataRow(1000.0)]
        public void Area_CountsArea_ReturnArea(double n)
        {
            var circle = new Circle(n);
            Assert.IsTrue(Math.Abs(circle.Area() - n*n*Math.PI) <= 1e-7);
        }
    }
}
