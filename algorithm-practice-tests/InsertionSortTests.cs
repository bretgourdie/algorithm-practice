using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithm_practice.Tests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void InsertionSort_BasicTest()
        {
            var inssort = new InsertionSort();

            var input = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            var expected = new int[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = inssort.Sort<int>(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertionSort_SameIntsTest()
        {
            var innsort = new InsertionSort();

            var input = new int[] { 4, 2, 3, 2, 5, 3 };
            var expected = new int[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = innsort.Sort<int>(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertionSort_CharsTest()
        {
            var insort = new InsertionSort();

            var input = new char[] { 'c', 'b', 'a' };
            var expected = new char[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = insort.Sort<char>(input);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
