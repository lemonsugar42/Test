namespace GeometryArea.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleArea_3_28dot274()
        {
            double r = 3;
            double expected = 28.274;

            double actual = new Circle().CircleArea(r);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleArea_0_0()
        {
            double r = 0;
            double expected = 0;

            double actual = new Circle().CircleArea(r);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CircleArea_Negative_Exception()
        {
            Random rnd = new Random();
            double r = rnd.NextDouble() * (0 - Double.MinValue) + Double.MinValue;

            new Circle().CircleArea(r);
        }
    }
}