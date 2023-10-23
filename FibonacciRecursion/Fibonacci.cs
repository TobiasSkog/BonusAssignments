namespace BonusAssignments.FibonacciRecursion
{
    public static class Fibonacci
    {
        public static int GetNthValue(int n)
        {
            if (n > 1)
            {

                return GetNthValue(n - 1) + GetNthValue(n - 2);
            }
            else
            {
                return n;
            }
        }
    }
}
