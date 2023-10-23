namespace BonusAssignments.Prime
{
    public static class PrimeNumberControll
    {
        public static bool IsPrimeNumber(int number)
        {
            if (number < 2)
            {
                return false;
            }

            int divisor = 2;
            while (divisor < number)
            {
                if (number % divisor == 0 && number != divisor)
                {
                    Console.WriteLine($"{number} is not a prime number!");
                    return false;
                }
                divisor++;
            }
            Console.WriteLine($"\t{number} is a prime number!");
            return true;
        }
    }
}
