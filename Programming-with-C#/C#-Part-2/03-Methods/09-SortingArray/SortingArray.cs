﻿namespace SortingArray
{
    using System;
    using System.Text;

    /// <summary>
    /// Problem 9. Sorting array
    /// Write a method that return the maximal element in a portion of array of integers starting at given index.
    /// Using it write another method that sorts an array in ascending / descending order.
    /// </summary>
    public class SortingArray
    {
        private const string IndexOutOfRangeMsg = "Index was out of range. Please select an index between 0 and the total length of the array.";
        private const string StartEndIndexMsg = "The end index must be larger than the start index.";

        public static void Main()
        {
            int[] input = { 1, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int[] sorted = SortArray(input);

            DisplayExample(input, sorted);
        }

        public static int FindPositionOfMaxElementInSubArray(int[] array, int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex > array.Length - 1 || endIndex < 0 || endIndex > array.Length - 1)
            {
                throw new ArgumentOutOfRangeException(IndexOutOfRangeMsg);
            }

            if (endIndex < startIndex)
            {
                throw new ArgumentException(StartEndIndexMsg);
            }

            int maxIndex = 0;
            int max = int.MinValue;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int[] SortArray(int[] array, bool descending = false)
        {
            int[] sorted = (int[])array.Clone();
            int temp;
            int max;

            for (int i = 0; i < array.Length; i++)
            {
                if (descending)
                {
                    max = FindPositionOfMaxElementInSubArray(sorted, i, sorted.Length - 1);
                    temp = sorted[i];
                    sorted[i] = sorted[max];
                    sorted[max] = temp;
                }
                else
                {
                    max = FindPositionOfMaxElementInSubArray(sorted, 0, sorted.Length - 1 - i);
                    temp = sorted[array.Length - i - 1];
                    sorted[array.Length - i - 1] = sorted[max];
                    sorted[max] = temp;
                }
            }

            return sorted;
        }

        private static int[] ConvertStringOfIntsToArray(string text)
        {
            return Array.ConvertAll(text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        }

        private static void DisplayExample(int[] input, int[] sorted)
        {
            StringBuilder print = new StringBuilder();
            string border = new string('-', 60);

            print.AppendLine(" Problem 9. Sorting array \nWrite a method that return the maximal element in a portion of array of integers starting at given index. \nUsing it write another method that sorts an array in ascending / descending order.");

            // print
            print.AppendLine("Example:")
                .AppendLine(border)
                .AppendLine(string.Format("{0,30} | {1,10}", "input", "result"))
                .AppendLine(string.Format("{0,30} | {1,10}", string.Join(" ", input), string.Join(" ", sorted)))
                .AppendLine(border);

            Console.WriteLine(print.ToString());

            // test with your input
            Console.Write("Try it yourself! \nEnter a sequence of integer numbers separated by space: ");

            input = ConvertStringOfIntsToArray(Console.ReadLine());
            sorted = SortArray(input, true);

            // print
            print.Clear()
                .AppendLine(border)
                .AppendLine(string.Format("{0,30} | {1,10}", string.Join(" ", input), string.Join(" ", sorted)))
                .AppendLine(border);

            Console.WriteLine(print.ToString());
        }
    }
}
