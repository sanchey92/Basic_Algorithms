using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();

        protected void Swap(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;

                SwapCount++;
            }
        }

        public virtual void Sort()
        {
            SwapCount = 0;
            Items.Sort();
        }
    }
}