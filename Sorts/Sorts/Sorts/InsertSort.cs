namespace Sorts.Sorts
{
    using System.Collections.Generic;

    public class InsertSort : Sort
    {
        protected override List<int> InvokeSort(List<int> list)
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