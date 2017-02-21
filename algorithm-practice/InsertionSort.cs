using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice
{
    public class InsertionSort<T> : ISortable<T> where T : IComparable
    {
        public InsertionSort()
        {
            
        }

        public T[] Sort(T[] array)
        {
            for (int curIndex = 0; curIndex < array.Length; curIndex++)
            {
                var curVal = array[curIndex];

                bool inserted = false;
                for (int prevIndex = curIndex - 1; prevIndex >= 0 && !inserted; prevIndex--)
                {
                    var prevVal = array[prevIndex];

                    if (prevVal.CompareTo(curVal) > 0)
                    {
                        array[prevIndex + 1] = prevVal;
                    }

                    else if (prevVal.CompareTo(curVal) < 0)
                    {
                        array[prevIndex + 1] = curVal;
                        inserted = true;
                    }
                }
            }

            return array;
        }
    }
}
