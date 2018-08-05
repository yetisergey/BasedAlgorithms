namespace Sorts.Sorts
{
    using System.Collections.Generic;
    public class ShellSort : Sort
    {
        protected override List<int> InvokeSort(List<int> list)
        {
            int increment = list.Count / 2;
            while (increment >= 1)
            {
                for (int startIndex = 0; startIndex < increment; startIndex++)
                {
                    insertionSort(list, startIndex, increment);
                }
                increment = increment / 2;
            }
            return list;
        }
        private void insertionSort(List<int> list, int startIndex, int increment)
        {
            for (int i = startIndex; i < list.Count - 1; i = i + increment)
            {
                for (int j = (i + increment > list.Count - 1 ? list.Count - 1 : i + increment); j - increment >= 0; j = j - increment)
                {
                    if (list[j - increment] > list[j])
                    {
                        int tmp = list[j];
                        list[j] = list[j - increment];
                        list[j - increment] = tmp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}