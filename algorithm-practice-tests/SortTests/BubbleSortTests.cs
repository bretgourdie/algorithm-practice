using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithm_practice.Sorts.Tests
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void BubbleSort_BasicTest()
        {
            var bsort = new BubbleSort();

            var input = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            var expected = new int[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = bsort.Sort(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BubbleSort_SameIntsTest()
        {
            var bsort = new BubbleSort();

            var input = new int[] { 7, 2, 4, 3, 1, 4, 5, 2, 4 };
            var expected = new int[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = bsort.Sort(input);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
