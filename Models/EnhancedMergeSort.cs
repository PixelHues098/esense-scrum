using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EnhancedMergeSort
{
    class EnhancedMergeSort
    {
        // function to merge two sorted arrays
        public static void merge(int[] left, int[] right, int[] arr)
        {
            int leftSize = left.Length;
            int rightSize = right.Length;
            int i = 0; // index for left array
            int j = 0; // index for right array
            int k = 0; // index for final sorted array

            // compare elements from both arrays and add the smaller one to the final array
            while (i < leftSize && j < rightSize)
            {
                if (left[i] <= right[j])
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

            // add remaining elements from left array if any
            while (i < leftSize)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            // add remaining elements from right array if any
            while (j < rightSize)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        // function to perform enhanced merge sort
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // base case - if the array has less than or equal to 20 elements, sort using insertion sort
            if (n <= 20)
            {
                for (int i = 1; i < n; i++)
                {
                    int key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = key;
                }
                return;
            }

            // divide the array into left and right halves
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < n; i++)
            {
                right[i - mid] = arr[i];
            }

            // recursively sort the left and right halves
            Sort(left);
            Sort(right);

            // merge the sorted left and right halves
            merge(left, right, arr);
        }
    }
}