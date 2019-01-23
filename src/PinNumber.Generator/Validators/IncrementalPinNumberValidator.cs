namespace PinNumber.Generator.Validators
{
    using System.Linq;
    using PinNumber.Generator.Validators.RequestResponse;

    /// <summary>
    /// Implementation of the Pin Number incremental validator
    /// </summary>
    public class IncrementalPinNumberValidator : IIncrementalPinNumberValidator
    {
        /// <summary>
        /// Validate that the Pin Number is not incremental
        /// </summary>
        /// <param name="request">Request of validator</param>
        /// <returns>Indicates whether it is valid or not</returns>
        public ValidatorResponse Valid(ValidatorRequest request)
        {
            var response = new ValidatorResponse();
            var pinNumberOriginal = request.PinNumber.ToString();
            var pinNumberSort = string.Concat(pinNumberOriginal.OrderBy(c => c));

            response.IsValid = pinNumberOriginal != pinNumberSort;

            return response;
        }
    }
}
