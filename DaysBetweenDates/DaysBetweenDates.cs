namespace DaysBetweenDates
{
    public static class DaysBetweenDates
    {
        public static string CalculateDifference()
        {
            var firstDate = ValidationUtility.DateTimeValidationHelper.GetExactDateTime("Enter the first date", "yyyy/MM/dd");
            var secondDate = ValidationUtility.DateTimeValidationHelper.GetExactDateTime("Enter the first date", "yyyy/MM/dd");
            TimeSpan timeDif = firstDate < secondDate ? (secondDate - firstDate) : (firstDate - secondDate);

            return $"Total amount of days between {firstDate:yyyy/MM/dd} and {secondDate:yyyy/MM/dd} is {timeDif.TotalDays} days";
        }
    }
}