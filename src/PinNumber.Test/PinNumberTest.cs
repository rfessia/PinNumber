namespace PinNumber.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    /// <summary>
    /// General test of all steps
    /// </summary>
    [TestClass]
    public class PinNumberTest : BaseTest
    {
        /// <summary>
        /// Test for get the list of valid Pin Numbers
        /// </summary>
        [TestMethod]
        public void GetAllPinNumber()
        {
            const int minValue = 1000;
            const int maxValue = 9999;
            const int countNumbers = 1000;
            const int countDigit = 4;
            var pinNumbers = pinNumberGenerator.GetPinNumber(minValue, maxValue, countNumbers);

            Assert.AreEqual(countNumbers, pinNumbers.Count());
            Assert.AreEqual(countNumbers, pinNumbers.Distinct().Count());

            foreach (var pinNumber in pinNumbers)
            {
                var sortedNumber = string.Join(string.Empty, pinNumber.ToString().OrderBy(x => x));
                Assert.AreNotEqual(pinNumber, sortedNumber);

                var distinctLength = pinNumber.ToString().Distinct().Count();
                Assert.AreEqual(countDigit, distinctLength);
            }
        }
    }
}