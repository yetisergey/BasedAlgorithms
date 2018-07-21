namespace BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        private const int count = 300;
        static void Main(string[] args)
        {

            Random rnd = new Random();
            var list = Enumerable.Range(0, count).Select(u => rnd.Next(0, count)).ToList();
            list = QuickSort(list);
            for (int i = 0; i < count; i++)
            {
                int r = rnd.Next(0, count);
                int indexBS = BinarySearch(list, r);
                int indexIO = list.IndexOf(r);
                if (indexIO == -1 && indexBS == -1)
                    continue;
                if (list[indexBS] != list[indexIO])
                    throw new Exception("Different values of IndexOf and BinarySearch");
            }
        }

        static List<int> QuickSort(List<int> list)
        {
            if (list.Count == 0)
                return list;

            int key = list.First();
            list.RemoveAt(0);
            var lList = list.Where(u => u <= key).ToList();
            var rList = list.Where(u => u > key).ToList();
            var r = new List<int>();
            r.AddRange(QuickSort(lList));
            r.Add(key);
            r.AddRange(QuickSort(rList));
            return r;
        }

        static int BinarySearch(List<int> list, int i)
        {
            if (list.Count == 0 || list[0] > i || (list.Count == 1 && list[0] != i))
                return -1;

            int half = list.Count / 2;
            int key = list[half];

            if (key == i)
                return half;

            if (key < i)
            {
                int bs = BinarySearch(list.Skip(half).ToList(), i);
                return bs == -1 ? bs : bs + half;
            }
            else
            {
                return BinarySearch(list.Take(list.Count - half).ToList(), i);
            }
        }
    }
}