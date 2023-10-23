using ValidationUtility;
namespace TodaysDate
{
    public static class WeekdayFromDate
    {
        public static string CalculateWeekday()
        {
            var userDate = DateTimeValidationHelper.GetDateTime("Enter the date where you want to find out what weekday it is: ");
            return $"The day of the week of the date {userDate:yyyy/MM/dd} is a {userDate.DayOfWeek}";
        }
    }
}