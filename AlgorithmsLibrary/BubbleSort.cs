using System;

namespace AlgorithmsLibrary
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;

            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count - 1 - j; j++)
                {
                    var firstItem = Items[j];
                    var secondItem = Items[j + 1];

                    if (firstItem.CompareTo(secondItem) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
            }
        }
    }
}