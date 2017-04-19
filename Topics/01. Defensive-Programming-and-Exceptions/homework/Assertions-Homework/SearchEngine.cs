using System;
using System.Diagnostics;

namespace AssertionsHomework
{
    public class SearchEngine
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            bool isArrayNull = arr == null;
            bool isValueNull = value == null;

            // Debug Guard Clause
            Debug.Assert(!isArrayNull, "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as array to search throgh!");
            Debug.Assert(!isValueNull, "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as value to search for!");

            // Release Guard Clause
            if (isArrayNull)
            {
                throw new ArgumentNullException("AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as array to search throgh!");
            }

            if (isValueNull)
            {
                throw new ArgumentNullException("AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as value to search for!");
            }

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            bool isArrayNull = arr == null;
            bool isValueNull = value == null;
            bool isStartIndexInRange = 0 <= startIndex || startIndex <= endIndex;
            bool isEndIndexInRange = startIndex <= endIndex || endIndex < arr.Length;

            // Debug Guard Clause
            Debug.Assert(!isArrayNull, "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as array to search throgh!");
            Debug.Assert(!isValueNull, "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as value to search for!");
            Debug.Assert(isStartIndexInRange, "AssertionsHomework.SearchEngine.BinarySearch cannot work with invalid argument as start index!");
            Debug.Assert(isEndIndexInRange, "AssertionsHomework.SearchEngine.BinarySearch cannot work with invalid argument as end index!");

            // Release Guard Clause
            if (isArrayNull)
            {
                throw new ArgumentNullException("AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as array to search throgh!");
            }

            if (isValueNull)
            {
                throw new ArgumentNullException("AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as value to search for!");
            }

            if (!isStartIndexInRange)
            {
                throw new ArgumentOutOfRangeException("AssertionsHomework.SearchEngine.BinarySearch cannot work with invalid argument as start index!!");
            }

            if (!isEndIndexInRange)
            {
                throw new ArgumentOutOfRangeException("AssertionsHomework.SearchEngine.BinarySearch cannot work with invalid argument as end index!!");
            }
            
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
