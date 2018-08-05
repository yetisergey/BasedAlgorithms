namespace Sorts.Sorts
{
    using System.Collections.Generic;

    public class BubbleSort : Sort
    {
        protected override List<int> InvokeSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] < list[j])
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