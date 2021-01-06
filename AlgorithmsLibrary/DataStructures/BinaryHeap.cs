using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary.DataStructures
{
    public class BinaryHeap<T> where T : IComparable
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;
        
        public BinaryHeap(IEnumerable<T> items)
        {
            _items.AddRange(items);
            for (var i = Count; i >= 0; i--)
                Sort(i);
        }

        public T Peek() => Count > 0
            ? _items[0]
            : throw new ArgumentNullException(nameof(_items), "Error!");

        public void Add(T item)
        {
            _items.Add(item);

            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && _items[parentIndex].CompareTo(_items[currentIndex]) == -1)
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        public T GetMax()
        {
            var result = _items[0];
            _items[0] = _items[Count - 1];
            _items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex)
        {
            var maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < Count && _items[leftIndex].CompareTo(_items[maxIndex]) == -1)
                    maxIndex = leftIndex;

                if (rightIndex < Count && _items[rightIndex].CompareTo(_items[maxIndex]) == -1)
                    maxIndex = rightIndex;

                if (maxIndex == currentIndex) break;

                Swap(currentIndex, maxIndex);
            }
        }

        private static int GetParentIndex(int index) => (index - 1) / 2;

        private void Swap(int index1, int index2)
        {
            var temp = _items[index1];
            _items[index1] = _items[index2];
            _items[index2] = temp;
        }

        public List<T> Order()
        {
            var result = new List<T>();
            while (Count > 0)
            {
                result.Add(GetMax());
            }

            return result;
        }
    }
}