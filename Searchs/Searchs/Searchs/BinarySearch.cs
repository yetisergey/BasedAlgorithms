namespace Searchs.Searchs
{
    using System.Collections.Generic;
    using System.Linq;
    public class BinarySearch : Search
    {
        protected override int InvokeSearch(List<int> list, int i)
        {
            return Binary(list, i);
        }
        static int Binary(List<int> list, int i)
        {
            if (list.Count == 0 || list[0] > i || (list.Count == 1 && list[0] != i))
                return -1;

            int half = list.Count / 2;
            int key = list[half];

            if (key == i)
                return half;

            if (key < i)
            {
                int bs = Binary(list.Skip(half).ToList(), i);
                return bs == -1 ? bs : bs + half;
            }
            else
            {
                return Binary(list.Take(list.Count - half).ToList(), i);
            }
        }
    }
}