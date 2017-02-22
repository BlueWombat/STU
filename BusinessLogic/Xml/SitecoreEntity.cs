using System;
using System.Xml.Serialization;

namespace BlueWombat.BusinessLogic.Xml
{
    [XmlRoot(ElementName = "sitecore")]
    public class SitecoreEntity : ICloneable
    {
        [XmlElement(ElementName = "phrase")]
        public PhraseEntity[] Phrases { get; set; }

        public object Clone()
        {
            var phrases = new PhraseEntity[Phrases.Length];
            for (long i = 0; i < phrases.LongLength; i++)
            {
                phrases[i] = Phrases[i].Clone() as PhraseEntity;
            }
            return new SitecoreEntity
            {
                Phrases = phrases
            };
        }
    }
}
