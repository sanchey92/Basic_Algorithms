using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary
{
    public class InsertionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public InsertionSort(IEnumerable<T> items) : base(items) { }
        
        public InsertionSort() { }
        
        public override void Sort()
        {
            for (var i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;

                while (j > 0 && temp.CompareTo(Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                    
                    SwapCount++;
                    ComparisonCount++;
                }
                Items[j] = temp;
            }
        }
    }
}