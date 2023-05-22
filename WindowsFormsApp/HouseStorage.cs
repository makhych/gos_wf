using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class HouseStorage
    {
        private readonly FileXMLSingleton source;
        public HouseStorage()
        {
            source = FileXMLSingleton.GetInstance();
        }

        public void SaveToFile()
        {
            source.SaveData();
        }

        public List<House> GetFullList()
        {
            return source.Houses.ToList();
        }

        public List<House> GetFilteredList(string Street)
        {
            if (String.IsNullOrEmpty(Street))
            {
                return null;
            }
            //return source.Houses
            //    .Where(rec => String.Equals(rec.Street, Street))
            //    .ToList();
            //var selected = from h in source.Houses
            //               where h.Street.ToLower() == Street.ToLower()
            //                     orderby h.Num descending
            //                     select h;
            //var selected = from h in source.Houses
            //               //where h.Street.ToLower() == Street.ToLower()
            //               group h by h.Owner;

            //foreach (var owner in selected)
            //{
            //    foreach (var house in owner)
            //    {
            //    }
            //}
            //return selected.ToList();
        }

        public void InsertData()
        {
            var person = new Person
            {
                ID = Guid.NewGuid(),
                Name = "Владелец1",
                Surname = "Пупкин"
            };
            var person2 = new Person
            {
                ID = Guid.NewGuid(),
                Name = "Владелец2",
                Surname = "Пупкин2"
            };

            var room = new Room
            {
                ID = Guid.NewGuid(),
                Name = "Спальня",
                Area = 44.8f
            };
            var room2 = new Room
            {
                ID = Guid.NewGuid(),
                Name = "Туалет",
                Area = 3.8f
            };
            var room3 = new Room
            {
                ID = Guid.NewGuid(),
                Name = "Кухня",
                Area = 20f
            };

            var h1 = new House
            {
                ID = Guid.NewGuid(),
                Street = "Ленина",
                Num = 1,
                Owner = person,
                Rooms = new List<Room>() { room, room2, room3 }
            };
            var h2 = new House
            {
                ID = Guid.NewGuid(),
                Street = "Ленина",
                Num = 2,
                Owner = person2,
                Rooms = new List<Room>() { room}
            };
            var h3 = new House
            {
                ID = Guid.NewGuid(),
                Street = "НеЛенина",
                Num = 1,
                Owner = person,
                Rooms = new List<Room>() { room, room2}
            };

            source.Houses.Add(h1);
            source.Houses.Add(h2);
            source.Houses.Add(h3);

            source.Rooms.Add(room);
            source.Rooms.Add(room2);
            source.Rooms.Add(room3);

            source.Persons.Add(person);
            source.Persons.Add(person2);
        }

    }
}
