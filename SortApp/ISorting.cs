using System;
using System.Collections.Generic;
using System.Text;

namespace SortApp
{
    interface ISorting<T>

    {
        public List<T> Sort(List<T> inputList);
    }
}
