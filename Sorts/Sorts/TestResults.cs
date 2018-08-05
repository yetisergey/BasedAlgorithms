namespace Sorts
{
    using System.Collections.Generic;
    using System.Linq;
    public static class TestResults
    {
        public static bool Run(List<List<int>> results)
        {
            var temp = results[0];

            for (int i = 1; i < results.Count; i++)
            {
                if (!temp.SequenceEqual(results[i]))
                    return false;
            }
            return true;
        }
    }
}