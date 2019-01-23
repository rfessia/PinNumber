namespace PinNumber.Generator
{
    using System.Collections.Generic;

    /// <summary>
    /// Pin number generator interface
    /// </summary>
    public interface IPinNumberGenerator
    {
        IEnumerable<int> GetPinNumber(int minValue, int maxValue, int quantity);
    }
}
