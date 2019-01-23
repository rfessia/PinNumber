namespace PinNumber.Generator.Validators
{
    using System.Linq;
    using PinNumber.Generator.Validators.RequestResponse;

    /// <summary>
    /// Implementation of the Pin Number sequence validator
    /// </summary>
    public class SequencePinNumberValidator : ISequencePinNumberValidator
    {
        /// <summary>
        /// Validate that the Pin Number does not have repeated digits
        /// </summary>
        /// <param name="request">Request of validator</param>
        /// <returns>Indicates whether it is valid or not</returns>
        public ValidatorResponse Valid(ValidatorRequest request)
        {
            var response = new ValidatorResponse() { IsValid = true };
            var pinNumberOriginal = request.PinNumber.ToString();
            var pinNumberSort = string.Concat(pinNumberOriginal.Distinct());

            response.IsValid = pinNumberOriginal == pinNumberSort;

            return response;
        }
    }
}
