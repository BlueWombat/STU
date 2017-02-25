using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace BlueWombat.BusinessLogic.Xml
{
    public sealed class XmlParser
    {
        private static XmlSerializer GetSerializer()
        {
            var serializer = new XmlSerializer(typeof(SitecoreEntity), new[] { typeof(PhraseEntity) });
            return serializer;
        }

        public static SitecoreEntity FromXml(string filename)
        {
            var serializer = GetSerializer();
            using (var file = File.OpenRead(filename))
            {
                return serializer.Deserialize(file) as SitecoreEntity;
            }
        }

        public static void ToXml(string filename, SitecoreEntity entity)
        {
            var serializer = GetSerializer();
            using (var file = File.OpenWrite(filename))
            {
                serializer.Serialize(file, entity);
            }
        }

        public static Dictionary<string, string> GetLanguages()
        {
            var langs =
                typeof(PhraseEntity).GetProperties()
                    .Where(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(LanguageAttribute)))
                    .Select(p => new
                    {
                        Name = p.CustomAttributes.SingleOrDefault(a => a.AttributeType == typeof(LanguageAttribute)).
                            NamedArguments.SingleOrDefault(an => an.MemberName == "Name").TypedValue.Value.ToString(),
                        PropertyName = p.Name
                    }).ToDictionary(l => l.Name, l => l.PropertyName);

            return langs;
        }
    }
}
