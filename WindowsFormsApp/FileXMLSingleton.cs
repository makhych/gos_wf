using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace WindowsFormsApp
{
    public class FileXMLSingleton
    {
        private static FileXMLSingleton instance;

        private readonly string PersonFileName = "Persons.xml";
        private readonly string HouseFileName = "Houses.xml";
        private readonly string RoomFileName = "Rooms.xml";

        public List<Person> Persons { get; set; }
        public List<House> Houses { get; set; }
        public List<Room> Rooms { get; set; }

        private FileXMLSingleton()
        {
            Persons = LoadPersons();
            Houses = LoadHouses();
            Rooms = LoadRooms();
        }

        public static FileXMLSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileXMLSingleton();
            }
            return instance;
        }

        ~FileXMLSingleton()
        {
            SaveData();
        }

        public void SaveData()
        {
            SaveHouses();
            SavePersons();
            SaveRooms();
        }

        private List<Person> LoadPersons()
        {
            if (!File.Exists(PersonFileName))
            {
                return new List<Person>(); ;
            }
            using (FileStream fs = File.OpenRead(PersonFileName))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                    return (List<Person>)serializer.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    throw new Exception(
                        $"Произошла ошибка при " +
                        $"чтении списка persons: {ex.Message}");
                }
            }
        }

        private List<Room> LoadRooms()
        {
            if (!File.Exists(RoomFileName))
            {
                return new List<Room>();
            }
            using (FileStream fs = File.OpenRead(RoomFileName))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));
                    return (List<Room>)serializer.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    throw new Exception(
                        $"Произошла ошибка при " +
                        $"чтении списка rooms: {ex.Message}");
                }
            }
        }

        private List<House> LoadHouses()
        {
            if (!File.Exists(HouseFileName))
            {
                return new List<House>();
            }
            using (FileStream fs = File.OpenRead(HouseFileName))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<House>));
                    return (List<House>)serializer.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    throw new Exception(
                        $"Произошла ошибка при " +
                        $"чтении списка houses: {ex.Message}");
                }
            }
        }

        private void SaveHouses()
        {
            if (Houses is null)
            {
                return;
            }
            using (FileStream fs = File.Open(HouseFileName, FileMode.OpenOrCreate))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<House>));
                    serializer.Serialize(fs, Houses);
                }
                catch (Exception ex)
                {
                    throw new Exception(
                        $"Произошла ошибка при " +
                        $"сохранении списка houses: {ex.Message}");
                }
            }
        }

        private void SavePersons()
        {
            if (Persons is null)
            {
                return;
            }
            using (FileStream fs = File.Open(PersonFileName, FileMode.OpenOrCreate))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                    serializer.Serialize(fs, Persons);
                }
                catch (Exception ex)
                {
                    throw new Exception(
                        $"Произошла ошибка при " +
                        $"сохранении списка persons: {ex.Message}");
                }
            }
        }

        private void SaveRooms()
        {
            if (Persons is null)
            {
                return;
            }
            using (FileStream fs = File.Open(RoomFileName, FileMode.OpenOrCreate))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));
                    serializer.Serialize(fs, Rooms);
                }
                catch (Exception ex)
                {
                    throw new Exception(
                        $"Произошла ошибка при " +
                        $"сохранении списка rooms: {ex.Message}");
                }
            }
        }















































        //private List<Person> LoadPersons()
        //{
        //    var list = new List<Person>();
        //    if (File.Exists(PersonFileName))
        //    {
        //        XDocument xDocument = XDocument.Load(PersonFileName);
        //        var xElements = xDocument.Root.Elements("Person").ToList();

        //        foreach (var elem in xElements)
        //        {
        //            list.Add(new Person
        //            {
        //                ID = Guid.Parse(elem.Attribute("ID").Value),
        //                Name = elem.Element("Name").Value,
        //                Surname = elem.Element("Surname").Value,
        //            });
        //        }
        //    }
        //    return list;
        //}

        //private List<Room> LoadRooms()
        //{
        //    var list = new List<Room>();
        //    if (File.Exists(RoomFileName))
        //    {
        //        XDocument xDocument = XDocument.Load(RoomFileName);
        //        var xElements = xDocument.Root.Elements("Room").ToList();

        //        foreach (var elem in xElements)
        //        {
        //            list.Add(new Room
        //            {
        //                ID = Guid.Parse(elem.Attribute("ID").Value),
        //                Name = elem.Element("Name").Value,
        //                Area = float.Parse(elem.Element("Area").Value),
        //            });
        //        }
        //    }
        //    return list;
        //}

        //private List<House> LoadHouses()
        //{
        //    var list = new List<House>();
        //    if (File.Exists(HouseFileName))
        //    {
        //        XDocument xDocument = XDocument.Load(HouseFileName);
        //        var xElements = xDocument.Root.Elements("House").ToList();

        //        foreach (var elem in xElements)
        //        {
        //            var rooms = new List<Room>();
        //            foreach (var room in elem.Element("Rooms").Elements("Room").ToList())
        //            {
        //                rooms.Add(new Room
        //                {
        //                    ID = Guid.Parse(room.Attribute("ID").Value),
        //                    Name = room.Element("Name").Value,
        //                    Area = float.Parse(room.Element("Area").Value),
        //                });
        //            }
        //            var owner = new Person { 
        //                ID = Guid.Parse(elem.Element("Owner").Attribute("ID").Value),
        //                Name = elem.Element("Owner").Element("Name").Value,
        //                Surname = elem.Element("Owner").Element("Surname").Value,
        //            };

        //            list.Add(new House
        //            {
        //                ID = Guid.Parse(elem.Attribute("ID").Value),
        //                Owner = owner,
        //                Rooms = rooms,
        //                Num = Convert.ToInt32(elem.Element("Num").Value),
        //                Street = elem.Element("Street").Value
        //            });

        //        }
        //    }
        //    return list;
        //}

        //private void SaveHouses()
        //{
        //    if (Houses != null)
        //    {
        //        var xElement = new XElement("Houses");
        //        foreach (var house in Houses)
        //        {
        //            var rooms = new XElement("Rooms");
        //            foreach (var room in house.Rooms)
        //            {
        //                rooms.Add(new XElement("Room", 
        //                    new XAttribute("ID", room.ID.ToString()),
        //                    new XElement("Name", room.Name),
        //                    new XElement("Area", room.Area.ToString())));
        //            }

        //            var owner = new XElement("Owner",
        //                    new XAttribute("ID", house.Owner.ID.ToString()),
        //                    new XElement("Name", house.Owner.Name),
        //                    new XElement("Surname", house.Owner.Surname));

        //            xElement.Add(new XElement("House",
        //             new XAttribute("ID", house.ID.ToString()),
        //             new XElement("Street", house.Street),
        //             new XElement("Num", house.Num.ToString()),
        //             rooms,
        //             owner));
        //        }
        //        XDocument xDocument = new XDocument(xElement);
        //        xDocument.Save(HouseFileName);
        //    }
        //}

        //private void SavePersons()
        //{
        //    if (Persons != null)
        //    {
        //        var xElement = new XElement("Persons");
        //        foreach (var person in Persons)
        //        {
        //            xElement.Add(new XElement("Person",
        //            new XAttribute("ID", person.ID.ToString()),
        //            new XElement("Name", person.Name),
        //            new XElement("Surname", person.Surname)));
        //        }

        //        XDocument xDocument = new XDocument(xElement);
        //        xDocument.Save(PersonFileName);
        //    }
        //}

        //private void SaveRooms()
        //{
        //    if (Rooms != null)
        //    {
        //        var xElement = new XElement("Rooms");
        //        foreach (var room in Rooms)
        //        {
        //            xElement.Add(new XElement("Room",
        //            new XAttribute("ID", room.ID.ToString()),
        //            new XElement("Name", room.Name),
        //            new XElement("Area", room.Area.ToString())));
        //        }

        //        XDocument xDocument = new XDocument(xElement);
        //        xDocument.Save(RoomFileName);
        //    }
        //}

    }
}
