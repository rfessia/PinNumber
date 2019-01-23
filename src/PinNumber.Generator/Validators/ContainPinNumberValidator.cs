namespace PinNumber.Generator.Validators
{
    using System.Linq;
    using PinNumber.Generator.Validators.RequestResponse;

    /// <summary>
    /// Implementation of the Pin Number container validator
    /// </summary>
    public class ContainPinNumberValidator : IContainPinNumberValidator
    {
        /// <summary>
        /// Validate that the Pin Number is not contained in a list of Pin Numbers
        /// </summary>
        /// <param name="request">Request of validator</param>
        /// <returns>Indicates whether it is valid or not</returns>
        public ValidatorResponse Valid(ValidatorRequest request)
        {
            var response = new ValidatorResponse();
            response.IsValid = !request.PinNumberList.Contains(request.PinNumber);

            return response;
        }
    }
}
