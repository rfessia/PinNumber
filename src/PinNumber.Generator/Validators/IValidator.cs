namespace PinNumber.Generator.Validators
{
    using PinNumber.Generator.Validators.RequestResponse;

    /// <summary>
    /// Base Validator
    /// </summary>
    public interface IValidator
    {
        ValidatorResponse Valid(ValidatorRequest request);
    }
}
