using System;
using System.IO;
using BlueWombat.BusinessLogic.Xml;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class XmlParserTests
    {
        [Test]
        public void can_we_deserialize_the_export()
        {
            var document = XmlParser.FromXml(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestResources", "Sample Data.xml"));
            foreach (var documentPhrase in document.Phrases)
            {
                Console.WriteLine(documentPhrase.ToString());
            }
        }

        [Test]
        public void can_we_serialize_and_save_the_object()
        {
            var dateString = DateTime.Now.ToString("yyyyMMddTHHmmss");
            var obj = new SitecoreEntity
            {
                Phrases = new[]
                {
                    new PhraseEntity
                    {
                        path = "/sitecore/content/Item1",
                        key = "Item1",
                        itemid = Guid.NewGuid().ToString("B"),
                        fieldid = "Field 1",
                        updated = dateString,
                        en = "Lorem ipsum dolor sit amet"
                    },
                    new PhraseEntity
                    {
                        path = "/sitecore/content/Item2",
                        key = "Item2",
                        itemid = Guid.NewGuid().ToString("B"),
                        fieldid = "Field 1",
                        updated = dateString,
                        en = "Lorem ipsum dolor sit amet"
                    },
                    new PhraseEntity
                    {
                        path = "/sitecore/content/Item3",
                        key = "Item3",
                        itemid = Guid.NewGuid().ToString("B"),
                        fieldid = "Field 1",
                        updated = dateString,
                        en = "Lorem ipsum dolor sit amet"
                    },
                    new PhraseEntity
                    {
                        path = "/sitecore/content/Item4",
                        key = "Item4",
                        itemid = Guid.NewGuid().ToString("B"),
                        fieldid = "Field 1",
                        updated = dateString,
                        en = "Lorem ipsum dolor sit amet"
                    },
                }
            };

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestResources", "Sample Serialization.xml");
            if (File.Exists(path))
                File.Delete(path);

            XmlParser.ToXml(path, obj);

            foreach (var documentPhrase in obj.Phrases)
            {
                Console.WriteLine(documentPhrase.ToString());
            }
        }
    }
}
