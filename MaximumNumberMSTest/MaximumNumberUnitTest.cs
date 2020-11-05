using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsApplicationDemo;

namespace MaximumNumberMSTest
{
    [TestClass]
    public class MaximumNumberUnitTest
    {
        /// <summary>
        /// 6.1
        /// Givens the integer array should return maximum integer.
        /// </summary>
        [TestMethod]
        public void GivenIntegerArray_ShouldReturnMaximumInteger()
        {
            int[] intArray = { 3, 6, 8, 10, 15 };
            int expected = 15;
            MaximumNumberDemo<int> maximumNumberDemo = new MaximumNumberDemo<int>(intArray);
            int actual = maximumNumberDemo.MaxMethod();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 6.2
        /// Givens the float array should return maximum float number.
        /// </summary>
        [TestMethod]
        public void GivenFloatArray_ShouldReturnMaximumFloatNumber()
        {
            float[] floatArray = { 1.56f, 2.87f, 5.89f, 50.46f };
            float expected = 50.46f;
            MaximumNumberDemo<float> maximumNumberDemo = new MaximumNumberDemo<float>(floatArray);
            float actual = maximumNumberDemo.MaxMethod();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 6.3
        /// Givens the string array should return maximum integer.
        /// </summary>
        [TestMethod]
        public void GivenStringArray_ShouldReturnMaximumInteger()
        {
            string[] stringArray = { "Chetan", "Zaid", "Omkar" };
            string expected = "Zaid";
            MaximumNumberDemo<string> maximumNumberDemo = new MaximumNumberDemo<string>(stringArray);
            string actual = maximumNumberDemo.MaxMethod();
            Assert.AreEqual(expected, actual);
        }
    }
}
