namespace BonusAssignments.TempConverter
{
    public static class TempConverter
    {
        public static double Convert(double temp, char valueType)
        {
            if (valueType == 'C')
            {
                return (temp * 1.8) + 32;
            }
            else
            {
                return (temp - 32) * 0.5556;
            }
        }
    }
}
