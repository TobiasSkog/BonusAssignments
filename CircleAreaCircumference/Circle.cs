namespace CircleAreaCircumference
{
    public class Circle
    {
        private const double PI = Math.PI;
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public string GetAreaAndCircumference()
        {

            return $"The area of the circle is: {GetArea():.##} and its circumference is {GetCircumference():.##}";
        }
        private double GetArea()
        {
            return PI * Math.Pow(Radius, 2);
        }
        private double GetCircumference()
        {
            return 2 * PI * Radius;
        }
    }
}