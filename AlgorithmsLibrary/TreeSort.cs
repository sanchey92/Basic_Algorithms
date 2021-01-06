using System;
using AlgorithmsLibrary.DataStructures;

namespace AlgorithmsLibrary
{
    public class TreeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;
        }
    }
}