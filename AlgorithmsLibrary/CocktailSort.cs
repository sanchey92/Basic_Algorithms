using System;

namespace AlgorithmsLibrary
{
    public class CocktailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            SwapCount = 0;
            var left = 0;
            var right = Items.Count - 1;

            while (left < right)
            {
                var localSwapCount = SwapCount;

                for (var i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                        ComparisonCount++;
                    }
                }
                right--;
                
                if (localSwapCount == SwapCount) break;

                for (var i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swap(i, i - 1);
                        ComparisonCount++;
                    }
                }
                left++;
                
                if (localSwapCount == SwapCount) break;
            }
        }
    }
}