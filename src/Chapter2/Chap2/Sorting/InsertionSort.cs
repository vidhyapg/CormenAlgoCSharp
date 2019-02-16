using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class InsertionSort
    {
        public static void Sort<T>(T[] a)
            where T: IComparable
        {
            // {1,7,8,2,3,9}
            //  1  2 7 8      
            int N = a.Length;
            for(int i = 1; i < N; i++)
            {
                int j = i - 1;
                // save the item, it will get erased below.
                T item = a[i];
                while ((j >= 0) && (a[j].CompareTo(item) > 0))
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = item;
            }
        }
    }
}
