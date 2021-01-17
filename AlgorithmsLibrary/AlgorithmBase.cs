using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary
{
    public class AlgorithmBase<T> where T : IComparable
    {
        protected int SwapCount { get; set; } = 0;
        protected int ComparisonCount { get; set; } = 0;
        protected List<T> Items { get; set; } = new List<T>();

        protected AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        protected AlgorithmBase() { }

        protected void Swap(int positionA, int positionB)
        {
            if (positionA >= Items.Count || positionB >= Items.Count) return;
            var temp = Items[positionA];
            Items[positionA] = Items[positionB];
            Items[positionB] = temp;

            SwapCount++;
        }

        public virtual void Sort()
        {
            SwapCount = 0;
            Items.Sort();
        }

        protected int Compare(T a, T b)
        {
            ComparisonCount++;
            return a.CompareTo(b);
        }
    }
}