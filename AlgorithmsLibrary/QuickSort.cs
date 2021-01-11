using System;

namespace AlgorithmsLibrary
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public QuickSort() { }

        public override void Sort()
        {
            QSort(0, Items.Count - 1);
        }

        private void QSort(int left, int right)
        {
            if (left > right) return;

            var pivot = Sorting(left, right);

            QSort(left, pivot - 1);
            QSort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;

            for (var i = left; i <= right - 1; i++)
            {
                if (Compare(Items[i], Items[right]) == -1)
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }
            Swap(pointer, right);
            return pointer;
        }
    }
}