using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsApplicationDemo;

namespace MaximumNumberMSTest
{
    [TestClass]
    public class MaximumNumberUnitTest
    {
        /// <summary>
        /// T.C -> 1.1
        /// Givens the maximum number at first position should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumber_AtFirstPosition_ShouldReturnSameNumber()
        {
            int actual = MaximumNumberDemo.MaximumNumber(100, 20, 50);
            int expected = 100;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// T.C -> 1.2
        /// Givens the maximum number at second position should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumber_AtSecondPosition_ShouldReturnSameNumber()
        {
            int actual = MaximumNumberDemo.MaximumNumber(50, 150, 20);
            int expected = 150;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// T.C -> 1.3
        /// Givens the maximum number at third position should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumber_AtThirdPosition_ShouldReturnSameNumber()
        {
            int actual = MaximumNumberDemo.MaximumNumber(50, 150, 500);
            int expected = 500;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// T.C -> 2.1
        /// Givens the maximum float number at first position should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatNumber_AtFirstPosition_ShouldReturnSameNumber()
        {
            float actual = MaximumNumberDemo.MaximumFloatNumber(50.5f, 20.87f, 10.37f);
            float expected = 50.5f;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// T.C -> 2.2
        /// Givens the maximum float number at second position should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatNumber_AtSecondPosition_ShouldReturnSameNumber()
        {
            float actual = MaximumNumberDemo.MaximumFloatNumber(5.5f, 40.87897f, 10.37f);
            float expected = 40.87897f;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// T.C -> 2.3
        /// Givens the maximum float number at third position should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatNumber_AtThirdPosition_ShouldReturnSameNumber()
        {
            float actual = MaximumNumberDemo.MaximumFloatNumber(50.5f, 20.87f, 986.37f);
            float expected = 986.37f;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// T.C -> 3.1
        /// Givens the maximum string at first position should same string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AtFirstPosition_ShouldSameString()
        {
            string actual = MaximumNumberDemo.MaximumString("Guava", "Apple", "Banana");
            string expecetd = "Guava";
            Assert.AreEqual(expecetd, actual);
        }
        /// <summary>
        /// T.C -> 3.2
        /// Givens the maximum string at second position should same string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AtSecondPosition_ShouldSameString()
        {
            string actual = MaximumNumberDemo.MaximumString("Guava", "Papaya", "Banana");
            string expecetd = "Papaya";
            Assert.AreEqual(expecetd, actual);
        }

        /// <summary>
        /// T.C -> 3.3
        /// Givens the maximum string at third position should same string.
        /// </summary>
        [TestMethod]
        public void GivenMaximumString_AtThirdPosition_ShouldSameString()
        {
            string actual = MaximumNumberDemo.MaximumString("Guava", "Apple", "Orange");
            string expecetd = "Orange";
            Assert.AreEqual(expecetd, actual);
        }
    }
}
