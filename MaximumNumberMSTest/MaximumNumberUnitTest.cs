using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsApplicationDemo;

namespace MaximumNumberMSTest
{
    [TestClass]
    public class MaximumNumberUnitTest
    {
        /// <summary>
        /// T.C -> 4.1
        /// Givens the integer value to find maximum should return expectd value.
        /// </summary>
        [TestMethod]
       public void GivenIntegerValue_ToFindMaximum_ShouldReturnExpectdValue()
        {
            int actual = new MaximumNumberDemo<int>(2, 4, 8).MaxMethod();
            int expected = 8;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// T.C -> 4.2
        /// Givens the float value to find maximum should return expected value.
        /// </summary>
        [TestMethod]
        public void GivenFloatValue_ToFindMaximum_ShouldReturnExpectedValue()
        {
            float actual = new MaximumNumberDemo<float>(2.5f, 10.58f, 56.78f).MaxMethod();
            float expected = 56.78f;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Givens the string value to find maximum should return expected value.
        /// </summary>
        [TestMethod]
        public void GivenStringValue_ToFindMaximum_ShouldReturnExpectedValue()
        {
            string actual = new MaximumNumberDemo<string>("Chetan" , "Abhishek","Om").MaxMethod();
            string expected = "Om";
            Assert.AreEqual(expected, actual);
        }

    }
}
