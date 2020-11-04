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
    }
}
