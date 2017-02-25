using System;

namespace BlueWombat.BusinessLogic.Xml
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LanguageAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
