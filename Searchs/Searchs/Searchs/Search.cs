namespace Searchs.Searchs
{
    using System.Collections.Generic;

    public abstract class Search
    {
        protected abstract int InvokeSearch(List<int> list, int i);
        public int Invoke(List<int> list, int i)
        {
            return InvokeSearch(list, i);
        }
    }
}