namespace BonusAssignments.HCF
{
    public static class HCF
    {
        public static int GetHCF(int a, int b, int lcm = 0) => (a * b) / (lcm == 0 ? LCM.LCM.ListingMethod(a, b, 0, 0, true) : lcm);
        public static int ListingMethod(int a, int b)
        {
            var factorsA = GetFactor(a);
            var factorsB = GetFactor(b);
            return FindHighestEqual(factorsA, factorsB);
        }
        public static int DivisionMethod(int a, int b)
        {
            int dividend = a < b ? b : a;
            int divisor = b < a ? b : a;

            while (dividend % divisor != 0)
            {
                int temp = divisor;
                divisor = dividend % divisor;
                dividend = temp;
            }

            return divisor;
        }
        private static int FindHighestEqual(List<int> a, List<int> b)
        {
            var combined = new List<int>();
            foreach (var c in a)
            {
                if (b.Contains(c))
                {
                    combined.Add(c);
                }
            }
            combined.Sort();

            return combined[combined.Count - 1];
        }
        private static List<int> GetFactor(int n)
        {
            var divisors = new List<int>();
            var divisor = 1;
            while (divisor <= n)
            {
                if (n % divisor == 0)
                {
                    divisors.Add(divisor);

                }
                divisor++;
            }

            return divisors;
        }

    }
}
