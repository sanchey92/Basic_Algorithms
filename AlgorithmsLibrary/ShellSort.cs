using System;

namespace AlgorithmsLibrary
{
    public class ShellSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var step = Items.Count / 2;

            while (step > 0)
            {
                for (var i = step; i < Items.Count; i++)
                {
                    var j = i;

                    while (j >= step && Compare(Items[j - step], Items[j]) == 1)
                    {
                        Swap(j - step, j);
                        j -= step;
                    }
                }

                step /= 2;
            }
        }
    }
}