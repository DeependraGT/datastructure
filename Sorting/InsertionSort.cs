using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Sorting
{
    /// <summary>
    /// Time Complexity - O(n*2)
    /// Space Complexity - O(1)
    /// Insertion sort takes maximum time to sort if elements are sorted in reverse order. 
    /// And it takes minimum time (Order of n) when elements are already sorted.
    /// </summary>
    public class InsertionSort
    {

        public int[] Sort(int[] arr, int n)
        {
            int i, key, j;
            for (i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                /* Move elements of arr[0..i-1], that are  
                greater than key, to one position ahead  
                of their current position */
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
