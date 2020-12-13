using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Sorting
{
    public class SelectionSort
    {
        /// <summary>
        /// Sorting the array using the Selection Sorting Algorithm
        /// </summary>
        /// <param name="inputArray">This is an input array</param>
        /// <returns>Sorted Array int[]</returns>
        public int[] Sort(int[] inputArray)
        {

            for (int i = 0; i < inputArray.Length; i++)
            {
                // Holding the Starting Element to compare with Next set of Numbers
                int temp = inputArray[i];
                int min = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    // If Next Number is less than the min selected number
                    // then we this this number as min
                    if (inputArray[j] < inputArray[min])
                    {
                        min = j;
                        continue;
                    }
                }

                // Once we find the minimum number then we set the sequenced index
                inputArray[i] = inputArray[min];
                inputArray[min] = temp;

            }



            return inputArray;
        }
    }
}
