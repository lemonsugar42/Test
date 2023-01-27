namespace GeometryArea.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleArea__13_15_17__93dot9()
        {
            double a = 13;
            double b = 15;
            double c = 17;
            double expected = 93.9;

            double actual = new Triangle().TriangleArea(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea__0_0_0__0()
        {
            double a, b, c;
            a = b = c = 0;
            double expected = 0;

            double actual = new Triangle().TriangleArea(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleArea_NonNegative_Exception()
        {
            double a = -2;
            double b = 0;
            double c = 3.7;

            new Triangle().TriangleArea(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleArea_WrongSides_Exception()
        {
            double a = 1;
            double b = 2.25;
            double c = 10;

            new Triangle().TriangleArea(a, b, c);
        }

        [TestMethod]
        public void TriangleArea__3_4_5__0()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            double actual = new Triangle().TriangleArea(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}