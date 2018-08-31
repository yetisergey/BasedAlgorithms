namespace Sorts.Sorts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class OrderBySort : Sort
    {
        protected override List<T> InvokeSort<T>(List<T> list)
        {
            return list.OrderBy(u=>u).ToList();
        }
    }
}