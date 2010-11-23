using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnBlockMeSolver
{
    public static class Extensions
    {
        public static T[] ExceptElement<T>(this T[] arr, int idx)
        {
            T[] newarr = new T[arr.Length - 1];

            if (idx > 0) Array.Copy(arr, newarr, idx);
            if (idx < arr.Length - 1) Array.Copy(arr, idx + 1, newarr, idx, arr.Length - idx - 1);

            return newarr;
        }

        public static T[] ReplaceElement<T>(this T[] arr, int idx, T elem)
        {
            T[] newarr = new T[arr.Length];

            Array.Copy(arr, newarr, arr.Length);
            newarr[idx] = elem;

            return newarr;
        }

        public static IEnumerable<int> ReverseRange(int start, int count)
        {
            int x = start;
            for (int i = 0; i < count; ++i)
            {
                yield return x;
                --x;
            }
            yield break;
        }
    }
}
