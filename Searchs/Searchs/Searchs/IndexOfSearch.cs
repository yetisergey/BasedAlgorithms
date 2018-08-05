namespace Searchs.Searchs
{
    using System.Collections.Generic;
    public class IndexOfSearch : Search
    {
        protected override int InvokeSearch(List<int> list, int i)
        {
            return list.IndexOf(i);
        }
    }
}