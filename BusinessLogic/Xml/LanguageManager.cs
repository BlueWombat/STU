using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using BlueWombat.BusinessLogic.Config;

namespace BlueWombat.BusinessLogic.Xml
{
    public class LanguageManager
    {
        internal static List<Language> GetLanguages()
        {
            var langs =
                typeof(PhraseEntity).GetProperties()
                    .Where(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(LanguageAttribute)))
                    .Select(p => new Language
                    {
                        Name = p.CustomAttributes.SingleOrDefault(a => a.AttributeType == typeof(LanguageAttribute)).
                            NamedArguments.SingleOrDefault(an => an.MemberName == "Name").TypedValue.Value.ToString(),
                        IsoCode = p.CustomAttributes.SingleOrDefault(a => a.AttributeType == typeof(XmlElementAttribute)).
                            NamedArguments.SingleOrDefault(an => an.MemberName == "ElementName").TypedValue.Value.ToString(),
                        PropertyName = p.Name
                    }).ToList();

            return langs;
        }

        public static List<Language> GetOriginalLanguages()
        {
            var langs = STUConfig.GetConfig().OriginalLanguages.Cast<LanguageConfigElement>().Select(l => l.IsoCode);
            if (!langs.Any())
                return GetLanguages();
            var filteredLangs = GetLanguages().Where(l => langs.Contains(l.IsoCode)).ToList();
            return filteredLangs;
        }

        public static List<Language> GetTargetLanguages()
        {
            var langs = STUConfig.GetConfig().TargetLanguages.Cast<LanguageConfigElement>().Select(l => l.IsoCode);
            if (!langs.Any())
                return GetLanguages();
            var filteredLangs = GetLanguages().Where(l => langs.Contains(l.IsoCode)).ToList();
            return filteredLangs;
        }
    }
}
