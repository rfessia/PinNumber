namespace PinNumber.UI.Infrastructure
{
    using Castle.Facilities.TypedFactory;
    using Castle.Windsor;
    using Castle.Windsor.Installer;
    using PinNumber.Generator;
    using PinNumber.Generator.Generators;
    using PinNumber.Generator.Validators;
    using System.Collections.Generic;

    /// <summary>
    /// Inversion of Control Container configuration handler
    /// </summary>
    public class IoC
    {
        private static volatile IWindsorContainer instance;
        private static object syncRoot = new object();

        /// <summary>
        /// Create and initialize the first access
        /// </summary>
        public static IWindsorContainer Instance
        {
            get
            {
                InitializeInstance();
                return instance;
            }
        }

        /// <summary>
        /// Initializer of the container instance
        /// </summary>
        public static void InitializeInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = SetupContainer();
                    }
                }
            }
        }

        /// <summary>
        /// Resolve all instances
        /// </summary>
        /// <returns></returns>
        public static IPinNumberGenerator GetNumberGenerator()
        {
            var ioc = Instance;
            var incrementalPinNumberValidator = ioc.Resolve<IIncrementalPinNumberValidator>();
            var sequencePinNumberValidator = ioc.Resolve<ISequencePinNumberValidator>();
            var containPinNumberValidator = ioc.Resolve<IContainPinNumberValidator>();
            var numberGenerator = ioc.Resolve<INumberGenerator>();

            var validators = new List<IValidator>
            {
                containPinNumberValidator,
                incrementalPinNumberValidator,
                sequencePinNumberValidator
            };

            return new PinNumberGenerator(validators, numberGenerator);
        }

        /// <summary>
        /// Container configuration
        /// </summary>
        /// <returns></returns>
        private static IWindsorContainer SetupContainer()
        {
            var container = new WindsorContainer()
            .AddFacility<TypedFactoryFacility>()
            .Install(FromAssembly.This());
            //.Install(FromAssembly.Containing<IIncrementalPinNumberValidator>());
            return container;
        }
    }
}
