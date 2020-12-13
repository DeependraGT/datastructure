using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Sorting
{
    public class MergeSort
    {
        public int[] Sort(int[] arr)
        {
            return DivideNConquer(arr);
        }


        private int[] DivideNConquer(int[] arr)
        {
            if (arr.Length == 1)
                return arr;

            int middle = arr.Length / 2;

            int[] leftArray = new int[middle];
            int[] rightArray = new int[arr.Length - middle];
            System.Array.Copy(arr, 0, leftArray, 0, middle);
            System.Array.Copy(arr, middle, rightArray, 0 , arr.Length - middle);

            return Merge(
                DivideNConquer(leftArray),
                DivideNConquer(rightArray));
        }


        public int[] Merge(int[] left, int[] right)
        {

            // Defining the array
            int[] mergedArray = new int[left.Length + right.Length];
            int resultIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    mergedArray[resultIndex] = left[leftIndex];
                    leftIndex += 1;
                }
                else
                {
                    mergedArray[resultIndex] = right[rightIndex];
                    rightIndex += 1;
                }
                resultIndex += 1;
            }

            // Copy the remaining elements of
            // L[], if there are any
            while (leftIndex < left.Length)
            {
                mergedArray[resultIndex] = left[leftIndex];
                leftIndex += 1;
                resultIndex += 1;
            }

            // Copy the remaining elements of
            // R[], if there are any
            while (rightIndex < right.Length)
            {
                mergedArray[resultIndex] = right[rightIndex];
                rightIndex += 1;
                resultIndex += 1;
            }

            return mergedArray;
        }


    }
}
