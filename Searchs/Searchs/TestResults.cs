namespace Searchs
{
    using System.Collections.Generic;
    using System.Linq;

    public static class TestResults
    {
        public static bool Run(List<int> list, List<int> results)
        {
            if (results.All(u => u == -1))
                return true;

            var temp = list[results[0]];

            for (int i = 0; i < results.Count; i++)
            {
                if (temp != list[results[i]])
                    return false;
            }

            return true;
        }
    }
}