using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithm_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algorithm_practice;

namespace algorithm_practice.Tests
{
    [TestClass()]
    public class SelectionSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var selsort = new SelectionSort();
            var input = new int[] { 5, 2, 7, 1, 4, 3 };
            var expected = new int[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = selsort.Sort<int>(input);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}