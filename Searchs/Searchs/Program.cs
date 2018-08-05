namespace Searchs
{
    using Searchs;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        const int count = 300;

        static List<Search> searchs = new List<Search>() {
            new BinarySearch(),
            new IndexOfSearch()
        };

        static void Main(string[] args)
        {
            Random rnd = new Random();
            var list = Enumerable.Range(0, count).Select(u => rnd.Next(0, count)).ToList();
            list = list.OrderBy(u => u).ToList();
            var results = new List<int>();
            var key = rnd.Next(0, count);
            foreach (var search in searchs)
            {
                results.Add(search.Invoke(list.ToList(), key));
            }
            if (TestResults.Run(list, results))
                Console.WriteLine("Success!");
            else
                Console.WriteLine("Error");
        }
    }
}