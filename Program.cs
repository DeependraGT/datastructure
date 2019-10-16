using System;
using DataStructure.Array;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array Rotation Object Initialization and calling with input
            ArrayRotation rotation = new ArrayRotation();
            int[] inputArray = {1,33,4,5,7,3,9};
            int[] outputArray = rotation.LeftRotate(inputArray,2,inputArray.Length);
            rotation.Print(outputArray);

            Console.WriteLine();
            Console.WriteLine("Waiting for press key");
            Console.ReadKey();
        }
    }
}
