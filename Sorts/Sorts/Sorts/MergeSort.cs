namespace Sorts.Sorts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MergeSort : Sort
    {
        protected override List<T> InvokeSort<T>(List<T> list)
        {
            if (list.Count <= 1)
                return list;
            var left = InvokeSort(list.Take(list.Count / 2).ToList());
            var right = InvokeSort(list.Skip(list.Count / 2).ToList());
            return Merge(left, right);
        }

        private List<T> Merge<T>(List<T> left, List<T> right) where T : IComparable
        {
            var result = new List<T>();
            while (left.Count > 0 && right.Count > 0)
            {
                T temp;
                if (left.First().CompareTo( right.First()) <=0)
                {
                    temp = left.FirstOrDefault();
                    left.RemoveAt(0);
                }
                else
                {
                    temp = right.FirstOrDefault();
                    right.RemoveAt(0);
                }
                result.Add(temp);
            }
            result.AddRange(left);
            result.AddRange(right);
            return result;
        }
    }
}