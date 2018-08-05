namespace Sorts.Sorts
{
    using System.Collections.Generic;
    using System.Linq;
    public class MergeSort : Sort
    {
        protected override List<int> InvokeSort(List<int> list)
        {
            if (list.Count <= 1)
                return list;
            var left = InvokeSort(list.Take(list.Count / 2).ToList());
            var right = InvokeSort(list.Skip(list.Count / 2).ToList());
            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                var temp = 0;
                if (left.First() <= right.First())
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