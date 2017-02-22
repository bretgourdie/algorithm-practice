using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice.Sorts
{
    public class BubbleSort : ISortable
    {

        public T[] Sort<T>(T[] array) where T : IComparable
        {
            for (int ii = 0; ii < array.Length; ii++)
            {
                for (int jj = 0; jj < array.Length - ii - 1; jj++)
                {
                    var result = CompareHelper.ComparesTo<T>(
                        array[jj],
                        array[jj + 1]);

                    if (result == Comparison.GreaterThan)
                    {
                        var temp = array[jj];
                        array[jj] = array[jj + 1];
                        array[jj + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
