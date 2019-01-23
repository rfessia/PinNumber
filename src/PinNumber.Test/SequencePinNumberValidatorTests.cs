namespace PinNumber.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PinNumber.Generator.Validators;
    using PinNumber.Generator.Validators.RequestResponse;

    /// <summary>
    /// Test for sequence Pin Number
    /// </summary>
    [TestClass]
    public class SequencePinNumberValidatorTests
    {
        private ISequencePinNumberValidator sequencePinNumberValidator;

        [TestInitialize]
        public void InitializeTest()
        {
            sequencePinNumberValidator = new SequencePinNumberValidator();
        }

        /// <summary>
        /// Test non-repeated digits
        /// </summary>
        [TestMethod]
        public void NotSequenceNumbers()
        {
            var request = new ValidatorRequest
            {
                PinNumber = 1523
            };

            var valid = sequencePinNumberValidator.Valid(request).IsValid;
            Assert.IsTrue(valid);
        }

        /// <summary>
        /// Test repeated digits
        /// </summary>
        [TestMethod]
        public void SequenceNumbers()
        {
            var request = new ValidatorRequest
            {
                PinNumber = 1535
            };

            var valid = sequencePinNumberValidator.Valid(request).IsValid;
            Assert.IsFalse(valid);
        }
    }
}
