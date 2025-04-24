
// TUES, April 22 2025

using System;
class Program
{
    static void Main()
    {

int[,] nums = { {2, 3, 4} , {1 ,4, 6} };

        for (int row = 0; row < nums.GetLength(0); row++) // loop through rows
        {
            Console.Write("| ");
            for (int col = 0; col < nums.GetLength(1); col++) // loop through columns
            {
                Console.Write(nums[row, col] + " | ");
            }
            Console.WriteLine(); // move to the next line after one row is printed
        }
    }
}