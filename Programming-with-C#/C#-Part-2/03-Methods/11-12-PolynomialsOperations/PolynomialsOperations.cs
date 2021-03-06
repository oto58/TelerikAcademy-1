﻿namespace Polynomials
{
    using System;
    using System.Text;

    /// <summary>
    /// Problem 11. Adding polynomials
    /// Write a method that adds two polynomials.
    /// Represent them as arrays of their coefficients.
    /// 
    /// Problem 12. Subtracting polynomials
    /// Extend the previous program to support also subtraction and multiplication of polynomials.
    /// </summary>
    public class PolynomialsOperations
    {
        public static void Main()
        {
            Polynomial first = new Polynomial(new int[] { 2, 3, 1 });
            Polynomial second = new Polynomial(new int[] { 4, 1 });

            Polynomial added = first + second;
            Polynomial subtracted = first - second;
            Polynomial multiplied = first * second;

            DisplayExample(first, second, added, subtracted, multiplied);
        }

        private static int[] ConvertStringOfIntsToArray(string text)
        {
            return Array.ConvertAll(text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        }

        private static void DisplayExample(Polynomial first, Polynomial second, Polynomial added, Polynomial subtracted, Polynomial multiplied)
        {
            StringBuilder print = new StringBuilder();
            string border = new string('-', 60);

            print.AppendLine("Problem 11. Adding polynomials \nWrite a method that adds two polynomials. \nRepresent them as arrays of their coefficients.")
                .AppendLine("Problem 12. Subtracting polynomials \nExtend the previous program to support also subtraction and multiplication of polynomials.");

            // print
            print.AppendLine("Example:")
                .AppendLine(border)
                .AppendLine(string.Format("{0,20} | {1,20}", "first", "second"))
                .AppendLine(string.Format("{0,20} | {1,20}", first.ToString(), second.ToString()))
                .AppendLine(border)
                .AppendLine(string.Format("{0,20} | {1,20} | {2,20}", "added", "subtracted", "multiplied"))
                .AppendLine(string.Format("{0,20} | {1,20} | {2,20}", added.ToString(), subtracted.ToString(), multiplied.ToString()))
                .AppendLine(border)
                .AppendLine(string.Format("{0,20} | {1,20} | {2,20}", string.Join(" ", added.Coefficients), string.Join(" ", subtracted.Coefficients), string.Join(" ", multiplied.Coefficients)))
                .AppendLine(border);

            Console.WriteLine(print.ToString());

            // test with your input
            Console.Write("Try it yourself! \nEnter first polynomial coefficients as integer numbers separated by space: ");
            first = new Polynomial(ConvertStringOfIntsToArray(Console.ReadLine()));

            Console.Write("Enter second polynomial coefficients as integer numbers separated by space: ");
            second = new Polynomial(ConvertStringOfIntsToArray(Console.ReadLine()));

            added = first + second;
            subtracted = first - second;
            multiplied = first * second;

            // print
            print.Clear()
                .AppendLine(border)
                .AppendLine(string.Format("{0,20} | {1,20}", "first", "second"))
                .AppendLine(string.Format("{0,20} | {1,20}", first.ToString(), second.ToString()))
                .AppendLine(border)
                .AppendLine(string.Format("{0,20} | {1,20} | {2,20}", "added", "subtracted", "multiplied"))
                .AppendLine(string.Format("{0,20} | {1,20} | {2,20}", added.ToString(), subtracted.ToString(), multiplied.ToString()))
                .AppendLine(border)
                .AppendLine(string.Format("{0,20} | {1,20} | {2,20}", string.Join(" ", added.Coefficients), string.Join(" ", subtracted.Coefficients), string.Join(" ", multiplied.Coefficients)))
                .AppendLine(border);

            Console.WriteLine(print.ToString());
        }
    }
}
