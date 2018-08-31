namespace Sorts.Sorts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FastSort : Sort
    {
        protected override List<T> InvokeSort<T>(List<T> list)
        {
            if (list.Count == 0)
                return list;
            var block = list.First();
            list.RemoveAt(0);
            var lList = list.Where(u => u.CompareTo(block) <= 0).ToList();
            var rList = list.Where(u => u.CompareTo(block) > 0).ToList();
            var result = InvokeSort(lList);
            result.Add(block);
            result.AddRange(InvokeSort(rList));
            return result;
        }
    }
}