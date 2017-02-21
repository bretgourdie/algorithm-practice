using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithm_practice.Tests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void BasicIntsTest()
        {
            var inssort = new InsertionSort();

            var input = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            var expected = new int[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = inssort.Sort<int>(input);

            Assert.AreEqual(expected, result);
        }
    }
}
