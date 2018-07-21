using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var list = Enumerable.Range(0, 10).Select(u => rnd.Next(0, 100)).ToList();
            list.ForEach(u => { Console.WriteLine(u); });
            Console.WriteLine();
            quickSort(list).ForEach(u => { Console.WriteLine(u); });
        }
        static List<int> quickSort(List<int> list)
        {
            Random rnd = new Random();
            if (list.Count == 0)
                return list;
            var block = list.First();
            list.RemoveAt(0);
            var lList = list.Where(u => u <= block).ToList();
            var rList = list.Where(u => u > block).ToList();
            var l = quickSort(lList);
            l.Add(block);
            return l.Concat(quickSort(rList)).ToList();
        }
    }
}
