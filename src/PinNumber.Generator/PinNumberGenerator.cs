namespace PinNumber.Generator
{
    using System.Collections.Generic;
    using System.Linq;
    using PinNumber.Generator.Generators;
    using PinNumber.Generator.Validators;
    using PinNumber.Generator.Validators.RequestResponse;

    /// <summary>
    /// Pin number generator implementation
    /// </summary>
    public class PinNumberGenerator : IPinNumberGenerator
    {
        private readonly IEnumerable<IValidator> validator;

        private readonly INumberGenerator numberGenerator;

        public PinNumberGenerator(IEnumerable<IValidator> validator, INumberGenerator numberGenerator)
        {
            this.validator = validator;
            this.numberGenerator = numberGenerator;
        }

        /// <summary>
        /// Get a list of Pin Numbers
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <param name="quantity">Total amount of the list</param>
        /// <returns>List of Pin Numbers</returns>
        public IEnumerable<int> GetPinNumber(int minValue, int maxValue, int quantity)
        {
            var numbersList = new List<int>();
            while (quantity > numbersList.Count())
            {
                var number = numberGenerator.GetNextRandomPinNumber(minValue, maxValue);
                var valid = IsValidPinNumber(numbersList, number);
                if (valid)
                {
                    numbersList.Add(number);
                }
            }

            return numbersList;
        }

        /// <summary>
        /// Validations of Pin Numbers
        /// </summary>
        /// <param name="pinNumberList">List of all current Pin Numbers</param>
        /// <param name="pinNumber">Current Pin Number</param>
        /// <returns>Indicates whether the validations succeeded or failed</returns>
        private bool IsValidPinNumber(IEnumerable<int> pinNumberList, int pinNumber)
        {
            var valid = true;
            var request = new ValidatorRequest { PinNumberList = pinNumberList, PinNumber = pinNumber };
            foreach (var validService in validator)
            {
                valid = validService.Valid(request).IsValid;
                if (!valid)
                {
                    break;
                }
            }

            return valid;
        }
    }
}
