namespace BonusAssignments.WhenIsEaster.Logic
{
    public class MetonsCykel
    {
        public static Tuple<int, int> GetMetonsCykel(int year)
        {

            Dictionary<Func<int, bool>, Tuple<int, int>> MetonsCykelTabel = new()
      {
        { x => x >= 1583 && x <= 1699, new Tuple<int, int>(22, 2) },
        { x => x >= 1700 && x <= 1799, new Tuple<int, int>(23, 3) },
        { x => x >= 1800 && x <= 1899, new Tuple<int, int>(23, 4) },
        { x => x >= 1900 && x <= 1999, new Tuple<int, int>(24, 5) },
        { x => x >= 2000 && x <= 2099, new Tuple<int, int>(24, 5) },
        { x => x >= 2100 && x <= 2199, new Tuple<int, int>(24, 6) },
        { x => x >= 2200 && x <= 2299, new Tuple<int, int>(25, 0) },
        { x => x >= 2300 && x <= 2399, new Tuple<int, int>(26, 1) },
        { x => x >= 2400 && x <= 2499, new Tuple<int, int>(25, 1) },
        { x => x >= 2500 && x <= 2599, new Tuple<int, int>(26, 2) }
      };

            foreach (var tableValue in MetonsCykelTabel)
            {
                if (tableValue.Key(year))
                {
                    return tableValue.Value;
                }
            }

            return default;
        }
    }
}
