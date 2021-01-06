using System;
using AlgorithmsLibrary.DataStructures;

namespace AlgorithmsLibrary
{
    public class HeapSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            var heap = new BinaryHeap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}