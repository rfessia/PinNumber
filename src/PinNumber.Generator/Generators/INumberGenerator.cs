namespace PinNumber.Generator.Generators
{
    /// <summary>
    /// Random number interface
    /// </summary>
    public interface INumberGenerator
    {
        int GetNextRandomPinNumber(int minValue, int maxValue);
    }
}