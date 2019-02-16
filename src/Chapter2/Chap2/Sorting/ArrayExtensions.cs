using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

public static class ArrayExtensions
{
    public static bool AreArraySame<T>(this T array, T sorted)
        // not read yet
        where T : IStructuralComparable
    {
        return array.CompareTo(sorted, StructuralComparisons.StructuralComparer) == 0;
    }

    public static bool IsArraySorted<T>(this T[] array)
        where T : IComparable
    {
        int N = array.Length;
        for (int i = 1; i < N; i++)
        {
            if (array[i].CompareTo(array[i - 1]) <= 0)
                return false;
        }
        return true;
    }

    public static void PrintArray<T>(this T[] array)
    {
        foreach (var e in array)
        {
            Console.WriteLine(e.ToString());
        }
    }
}