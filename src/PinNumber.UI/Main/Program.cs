namespace PinNumber.UI.Main
{
    using PinNumber.UI.Infrastructure;

    /// <summary>
    /// Main Class
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var pinNumberGenerator = IoC.GetNumberGenerator();

            const int minValue = 1000;
            const int maxValue = 9999;
            const int countNumbers = 1000;
            var countCurrentPinNumber = 0;
            var pinNumbers = pinNumberGenerator.GetPinNumber(minValue, maxValue, countNumbers);
            foreach (var pinNumber in pinNumbers)
            {
                countCurrentPinNumber++;
                System.Console.Write($"{countCurrentPinNumber.ToString().PadLeft(4)}.{pinNumber}  ");
                if (countCurrentPinNumber % 5 == 0)
                {
                    System.Console.WriteLine();
                }
            }

            System.Console.ReadLine();
        }
    }
}
