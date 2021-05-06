using System;
using System.Collections.Generic;

namespace SortApp
{
    class ShakerSort<T> : ISorting<T>
    {
        private Comparison<T> comparison;

        public ShakerSort(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }

        public  List<T> Sort(List<T> inputList)
        {
            List<T> output = new List<T>(inputList);
            int left = 0;
            int right = output.Count - 1;
            while (left <= right)
            {
                for (int i = right; i > left; --i)
                {
                    if (comparison(output[i - 1], output[i]) < 0)
                    {
                        Swap(output, i - 1, i);
                    }
                }
                ++left;
                for (int i = left; i < right; ++i)
                {
                    if (comparison(output[i], output[i + 1]) < 0)
                    {
                        Swap(output, i, i + 1);
                    }
                }
                --right;
            }
            return output;
        }
        public static void Swap(List<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}
