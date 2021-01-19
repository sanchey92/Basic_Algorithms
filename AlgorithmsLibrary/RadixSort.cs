using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary
{
    public class RadixSort<T> : AlgorithmBase<T> where T : IComparable, IKey
    {
        public RadixSort() { }

        public RadixSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            var groups = new List<List<T>>();

            for (var i = 0; i < 10; i++)
                groups.Add(new List<T>());

            var length = GetMaxLength();

            for (var step = 0; step < length; step++)
            {
                foreach (var item in Items)
                {
                    var i = item.Value;
                    var value = i % (int) Math.Pow(10, step + 1) / (int) Math.Pow(10, step);
                    groups[value].Add(item);
                }

                Items.Clear();

                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }

                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLength()
        {
            var length = 0;
            foreach (var item in Items)
            {
                if (item.Value < 0)
                    throw new ArgumentException("Invalid data", nameof(Items));

                var l = Convert.ToInt32(Math.Log10(item.Value) + 1);

                if (l > length) length = l;
            }

            return length;
        }
    }
}