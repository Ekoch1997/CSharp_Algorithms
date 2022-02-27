using System;

namespace Tutorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                4,3,5,6,7,8,9,10,11,12,13,3,2,1
            };


            Console.WriteLine(list.Count);

            int fast = 0;
            int slow = 0;
            int counter = 0;


            do
            {
                slow = list[slow];
                fast = list[list[fast]];
            } while (fast != slow);

            int slow2 = 0;

            while (slow2 != slow)
            {
                slow2 = list[slow2];
                slow = list[slow];
            }

            Console.WriteLine(slow);
        }
    }
}