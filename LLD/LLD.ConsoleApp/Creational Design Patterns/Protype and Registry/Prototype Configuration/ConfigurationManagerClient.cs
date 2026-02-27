using System;

namespace LLD.ConsoleApp.Prototype.ConfigurationManager
{
    public class ConfigurationManagerClient
    {
        public void Run()
        {
            Console.WriteLine("ConfigurationManager Client Started");

            Configuration basicConfig = new Configuration(
                "Light",
                true,
                "English",
                false,
                12,
                "Arial",
                ConfigurationType.BASIC
            );

            // Test using existing methods (no new methods added)

            Console.WriteLine("Theme: " + basicConfig.GetThemeColor());
            Console.WriteLine("AutoSave: " + basicConfig.GetAutoSave());
            Console.WriteLine("Language: " + basicConfig.GetLanguage());
            Console.WriteLine("DarkMode: " + basicConfig.GetDarkMode());
            Console.WriteLine("FontSize: " + basicConfig.GetFontSize());
            Console.WriteLine("FontFamily: " + basicConfig.GetFontFamily());
            Console.WriteLine("Type: " + basicConfig.GetType());

            // Registry structure test (no implementation)
            ConfigurationPrototypeRegistry registry = new ConfigurationPrototypeRegistry();

            // TODO: AddPrototype logic not implemented
            registry.AddPrototype(basicConfig);

            // TODO: GetPrototype logic not implemented
            Configuration cloned = registry.GetPrototype(ConfigurationType.BASIC);

            if (!cloned.Equals(basicConfig))
            {
                Console.WriteLine("Cloned Theme: " + cloned.GetThemeColor());
            }
            // TODO: Prototype behavior not implemented
        }
    }
}