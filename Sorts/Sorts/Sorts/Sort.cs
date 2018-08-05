namespace Sorts.Sorts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    public abstract class Sort
    {
        public Stopwatch stopwatch = new Stopwatch();
        protected  abstract List<int> InvokeSort(List<int> list);
        public List<int> Invoke(List<int> list) {
            stopwatch.Reset();
            stopwatch.Start();
            list = InvokeSort(list);
            stopwatch.Stop();
            Console.WriteLine($"{GetType().Name} : {stopwatch.ElapsedMilliseconds}");

            return list;
        }
    }
}