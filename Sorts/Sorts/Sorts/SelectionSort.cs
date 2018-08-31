namespace Sorts.Sorts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SelectionSort : Sort
    {
        protected override List<T> InvokeSort<T>(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var smallest = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].CompareTo(list[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                var temp = list[i];
                list[i] = list[smallest];
                list[smallest] = temp;

            }
            return list;
        }
    }
}