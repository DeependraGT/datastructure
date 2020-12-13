using System;
using DataStructure.Array;
using DataStructure.Recursion;
using DataStructure.Sorting;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Merge Sort

            MergeSort mergeSort = new MergeSort();
            int[] result = mergeSort.Sort(new int[] { 2, 8, 4, 6, 10, 20, 1, 5,0 });
            for (int i = 0; i < result.Length; i++){
                Console.Write(result[i] + " ");
            }


            #endregion


            #region Fibonacci

            //Fibonacci fib = new Fibonacci();
            //fib.FiboViaRecursion(55);
            //fib.FiboViaIterative(55);

            #endregion

            #region Factorial
            //// Calling the factorial function
            //Factorial factorial = new Recursion.Factorial();
            ////Calculating factorial using recursion function
            //Console.WriteLine("Factorial Via Recursion " + factorial.FactorialViaRecursion(6));

            //// Calculating factorial using the iterative function
            //Console.WriteLine("Factorial Via Iterative " + factorial.FactorialViaIterative(6));
            #endregion

            //Array Rotation Object Initialization and calling with input
            //ArrayRotation rotation = new ArrayRotation();
            //int[] inputArray = {1,33,4,5,7,3,9};
            //int[] outputArray = rotation.LeftRotate(inputArray,2,inputArray.Length);
            //rotation.Print(outputArray);

            Console.WriteLine();
            Console.WriteLine("Waiting for press key");
            Console.ReadKey();
        }
    }
}
