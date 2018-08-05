namespace Sorts.Sorts
{
    using System.Collections.Generic;
    using System.Linq;
    public class OrderBySort : Sort
    {
        protected override List<int> InvokeSort(List<int> list)
        {
            return list.OrderBy(u => u).ToList();
        }
    }
}