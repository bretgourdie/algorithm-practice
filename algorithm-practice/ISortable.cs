using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice
{
    interface ISortable<T>
    {
        public T[] Sort(T[] array);
    }
}
