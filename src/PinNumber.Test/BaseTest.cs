namespace PinNumber.Test
{
    using Generator;
    using Generator.Generators;
    using Generator.Validators;
    using Infrastructure;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    /// <summary>
    /// Base calss for test
    /// </summary>
    [TestClass]
    public abstract class BaseTest
    {
        private List<IValidator> validators;
        private IIncrementalPinNumberValidator incrementalPinNumberValidator;
        private IContainPinNumberValidator containPinNumberValidator;
        private ISequencePinNumberValidator sequencePinNumberValidator;
        private INumberGenerator numberGenerator;
        protected IPinNumberGenerator pinNumberGenerator;

        /// <summary>
        /// Resolve all instances
        /// </summary>
        [TestInitialize]
        public void InitializeTest()
        {
            incrementalPinNumberValidator = Global.Resolve<IIncrementalPinNumberValidator>();
            sequencePinNumberValidator = Global.Resolve<ISequencePinNumberValidator>();
            containPinNumberValidator = Global.Resolve<IContainPinNumberValidator>();
            numberGenerator = Global.Resolve<INumberGenerator>();

            validators = new List<IValidator>
            {
                containPinNumberValidator,
                incrementalPinNumberValidator,
                sequencePinNumberValidator
            };

            pinNumberGenerator = new PinNumberGenerator(validators, numberGenerator);
        }
    }
}
