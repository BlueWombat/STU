using System;
using BlueWombat.BusinessLogic.Config;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ConfigTests
    {
        [Test]
        public void can_we_read_language_filters_from_config()
        {
            var section = STUConfig.GetConfig();
            Console.WriteLine("Original languages");
            foreach (var lang in section.OriginalLanguages)
            {
                Console.WriteLine($"\tIsoCode: {lang}");
            }
            Console.WriteLine("Target languages");
            foreach (var lang in section.TargetLanguages)
            {
                Console.WriteLine($"\tIsoCode: {lang}");
            }
        }
    }
}
