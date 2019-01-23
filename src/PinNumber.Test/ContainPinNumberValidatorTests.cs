namespace PinNumber.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PinNumber.Generator.Validators;
    using PinNumber.Generator.Validators.RequestResponse;
    using System.Collections.Generic;

    /// <summary>
    /// Test for contained Pin Number
    /// </summary>
    [TestClass]
    public class ContainPinNumberValidatorTests
    {
        private IContainPinNumberValidator containPinNumberValidator;

        [TestInitialize]
        public void InitializeTest()
        {
            containPinNumberValidator = new ContainPinNumberValidator();
        }

        /// <summary>
        /// Test Pin Number not contained
        /// </summary>
        [TestMethod]
        public void NotContainPinNumber()
        {
            var pinNumberList = new List<int> { 1456, 2547, 1256, 5479 };
            var request = new ValidatorRequest
            {
                PinNumber = 1235,
                PinNumberList = pinNumberList
            };

            var valid = containPinNumberValidator.Valid(request).IsValid;
            Assert.IsTrue(valid);
        }

        /// <summary>
        /// Test Pin Number contained
        /// </summary>
        [TestMethod]
        public void ContainPinNumber()
        {
            var pinNumberList = new List<int> { 1456, 1235, 1256, 5479 };
            var request = new ValidatorRequest
            {
                PinNumber = 1235,
                PinNumberList = pinNumberList
            };

            var valid = containPinNumberValidator.Valid(request).IsValid;
            Assert.IsFalse(valid);
        }
    }
}
