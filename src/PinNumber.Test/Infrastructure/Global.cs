namespace PinNumber.Test.Infrastructure
{
    using Castle.Windsor;
    using Castle.Windsor.Installer;

    /// <summary>
    /// Settings for Castle Windsor
    /// </summary>
    public static class Global
    {
        public static IWindsorContainer Container { get; private set; }

        public static void Setup()
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            Container = container;
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
