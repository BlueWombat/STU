using System.IO;
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
    }
}
