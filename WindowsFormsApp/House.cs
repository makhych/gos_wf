using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WindowsFormsApp
{
    [Serializable]
    [XmlRoot]
    public class House
    {
        [XmlAttribute]
        public Guid ID { get; set; }
        [XmlElement]
        public string Street { get; set; }
        [XmlElement]
        public int Num { get; set; }
        [XmlElement]
        public Person Owner { get; set; }
        [XmlArray]
        public List<Room> Rooms { get; set; }
    }
}
