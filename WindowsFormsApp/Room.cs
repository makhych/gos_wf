using System;
using System.Xml.Serialization;

namespace WindowsFormsApp
{
    [Serializable]
    [XmlRoot]
    public class Room
    {
        [XmlAttribute]
        public Guid ID { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public float Area { get; set; }
    }
}
