namespace LLD.ConsoleApp.Prototype.ConfigurationManager
{
    public interface IConfigurationPrototypeRegistry
    {
        void AddPrototype(Configuration user);

        Configuration GetPrototype(ConfigurationType type);

        Configuration Clone(ConfigurationType type);
    }
}