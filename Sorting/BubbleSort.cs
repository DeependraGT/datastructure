using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Sorting
{
    public class BubbleSort
    {
        /*
         * This is Bubble sorting algorithm
         * Time Compexity = O(N^2)
         * Space Complexity = O(1)
         */

        public int[] Sort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {

                for (int j = 0; j < inputArray.Length - i; j++)
                {
                    // If Selected Number is greater than Next Number
                    // Swap the position of the number
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        int temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                    }

                }
            }
            return inputArray;
        }

    }
}
