namespace GeometryArea
{
    public class Figure
    {
        public double FindArea(params double[] p)
        {
            int count = p.Count();
            switch(count)
            {
                case 1:
                    return new Circle().CircleArea(p[0]);
                case 3:
                    return new Triangle().TriangleArea(p[0], p[1], p[2]);
                default:
                    throw new ArgumentException("Wrong amount of arguments");
            }
        }
    }
}
