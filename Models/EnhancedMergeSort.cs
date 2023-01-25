using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EnhancedMergeSort
{

    public static class EnhancedMergeSort
    {
        public static void mergePair(KeyValuePair<int, int>[] left, KeyValuePair<int, int>[] right, KeyValuePair<int, int>[] arr)
        {
            int leftSize = left.Length;
            int rightSize = right.Length;
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < leftSize && j < rightSize)
            {
                if (left[i].Value <= right[j].Value)
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftSize)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < rightSize)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        public static void sortPair(KeyValuePair<int, int>[] arr)
        {
            int n = arr.Length;

            if (n <= 20)
            {
                for (int i = 1; i < n; i++)
                {
                    KeyValuePair<int, int> key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j].Value > key.Value)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = key;
                }
                return;
            }

            int mid = n / 2;
            KeyValuePair<int, int>[] left = new KeyValuePair<int, int>[mid];
            KeyValuePair<int, int>[] right = new KeyValuePair<int, int>[n - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < n; i++)
            {
                right[i - mid] = arr[i];
            }

            sortPair(left);
            sortPair(right);

            mergePair(left, right, arr);
        }
    }
}