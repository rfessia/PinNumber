namespace PinNumber.Test.Infrastructure
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;
    using Generator.Generators;
    using Generator.Validators;

    /// <summary>
    /// Installer for Castle Windsor
    /// </summary>
    public class ValidatorsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register
               (
                   Classes.FromAssemblyContaining<IValidator>()
                   .BasedOn(typeof(IValidator))
                   .Configure
                   (
                       component => component.LifestyleSingleton()
                   )
                   .WithService.FromInterface()
                    .WithServiceSelf()
               );

            container.Register(Component.For<INumberGenerator>().ImplementedBy<NumberGenerator>());
        }
    }
}