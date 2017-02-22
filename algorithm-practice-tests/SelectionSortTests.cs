using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithm_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice.Tests
{
    [TestClass()]
    public class SelectionSortTests
    {
        [TestMethod()]
        public void SelectionSort_Basic()
        {
            var selsort = new SelectionSort();
            var input = new int[] { 5, 2, 7, 1, 4, 3 };
            var expected = new int[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = selsort.Sort<int>(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SelectionSort_Chars()
        {
            var selsort = new SelectionSort();
            var input = new char[] { 'b', 'a', 'c', 't', 'e', 'd' };
            var expected = new char[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = selsort.Sort<char>(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SelectionSort_SameValsTest()
        {
            var selsort = new SelectionSort();
            var input = new int[] { 5, 2, 4, 3, 3, 2, 1 };
            var expected = new int[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Sort(expected);

            var result = selsort.Sort<int>(input);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}