namespace GeometryArea.Tests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void FindArea_2_12dot566()
        {
            double r = 2;
            double expected = 12.566;

            double actual = new Figure().FindArea(r);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindArea__2_5_6__4dot684()
        {
            double a = 2;
            double b = 5;
            double c = 6;
            double expected = 4.684;

            double actual = new Figure().FindArea(new double[] { a, b, c });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleArea_TwoArgs_Exception()
        {
            double x = 3;
            double y = 4;

            new Figure().FindArea(new double[] { x, y });
        }
    }
}