using System.Configuration;

namespace BlueWombat.BusinessLogic.Config
{
    public class LanguageConfigElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new LanguageConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((LanguageConfigElement)element).IsoCode;
        }
    }
}
