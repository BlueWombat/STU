using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace BlueWombat.Tools
{
    public sealed class CultureManager
    {
        public static List<Tuple<string, string>> GetCultures()
        {
            var cultureReg = new Regex(@"\s*\(.+\)$");
            var cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            .Select(c => new
            {
                Name = c.EnglishName,
                IsoCode = c.Name
            })
            .Union(CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(c => new
                {
                    Name = cultureReg.Replace(c.EnglishName, ""),
                    IsoCode = c.TwoLetterISOLanguageName.ToLowerInvariant()
                }))
            .GroupBy(c => c.IsoCode)
            .Distinct()
            .Select(c => c.First())
            .OrderBy(c => c.Name)
            .Select(c => new Tuple<string, string>(c.Name, c.IsoCode))
            .ToList();

            return cultures;
        }
    }
}
