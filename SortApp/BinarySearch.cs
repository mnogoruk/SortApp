using System;
using System.Collections.Generic;
using System.Text;

namespace SortApp
{
    class BinarySearch<T> : ISearching<T>

    {
        private Comparison<T> comparison;

        public BinarySearch(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }
        public int Search(List<T> inputList, T applicant)
        {
            int from = 0;
            int to = inputList.Count - 1;
            int half;
            while (true)
            {
                if (from > to)
                {
                    return -1;
                }

                half = (from + to) / 2;
                if (comparison(applicant, inputList[half]) > 0)
                {
                    to = half - 1;
                } else if (comparison(applicant, inputList[half]) < 0)
                {
                    from = half + 1;
                } else
                {
                    return half;
                }

            }
        }
    }
}
