namespace Sorts.Sorts
{
    using System.Collections.Generic;

    public class SelectionSort : Sort
    {
        protected override List<int> InvokeSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var smallest = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[smallest])
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