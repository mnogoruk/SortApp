using System;
using System.Collections.Generic;

namespace SortApp
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            List<int> a = new  List<int> (new int[6] { 1, 7, 3, 4, 5, 5 });
            Console.WriteLine("Оригинальный набор:");
            PrintList(a);

            ShakerSort<int> sorting = new ShakerSort<int>(comparison: (x, y) => y.CompareTo(x));
            List<int> b = sorting.Sort(a);
            Console.WriteLine("\nСортировка перемешиванием:");
            PrintList(b);

            MergeSort<int> sorting1 = new MergeSort<int>(comparison: (x, y) => y.CompareTo(x));
            List<int> c = sorting1.Sort(a);
            Console.WriteLine("\nСортировка слиянием:");
            PrintList(c);

            BinarySearch<int> searching = new BinarySearch<int>(comparison: (x, y) => y.CompareTo(x));
            Console.WriteLine("\nИндекс элемента со значением 5:");
            Console.WriteLine(searching.Search(c, 5));

        }
        public static List<Int32> Generate(int count)
        {
            List<Int32> a = new List<Int32>(new int[count]);

            while (count > 1)
            {
                count--;
                int k = random.Next() % 20 -1;
                a[count] = k;
            }
            return a;
        }
        public static void PrintList<T>(List<T> list)
        {
            Console.Write("[ ");
            foreach (T i in list)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("]\n");
        }
    }
}
