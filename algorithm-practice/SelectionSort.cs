using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice
{
    public class SelectionSort : ISortable
    {
        public SelectionSort() { }

        public T[] Sort<T>(T[] array) where T : IComparable
        {
            for(int curIndex = 0; curIndex < array.Length; curIndex++)
            {
                var curValue = array[curIndex];

                var minValue = curValue;
                var minIndex = curIndex;

                for(int unsortedIndex = curIndex + 1; unsortedIndex < array.Length; unsortedIndex++)
                {
                    var unsortedValue = array[unsortedIndex];
                    var compareResult = minValue.CompareTo(unsortedValue);

                    if(compareResult > 0)
                    {
                        minValue = unsortedValue;
                        minIndex = unsortedIndex;
                    }
                }

                array[minIndex] = curValue;
                array[curIndex] = minValue;
            }

            return array;
        }
    }
}
