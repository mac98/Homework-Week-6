/// Chapter No. 13		Exercise No. 2
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  October 3, 2021
///
/// Problem Statement: Reverse an array after generating an initial array.
/// 
/// Overall Plan:
/// 1)  Create a method to generate arrays called GenerateNumbers(). It will
///     have no parameters.
/// 2)  In GenerateNumbers(), create an empty array with a length of 10.
/// 3)  Create a for loop that goes until it reaches the length of the
///     array.
/// 4)  Inside the loop, assign a random number to the array, between 0
///     and 100, using the loop's index.
/// 5)  Outside the loop, return the now filled array.
/// 6)  In Main, create a new array and set it equal to a GenerateNumbers()
///     call.
/// 7)  Create a method called Reverse(). It will take an array as a
///     parameter, called original.
/// 8)  Create an empty array called rev_array that is a length of original.
/// 9)  Create a for loop with an index of i, that ends when i matches the
///     length of original.
/// 10) Inside the loop, take the value stored at slot of original's length
///     minus the index and then minus one, and store it in rev_array.
/// 11) Outside the loop, return rev_array.
/// 12) In Main, create a new array and set it equal to a call to Reverse(),
///     passing in step 6's array to Reverse().
/// 13) Create a method called PrintArray(). It will take an array as a
///     parameter, called to_print.
/// 14) Create a for loop based on the length of to_print.
/// 15) Print each value of to_print.
/// 16) Call PrintArray twice, once with the original array and once with the
///     reversed array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] norm_array = GenerateNumbers();
            int[] rev_array = Reverse(norm_array);
            PrintArray(norm_array);
            PrintArray(rev_array);
            Console.Read();
        }

        static int[] GenerateNumbers()
        {
            int[] temp = new int[10];
            Random rand = new Random();
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = rand.Next(1, 100);
            }
            return temp;
        }

        static int[] Reverse(int[] original)
        {
            int[] temp = new int[original.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = original[original.Length - i - 1];
            }
            return temp;
        }

        static void PrintArray(int[] to_print)
        {
            Console.Write("Array Info: ");
            for (int i = 0; i < to_print.Length; i++)
            {
                Console.Write(to_print[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
