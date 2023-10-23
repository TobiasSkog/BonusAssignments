namespace BonusAssignments.LCM
{
    public static class LCM
    {
        public static int ListingMethod(int a, int b, int aCount = 0, int bCount = 0, bool useForHCF = false)
        {
            if (a == b)
            {
                Console.WriteLine($"\tA: {a}\n\tB: {b}");
                return useForHCF ? aCount < bCount ? aCount : bCount : a;
            }
            else
            {
                if (a < b || a % b == 0)
                {
                    aCount++;
                    //Console.WriteLine($"\t\tA: {a} \n\t\tB: {b} \n\t\tA-Count: {aCount}\n\t\tC: {a + (a / aCount)}");
                    var c = a + (a / aCount);
                    return ListingMethod(c, b, aCount, bCount);
                }
                else
                {
                    bCount++;
                    //Console.WriteLine($"\t\tA: {a} \n\t\tB: {b} \n\t\tB-Count: {bCount}\n\t\tC: {a + (a / bCount)}");
                    var c = b + (b / bCount);
                    return ListingMethod(a, c, aCount, bCount);
                }
            }
        }
        public static int DivisionMethod(int a, int b)
        {
            var divisors = new List<int>();
            while (a % 2 == 0 && b % 2 == 0)
            {
                a = a / 2;
                b = b / 2;
                divisors.Add(2);
                if (a % 2 != 0)
                {
                    divisors.Add(a % 2);
                }
                if (b % 2 != 0)
                {
                    divisors.Add(b % 2);
                }
            }
            var lcm = a * b;
            foreach (var divisor in divisors)
            {
                lcm *= divisor;
            }
            Console.WriteLine($"LCM: {lcm}");
            return lcm;
        }
        public static int DivisionMethod(int a, int b, bool refined)
        {
            var divisors = new List<int>();

            while (a > 1 || b > 1)
            {
                var divisor = 2;

                while ((a % divisor != 0) && (b % divisor != 0))
                {
                    divisor++;
                }
                if (a % divisor == 0)
                {
                    a /= divisor;
                }
                if (b % divisor == 0)
                {
                    b /= divisor;
                }
                divisors.Add(divisor);
            }

            var lcm = 1;
            foreach (var divisor in divisors)
            {
                lcm *= divisor;
            }
            Console.WriteLine($"LCM: {lcm}");
            return lcm;
        }
    }
}
