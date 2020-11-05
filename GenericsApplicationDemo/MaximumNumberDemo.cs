using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApplicationDemo
{
    public class MaximumNumberDemo<T> where T : IComparable
    {
        public T[] value;

        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumNumberDemo{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public MaximumNumberDemo(T[] value)
        {
            this.value = value;
        }

        /// <summary>
        /// Sorts the specified values.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        /// <summary>
        /// Maximums the value.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T MaxValue(T[] values)
        {
            var sortedValues = Sort(values);
            return sortedValues[values.Length - 1];
        }

        /// <summary>
        /// Maximums the method.
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        /// <summary>
        /// Converts to print.
        /// </summary>
        public void ToPrint()
        {
            var max = MaxMethod();
            Console.WriteLine("Maximum : " + max);
        }
    }
}
