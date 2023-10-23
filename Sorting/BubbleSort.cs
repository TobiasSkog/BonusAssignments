namespace BonusAssignments.Sorting
{
    public static class BubbleSort
    {
        public static List<int> Sort(List<int> list)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return list;
        }
    }
}
