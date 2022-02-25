
public class MergedIntervals
{
    public static void Main(string[] args)
    {
        List<int[]> list = new List<int[]>
            {
                new int[] { 6, 8 },
                new int[] { 22, 25 },
                new int[] { 1, 4 },
                new int[] { 12, 14 },
                new int[] { 16, 20 },
                new int[] { 7, 12 }
            };

        Console.WriteLine("---UnsortedList---");
        foreach (int[] item in list)
            Console.WriteLine(item[0] + "," + item[1]);

        //Sort based on the leading element in the list
        bool isSorted = false;
        while (!isSorted)
        {
            if (list.Count == 1) break;

            isSorted = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i + 1][0] < list[i][0])
                {
                    int[] nextItem = list[i + 1];
                    list[i + 1] = list[i];
                    list[i] = nextItem;
                    isSorted = false;
                }
            }
        }

        Console.WriteLine("---SortedList---");
        foreach (int[] item in list)
            Console.WriteLine(item[0] + "," + item[1]);

        //Merge Intervals
        List<int[]> mergedList = new List<int[]>();
        int[] currentInterval = { 0, 0 };
        for (int i = 0; i < list.Count; i++)
        {
            if (i == 0)
            {
                mergedList.Add(list[i]);
            }
            else
            {
                if (list[i][0] <= currentInterval[1])
                {
                    currentInterval[1] = Math.Max(list[i][1], currentInterval[1]);
                    mergedList[^1][1] = currentInterval[1];
                }
                else
                {
                    mergedList.Add(list[i]);
                }
            }
            currentInterval = mergedList[^1];
        }

        Console.WriteLine("---MergedIntervals---");
        foreach (int[] item in mergedList)
            Console.WriteLine(item[0] + "," + item[1]);
    }
}