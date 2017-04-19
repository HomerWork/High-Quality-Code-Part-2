using System;
using System.Diagnostics;

namespace AssertionsHomework
{
    public class Sorter
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            bool isArrayNull = arr == null;

            // Debug Guard Clause
            Debug.Assert(!isArrayNull, "AssertionsHomework.Sorter.SelectionSort cannot work with null argument as array to sort!");

            // Release Guard Clause
            if (isArrayNull)
            {
                throw new ArgumentNullException("AssertionsHomework.Sorter.SelectionSort cannot work with null argument as array to sort!");
            }

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            bool isArrayNull = arr == null;
            bool isStartIndexInRange = 0 <= startIndex || startIndex <= endIndex;
            bool isEndIndexInRange = startIndex <= endIndex || endIndex < arr.Length;

            // Debug Guard Clause
            Debug.Assert(!isArrayNull, "AssertionsHomework.Sorter.FindMinElementIndex cannot work with null argument as array to sort!");
            Debug.Assert(isStartIndexInRange, "AssertionsHomework.Sorter.FindMinElementIndex cannot work with invalid argument as start index!");
            Debug.Assert(isEndIndexInRange, "AssertionsHomework.Sorter.FindMinElementIndex cannot work with invalid argument as end index!");

            // Release Guard Clause
            if (isArrayNull)
            {
                throw new ArgumentNullException("AssertionsHomework.Sorter.FindMinElementIndex cannot work with null argument as array to sort!");
            }

            if (!isStartIndexInRange)
            {
                throw new ArgumentOutOfRangeException("AssertionsHomework.Sorter.FindMinElementIndex cannot work with invalid argument as start index!");
            }

            if (!isEndIndexInRange)
            {
                throw new ArgumentOutOfRangeException("AssertionsHomework.Sorter.FindMinElementIndex cannot work with invalid argument as end index!");
            }

            int minElementIndex = startIndex;

            bool isFirstElementNull = arr[startIndex] == null;

            // Debug Guard Clause
            Debug.Assert(!isFirstElementNull, string.Format("AssertionsHomework.Sorter.FindMinElementIndex cannot work with array containing null element at index: {0}!", startIndex));

            // Release Guard Clause
            if (isFirstElementNull)
            {
                throw new ArgumentNullException(string.Format("AssertionsHomework.Sorter.FindMinElementIndex cannot work with array containing null element at index: {0}!", startIndex));
            }

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                bool isCurrentElementNull = arr[i] == null;

                // Debug Guard Clause
                Debug.Assert(!isCurrentElementNull, string.Format("AssertionsHomework.Sorter.FindMinElementIndex cannot work with array containing null element at index: {0}!", i));

                // Release Guard Clause
                if (isCurrentElementNull)
                {
                    throw new ArgumentNullException(string.Format("AssertionsHomework.Sorter.FindMinElementIndex cannot work with array containing null element at index: {0}!", i));
                }

                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T firstElement, ref T secondElement)
        {
            bool isFirstElementNull = firstElement == null;
            bool isSecondElementNull = secondElement == null;

            // Debug Guard Clause
            Debug.Assert(!isFirstElementNull, "AssertionsHomework.Sorter.Swap cannot work with null argument as first element to swap!");
            Debug.Assert(!isSecondElementNull, "AssertionsHomework.Sorter.Swap cannot work with null argument as second element to swap!");

            // Release Guard Clause
            if (isFirstElementNull || isSecondElementNull)
            {
                throw new ArgumentNullException("AssertionsHomework.Sorter.Swap cannot work with null argument as element to swap!");
            }

            T firstElementReference = firstElement;
            firstElement = secondElement;
            secondElement = firstElementReference;
        }
    }
}
