/// Chapter No. 13		Exercise No. 1
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  October 3, 2021
///
/// Problem Statement: Write code to copy the contents of one array to
///                    another.
/// 
/// Overall Plan:
/// 1) Create an array with 10 values.
/// 2) Create a second array and set its length to be the same as the
///    first array.
/// 3) Create a for-loop that starts at 0 and goes until it reaches the
///    length of the first array.
/// 4) Inside the loop, store the contents of the first array in the
///    second using the loop's index.
/// 5) Also in the loop, print the values of the first array.
/// 6) Create a second for loop to go through the second loop and prints
///    each item in the second array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program copies an array.");

            int[] array1 = { 15, 18, 12, 11, 9, 14, 18, 19, 22, 10 };
            int[] array2 = new int[array1.Length];

            Console.WriteLine("Array 1");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + ", ");
                array2[i] = array1[i];
            }

            Console.WriteLine();
            Console.WriteLine("Array 2");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + ", ");
            }

            Console.Read();
        }
    }
}
