using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice.Sorts
{
    public class SelectionSort : ISortable
    {
        public SelectionSort() { }

        public T[] Sort<T>(T[] array) where T : IComparable
        {
            for(int curIndex = 0; curIndex < array.Length; curIndex++)
            {
                var minIndex = curIndex;

                for(int unsortedIndex = curIndex + 1; unsortedIndex < array.Length; unsortedIndex++)
                {
                    var compareResult = array[minIndex].CompareTo(array[unsortedIndex]);

                    if(compareResult > 0)
                    {
                        minIndex = unsortedIndex;
                    }
                }

                var temp = array[minIndex];
                array[minIndex] = array[curIndex];
                array[curIndex] = temp;
            }

            return array;
        }
    }
}
