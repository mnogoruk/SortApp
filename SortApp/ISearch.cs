using System;
using System.Collections.Generic;
using System.Text;

namespace SortApp
{
    interface ISearching<T>
    {
        public int Search(List<T> inputList, T applicant);
    }
}
