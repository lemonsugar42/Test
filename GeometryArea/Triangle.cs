namespace GeometryArea
{
    public class Triangle
    {
        public double TriangleArea(double a, double b, double c) // within an accuracy of 0.001
        {
            if (a == 0 && b == 0 && c == 0) return 0;
            else if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentOutOfRangeException("Incorrect sides. Non-positive");
            else if (a >= b + c || b >= a + c || c >= a + b) throw new ArgumentOutOfRangeException("Incorrect sides. No triangle");

            double[] temp = new double[3] { a, b, c };
            temp.OrderBy(x => Math.Pow(x, 2));
            if (temp[0] == temp[1] + temp[2]) // right triangle
            {
                return 0.5 * temp[1] * temp[2];
            }

            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
        }
    }
}
