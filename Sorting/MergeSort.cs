namespace BonusAssignments.Sorting
{
    public static class MergeSort
    {
        public static List<int> Sort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }
            var left = Split(list, list.Count / 2, true);
            var right = Split(list, list.Count / 2, false);

            Sort(left);
            Sort(right);

            return Merge(left, right, list);
        }


        private static List<int> Merge(List<int> left, List<int> right, List<int> mergedList)
        {
            int leftIndexer = 0, rightIndexer = 0, mergedIndexer = 0;
            while (leftIndexer < left.Count && rightIndexer < right.Count)
            {
                if (left[leftIndexer] <= right[rightIndexer])
                {
                    mergedList[mergedIndexer++] = left[leftIndexer++];
                }
                else
                {
                    mergedList[mergedIndexer++] = right[rightIndexer++];
                }
            }
            while (leftIndexer < left.Count)
            {
                mergedList[mergedIndexer++] = left[leftIndexer++];
            }
            while (rightIndexer < right.Count)
            {
                mergedList[mergedIndexer++] = right[rightIndexer++];
            }
            return mergedList;
        }
        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> mergedList = new();
            int leftIndexer = 0, rightIndexer = 0;
            while (leftIndexer < left.Count && rightIndexer < right.Count)
            {
                if (left[leftIndexer] <= right[rightIndexer])
                {
                    mergedList.Add(left[leftIndexer++]);
                }
                else
                {
                    mergedList.Add(right[rightIndexer++]);
                }
            }
            while (leftIndexer < left.Count)
            {
                mergedList.Add(left[leftIndexer++]);
            }
            while (rightIndexer < right.Count)
            {
                mergedList.Add(right[rightIndexer++]);
            }
            return mergedList;
        }
        private static List<int> Split(List<int> list, int middle, bool fromZero)
        {
            var splitList = new List<int>();
            if (fromZero)
            {
                for (int low = 0; low < middle; low++)
                {
                    splitList.Add(list[low]);
                }
                return splitList;
            }
            else
            {
                for (int high = middle; high < list.Count; high++)
                {
                    splitList.Add(list[high]);
                }
                return splitList;
            }
        }
    }
}
