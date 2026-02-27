namespace LLD.ConsoleApp.Prototype.ConfigurationManager;

public class ConfigurationPrototypeRegistry : IConfigurationPrototypeRegistry
{
    
    Dictionary<ConfigurationType, Configuration> _prototypes = new Dictionary<ConfigurationType, Configuration>();
    
    public void AddPrototype(Configuration user)
    {
        this._prototypes[user.GetType()] = user;
    }

    public Configuration GetPrototype(ConfigurationType type)
    {
        if(this._prototypes.ContainsKey(type))
        {
            return this._prototypes[type];
        }

        return null;
    }

    public Configuration Clone(ConfigurationType type)
    {
        if(this._prototypes.ContainsKey(type))
        {
            return this._prototypes[type].CloneObject();
        }

        return null;
    }
}