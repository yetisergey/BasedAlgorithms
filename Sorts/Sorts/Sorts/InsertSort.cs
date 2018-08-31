namespace Sorts.Sorts
{
    using System.Collections.Generic;

    public class InsertSort : Sort
    {
        protected override List<T> InvokeSort<T>(List<T> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var x = list[i];
                var j = i;
                while (j > 0 && x.CompareTo(list[j - 1]) < 0)
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