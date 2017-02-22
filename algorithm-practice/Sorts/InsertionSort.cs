using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice.Sorts
{
    public class InsertionSort : ISortable
    {
        public InsertionSort()
        {
            
        }

        public T[] Sort<T>(T[] array) where T : IComparable
        {
            for (int curIndex = 0; curIndex < array.Length; curIndex++)
            {
                for (int prevIndex = curIndex - 1; prevIndex >= 0; prevIndex--)
                {
                    var prevVal = array[prevIndex];
                    var curVal = array[prevIndex + 1];

                    var compareResult = CompareHelper.ComparesTo(curVal, prevVal);

                    if (compareResult == Comparison.LessThan)
                    {
                        array[prevIndex + 1] = prevVal;
                        array[prevIndex] = curVal;
                    }
                }
            }

            return array;
        }
    }
}
