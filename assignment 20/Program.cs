using assignment_20.Generics;
using System.Security.Cryptography;
using System;
using System.Text;

namespace assignment_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //1.The Bubble Sort algorithm has a time complexity of O(n ^ 2) in its worst and average cases,
            //which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm And
            //implement the code of this optimized bubble sort algorithm.


            //int[] arr = { 30, 5, 12, 100, 50, 2, 15, 1 };

            //Console.WriteLine("Array before Sort:");
            //foreach (int i in arr)
            //{
            //    Console.Write($"{i}  ");
            //}

            //Console.WriteLine("\nAfter Sort Array:");
            //BubbleSort.OptimizeBubbleSort(arr);
            //Console.WriteLine($"{arr} ");
            #endregion

            #region question 2
            //2.create a generic Range < T > class that represents a range of values from a minimum value to a
            //maximum value.The range should support basic operations such as checking if a value is within the
            //range and determining the length of the range.
            //Requirements:
            //1.	Create a generic class named Range<T> where T represents the type of values.
            //2.	Implement a constructor that takes the minimum and maximum values to define the range.
            //3.	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            //4.	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            //5.	Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

            Range<int> intRange = new Range<int>(5,15);
            Console.WriteLine(intRange);  // Output: Range: [5 - 15]
            Console.WriteLine("Length: " + intRange.length());  // Output: Length: 10
            Console.WriteLine("Is 10 in range: " + intRange.IsRange(10));  // Output: True
            Console.WriteLine("Is 20 in range: " + intRange.IsRange(20));  // Output: False

            // Double range example
            Range<double> doubleRange = new Range<double>(1.5, 6.5);
            Console.WriteLine(doubleRange);  // Output: Range: [1.5 - 5.8]
            Console.WriteLine("Length: " + doubleRange.length());  // Output: Length: 4.3
            Console.WriteLine("Is 3.2 in range: " + doubleRange.IsRange(3.2));  // Output: True
            Console.WriteLine("Is 6.0 in range: " + doubleRange.IsRange(6.0));  // Output: False
        }

        #endregion
    }
}
