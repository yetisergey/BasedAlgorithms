namespace Sorts.Sorts
{
    using System;
    using System.Collections.Generic;

    public sealed class BubbleSort : Sort
    {
        protected override List<T> InvokeSort<T>(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].CompareTo(list[j]) < 0)
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}