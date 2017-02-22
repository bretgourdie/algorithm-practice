using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice
{
    internal enum Comparison
    {
        GreaterThan,
        LessThan,
        EqualTo
    }

    internal class CompareHelper
    {
        public static Comparison ComparesTo<T>(T a, T b) where T : IComparable
        {
            var comparisonResult = a.CompareTo(b);

            if (comparisonResult < 0)
            {
                return Comparison.LessThan;
            }

            else if (comparisonResult == 0)
            {
                return Comparison.EqualTo;
            }

            else if (comparisonResult > 0)
            {
                return Comparison.GreaterThan;
            }

            else
            {
                throw new NotSupportedException();
            }
        }
    }
}
