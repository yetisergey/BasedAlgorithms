namespace Sorts
{
    using Sorts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        const int count = 10000;
        static List<Sort> sorts = new List<Sort>() {
            new ShellSort(),
            new BubbleSort(),
            new SelectionSort(),
            new InsertSort(),
            new MergeSort(),
            new FastSort(),
            new OrderBySort()
        };

        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                var list = Enumerable.Range(0, count).Select(u => rnd.Next(0, count)).ToList();
                var listOfResults = new List<List<int>>();

                foreach (var sort in sorts)
                {
                    listOfResults.Add(sort.Invoke(list.ToList()));
                }

                if (TestResults.Run(listOfResults))
                    Console.WriteLine($"Success! Best of Sorts is { sorts.OrderBy(u => u.stopwatch.Elapsed).First().GetType().Name }");
                else
                    Console.WriteLine($"Fail sort!");

                Console.ReadLine();
            }
        }
    }
}