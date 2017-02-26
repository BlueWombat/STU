using System;
using BlueWombat.Tools;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class CultureManagerTests
    {
        [Test]
        public void can_we_get_all_cultures()
        {
            var cultures = CultureManager.GetCultures();
            foreach (var culture in cultures)
            {
                Console.WriteLine($"Name: {culture.Item1} IsoCode; {culture.Item2}");
            }
        }
    }
}
