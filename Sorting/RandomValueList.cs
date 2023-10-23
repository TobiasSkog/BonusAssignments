namespace BonusAssignments.Sorting
{
    public static class RandomValueList
    {
        public static List<int> GetIntegerList(int listSize, int randomMax)
        {
            Random rng = new Random();
            var list = new List<int>();
            while (list.Count <= listSize)
            {
                var value = rng.Next(0, randomMax);


                list.Add(value);

            }

            return list;
        }
    }
}
