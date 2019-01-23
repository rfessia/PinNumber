namespace PinNumber.Test.Infrastructure
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Initializer for general configurations
    /// </summary>
    [TestClass]
    public static class AssemblyTestSetup
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            Global.Setup();
        }
    }
}
