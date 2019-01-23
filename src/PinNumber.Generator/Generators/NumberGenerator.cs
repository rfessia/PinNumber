namespace PinNumber.Generator.Generators
{
    using System;

    /// <summary>
    /// Random number implementation
    /// </summary>
    public class NumberGenerator : INumberGenerator
    {
        private readonly Random random = new Random();

        /// <summary>
        /// Implementation to get the next random number
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Randon number between minimum value and maximum value</returns>
        public int GetNextRandomPinNumber(int minValue, int maxValue)
        {
            var number = random.Next(minValue, maxValue);
            return number;
        }
    }
}