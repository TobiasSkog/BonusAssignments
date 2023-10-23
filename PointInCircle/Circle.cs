namespace BonusAssignments.PointInCircle
{
    public class Circle
    {
        public Point Center { get; private set; }
        public double Radius { get; private set; }
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }
        public bool PointInsideCircle(Point point)
        {
            var distance = Math.Sqrt((Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2)));
            return distance <= Radius ? true : false;
            // √((x2 - x1)^2 + (y2 - y1)^2).
            // x2 = point.x || y2 = point.y
            // x1 = circle.Point.x || y1 = circle.Point.y
        }
    }
}
