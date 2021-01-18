using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsLibrary
{
    public class MergeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MergeSort() { }

        public override void Sort()
        {
            Items = SortList(Items);
        }

        private List<T> SortList(List<T> items)
        {
            if (items.Count == 1) return items;

            var middle = items.Count / 2;
            var left = items.Take(middle).ToList();
            var right = items.Skip(middle).ToList();

            return Merge(SortList(left), SortList(right));
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var result = new List<T>();
            var length = left.Count + right.Count;
            var leftPointer = 0;
            var rightPointer = 0;

            for (var i = 0; i < length; i++)
            {
                if (leftPointer < left.Count && rightPointer < right.Count)
                {
                    if (Compare(left[leftPointer], right[rightPointer]) == -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer < right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }

            return result;
        }
    }
}