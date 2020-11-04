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
        public static int MaximumNumber(int firstNumber , int secondNumber , int thirdNumber)
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
    }
}
