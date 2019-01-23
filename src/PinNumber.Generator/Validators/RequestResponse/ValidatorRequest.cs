namespace PinNumber.Generator.Validators.RequestResponse
{
    using System.Collections.Generic;

    /// <summary>
    /// Request of validators
    /// </summary>
    public class ValidatorRequest
    {
        /// <summary>
        /// Pin Number
        /// </summary>
        public int PinNumber { get; set; }

        /// <summary>
        /// List of Pin Numbers
        /// </summary>
        public IEnumerable<int> PinNumberList { get; set; }
    }
}
