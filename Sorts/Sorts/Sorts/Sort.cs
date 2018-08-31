namespace Sorts.Sorts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    public abstract class Sort
    {
        public Stopwatch stopwatch = new Stopwatch();
        protected abstract List<T> InvokeSort<T>(List<T> list) where T:IComparable;
        public List<T> Invoke<T>(List<T> list) where T : IComparable
        {
            stopwatch.Reset();
            stopwatch.Start();
            list = InvokeSort(list);
            stopwatch.Stop();
            Console.WriteLine($"{GetType().Name} : {stopwatch.ElapsedMilliseconds}");

            return list;
        }
    }
}