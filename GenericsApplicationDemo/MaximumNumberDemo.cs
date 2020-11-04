using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApplicationDemo
{
    public class MaximumNumberDemo
    {
        /// <summary>
        /// Maximums the number.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <param name="thirdNumber">The third number.</param>
        /// <returns></returns>
        public static int MaximumNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            return firstNumber;
        }

        /// <summary>
        /// Maximums the float number.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <param name="ThirdNumber">The third number.</param>
        /// <returns></returns>
        public static float MaximumFloatNumber(float firstNumber, float secondNumber, float thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            return firstNumber;
        }

        /// <summary>
        /// Maximums the string.
        /// </summary>
        /// <param name="firstValue">The input1.</param>
        /// <param name="secondValue">The input2.</param>
        /// <param name="thirdValue">The input3.</param>
        /// <returns></returns>
        public static string MaximumString(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(firstValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
    }
}
