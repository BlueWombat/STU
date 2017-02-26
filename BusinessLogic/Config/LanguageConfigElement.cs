using System.Configuration;
using System.Xml;

namespace BlueWombat.BusinessLogic.Config
{
    public class LanguageConfigElement : ConfigurationElement
    {
        public string IsoCode { get; private set; }

        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
            this.IsoCode = reader.ReadElementContentAsString();
        }

        public override string ToString()
        {
            return this.IsoCode;
        }
    }
}
