namespace AgeCalculator
{
    public static class AgeCalculator
    {
        public static string CalculateAge()
        {
            var today = DateTime.Now;
            var userBD = ValidationUtility.DateTimeValidationHelper.GetExactDateTime("Enter your birthdate", "yyyy/MM/dd");
            var years = today.Year - userBD.Year;
            var months = today.Month - userBD.Month;
            var days = today.Day - userBD.Day;
            if (months <= 0 || days <= 0)
            {
                if (months < 0)
                {
                    months += 12;

                }
                if (days < 0)
                {
                    var daysNegative = today.Day - userBD.Day;
                    var maxDaysThisMonth = DateTime.DaysInMonth(today.Year, today.Month);
                    days = maxDaysThisMonth + daysNegative;
                }
                years--;
            }
            years = years < 0 ? 11 : years;
            return $"You are {years} years, {months} months and {days} days old!";
        }

    }
}