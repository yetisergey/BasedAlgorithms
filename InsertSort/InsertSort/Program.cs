namespace InsertSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        const int count = 1024;
        static void Main(string[] args)
        {
            for (int k = 0; k < count; k++)
            {
                Random rnd = new Random();
                var list = Enumerable.Range(0, count).Select(u => rnd.Next(0, count)).ToList();
                if (!list.OrderBy(u => u).ToList().SequenceEqual(insertSort(list)))
                    throw new Exception("Массивы разные!");
            }
        }

        static List<int> insertSort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var x = list[i];
                var j = i;
                while (j > 0 && list[j - 1] > x)
                {
                    list[j] = list[j - 1];
                    j--;
                }
                list[j] = x;
            }
            return list;
        }
    }
}