using System;
using System.Collections.Generic;
using System.Linq; 

/* Write a program that takes a list of integers from the user and performs the following operations using LINQ:
a) Find all numbers greater than 50
b) Sort the numbers in ascending order
c) Find the square of each number
*/

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Ask user to enter numbers separated by spaces
            Console.WriteLine("Enter a list of integers separated by spaces:");
            string input = Console.ReadLine();

            // Step 2: Convert the input string to a list of integers
            List<int> numbers = input.Split(' ')
                                     .Select(int.Parse)  // Convert each string to int
                                     .ToList();

            // Step 3: Find all numbers greater than 50 using LINQ
            var greaterThan50 = numbers.Where(n => n > 50).ToList();
            Console.WriteLine("\nNumbers greater than 50:");
            foreach (var num in greaterThan50)
            {
                Console.WriteLine(num);
            }

            // Step 4: Sort numbers in ascending order using LINQ
            var sortedNumbers = numbers.OrderBy(n => n).ToList();
            Console.WriteLine("\nNumbers in ascending order:");
            foreach (var num in sortedNumbers)
            {
                Console.WriteLine(num);
            }

            // Step 5: Find the square of each number using LINQ
            var squares = numbers.Select(n => n * n).ToList();
            Console.WriteLine("\nSquare of each number:");
            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }

            Console.WriteLine("\nProgram completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
