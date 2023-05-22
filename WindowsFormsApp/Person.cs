using System;
using System.Xml.Serialization;

namespace WindowsFormsApp
{
    [Serializable]
    [XmlRoot(ElementName = "Owner")]
    public class Person
    {
        [XmlAttribute]
        public Guid ID { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string Surname { get; set; }
    }
}
