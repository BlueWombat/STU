using System;
using BlueWombat.BusinessLogic.Xml;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class LanguageManagerTests
    {
        [Test]
        public void can_we_get_all_registered_languages()
        {
            var langs = LanguageManager.GetLanguages();
            foreach (var lang in langs)
            {
                Console.WriteLine($"\tName: {lang.Name}, IsoCode: {lang.IsoCode}, PropertyName: {lang.PropertyName}");
            }
        }

        [Test]
        public void can_we_get_filtered_language_lists()
        {
            var originalLanguages = LanguageManager.GetOriginalLanguages();
            Console.WriteLine("Original languages");
            foreach (var lang in originalLanguages)
            {
                Console.WriteLine($"\tName: {lang.Name}, IsoCode: {lang.IsoCode}, PropertyName: {lang.PropertyName}");
            }
            var targetLanguages = LanguageManager.GetTargetLanguages();
            Console.WriteLine("Target languages");
            foreach (var lang in targetLanguages)
            {
                Console.WriteLine($"\tName: {lang.Name}, IsoCode: {lang.IsoCode}, PropertyName: {lang.PropertyName}");
            }
        }
    }
}
