namespace BonusAssignments.Pythagoras
{
    public class Triangle
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(double a, double b)
        {
            A = a;
            B = b;
            C = UsePythagoras();
        }

        private double UsePythagoras()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }
        public double Hypotenuse()
        {
            return C;
        }
    }
}
