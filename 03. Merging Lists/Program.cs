using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var finalList = new List<int>();
            int maxIndex = Math.Max(list1.Count, list2.Count);

            for (int i = 0; i < maxIndex; i++)
            {
                if (i<list1.Count)
                {
                    finalList.Add(list1[i]);
                }
                if (i<list2.Count)
                {
                    finalList.Add(list2[i]);
                }
            }
            Console.WriteLine(string.Join(" ",finalList));
        }
    }
}
