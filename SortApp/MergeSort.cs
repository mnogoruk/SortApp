using System;
using System.Collections.Generic;
using System.Text;

namespace SortApp
{
    class MergeSort<T> : ISorting<T>
    {
        private Comparison<T> comparison;

        public MergeSort(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }
        public List<T> Sort(List<T> inputList)
        {
            List<T> output = new List<T>(inputList);
            List<T> buffer = new List<T>(inputList);
            Merge(output, buffer, 0, inputList.Count - 1);
            return output;
        }

        private void Merge(List<T> inputList, List<T> buffer, int from, int to)
        {
            if (from < to)
            {
                int half = (from + to) / 2;
                Merge(inputList, buffer, from, half);
                Merge(inputList, buffer, half + 1, to);

                int k = from;
                for (int i = from, j = half + 1; i <= half || j <= to;)
                {
                    if (j > to || (i <= half && comparison(inputList[i], inputList[j]) > 0))
                    {
                        buffer[k] = inputList[i];
                        ++i;
                    }
                    else
                    {
                        buffer[k] = inputList[j];
                        ++j;
                    }
                    ++k;
                }
                for (int i = from; i <= to; ++i)
                {
                    inputList[i] = buffer[i];
                }
            }

        }

    }
}
