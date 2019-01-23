namespace PinNumber.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PinNumber.Generator.Validators;
    using PinNumber.Generator.Validators.RequestResponse;

    /// <summary>
    /// Test for incremental Pin Number
    /// </summary>
    [TestClass]
    public class IncrementalPinNumberValidatorTests
    {
        private IIncrementalPinNumberValidator incrementalPinNumberValidator;

        [TestInitialize]
        public void InitializeTest()
        {
            incrementalPinNumberValidator = new IncrementalPinNumberValidator();
        }

        /// <summary>
        /// Test Pin Number not incremental
        /// </summary>
        [TestMethod]
        public void NotIncrementalPinNumber()
        {
            var request = new ValidatorRequest
            {
                PinNumber = 1253
            };

            var valid = incrementalPinNumberValidator.Valid(request).IsValid;
            Assert.IsTrue(valid);
        }

        /// <summary>
        /// Test incremental Pin Number
        /// </summary>
        [TestMethod]
        public void IncrementalPinNumber()
        {
            var request = new ValidatorRequest
            {
                PinNumber = 1235
            };

            var valid = incrementalPinNumberValidator.Valid(request).IsValid;
            Assert.IsFalse(valid);
        }
    }
}
