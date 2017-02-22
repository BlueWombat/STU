using System;
using System.Xml.Serialization;

namespace BlueWombat.BusinessLogic.Xml
{
    public partial class PhraseEntity : ICloneable
    {
        [XmlAttribute(AttributeName = "path")]
        public string path { get; set; }

        [XmlAttribute(AttributeName = "key")]
        public string key { get; set; }

        [XmlAttribute(AttributeName = "itemid")]
        public string itemid { get; set; }

        [XmlAttribute(AttributeName = "fieldid")]
        public string fieldid { get; set; }

        [XmlAttribute(AttributeName = "updated")]
        public string updated { get; set; }

        public override string ToString()
        {
            return $"path: {path}, key: {key}, itemid: {itemid}, fieldid: {fieldid}, updated: {updated}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
