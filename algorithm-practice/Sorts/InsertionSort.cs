using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice
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

                    var compared = curVal.CompareTo(prevVal);

                    if (compared < 0)
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
