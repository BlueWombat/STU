using System.Configuration;

namespace BlueWombat.BusinessLogic.Config
{
    public class STUConfig : ConfigurationSection
    {
        [ConfigurationProperty("OriginalLanguages")]
        [ConfigurationCollection(typeof(LanguageConfigElementCollection), AddItemName = "Language")]
        public LanguageConfigElementCollection OriginalLanguages
        {
            get { return this["OriginalLanguages"] as LanguageConfigElementCollection; }
        }

        [ConfigurationProperty("TargetLanguages")]
        [ConfigurationCollection(typeof(LanguageConfigElementCollection), AddItemName = "Language")]
        public LanguageConfigElementCollection TargetLanguages
        {
            get { return this["TargetLanguages"] as LanguageConfigElementCollection; }
        }

        public static STUConfig GetConfig()
        {
            var section = ConfigurationManager.GetSection("STU") as STUConfig;
            return section ?? new STUConfig();
        }
    }
}
