namespace Sorts.Sorts
{
    using System.Collections.Generic;
    using System.Linq;
    public class FastSort : Sort
    {
        protected override List<int> InvokeSort(List<int> list)
        {
            if (list.Count == 0)
                return list;
            var block = list.First();
            list.RemoveAt(0);
            var lList = list.Where(u => u <= block).ToList();
            var rList = list.Where(u => u > block).ToList();
            var result = InvokeSort(lList);
            result.Add(block);
            result.AddRange(InvokeSort(rList));
            return result;
        }
    }
}