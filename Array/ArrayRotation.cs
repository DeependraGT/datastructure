using System;

namespace DataStructure.Array
{
    public class ArrayRotation{

        /// <summary>
        /// Rotate d item to left 
        /// </summary>
        /// <param name="arr">arr as an Input Array</param>
        /// <param name="d">d as a Number which define how many records need to rotate</param>
        /// <param name="n">n as a array lenght</param>
        public int[] LeftRotate(int[] arr, int d, int n){
            for(int i=0;i < d;i++){
               arr = LeftRotateOne(arr,n);
            }
            return arr;
        }

        /// <summary>
        /// Rotate 1 item to left
        /// </summary>
        /// <param name="arr">arr as an Input Array</param>
        /// <param name="n">n as a array lenght</param>
        public int[] LeftRotateOne(int[] arr, int n){
            int i, temp = arr[0];
            for(i=0;i< n-1; i++){
                arr[i] = arr[i+1];
            }
            arr[i] = temp;
            return arr;
        }

        /// <summary>
        /// Printing the Rotated array
        /// </summary>
        /// <param name="arr">arr as a Output array</param>
        public void Print(int[] arr){
            Console.WriteLine("Printing the rotated array");
            for(int i=0; i< arr.Length;i++){
                Console.Write(arr[i] + " ");
            }
        }



    }
}