namespace LLD.ConsoleApp.Prototype.ConfigurationManager
{
    public class Configuration:IClonableObject<Configuration>
    {
        private string themeColor;
        private bool autoSave;
        private string language;
        private bool darkMode;
        private int fontSize;
        private string fontFamily;
        private ConfigurationType type;

        public Configuration(string themeColor, bool autoSave, string language, bool darkMode, int fontSize, string fontFamily, ConfigurationType type)
        {
            this.themeColor = themeColor;
            this.autoSave = autoSave;
            this.language = language;
            this.darkMode = darkMode;
            this.fontSize = fontSize;
            this.fontFamily = fontFamily;
            this.type = type;
        }

        public string GetThemeColor()
        {
            return themeColor;
        }

        public bool GetAutoSave()
        {
            return autoSave;
        }

        public string GetLanguage()
        {
            return language;
        }

        public bool GetDarkMode()
        {
            return darkMode;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public string GetFontFamily()
        {
            return fontFamily;
        }

        public Configuration CloneObject()
        {
            return new Configuration(this.themeColor, this.autoSave, this.language, this.darkMode, this.fontSize,
                this.fontFamily, this.type);
        }

        public ConfigurationType GetType()
        {
            return type;
        }
    }
}