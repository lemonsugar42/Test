namespace GeometryArea
{
    public class Circle
    {
        public virtual double CircleArea(double radius) // within an accuracy of 0.001
        {
            if (radius < 0) throw new ArgumentOutOfRangeException($"{nameof(radius)} is less than zero");
            else if (radius == 0) return 0;
            return Math.Round(Math.Pow(radius, 2) * Math.PI, 3);
        }
    }
}