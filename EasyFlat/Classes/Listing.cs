using EasyFlat.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EasyFlat.Classes
{
    public class Listing : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal RentPrice { get; set; }
        public int RoomCount { get; set; }
        public double Area { get; set; }
        public int OwnerID { get; set; }
        public DateTime PublishDate { get; set; }

        public Listing(int id, string title, string description, string location, decimal rentPrice, int roomCount, double area, int ownerID, DateTime publishDate)
        {
            ID = id;
            Title = title;
            Description = description;
            Location = location;
            RentPrice = rentPrice;
            RoomCount = roomCount;
            Area = area;
            OwnerID = ownerID;
            PublishDate = publishDate;
        }

        // Конструктор без параметрів для десеріалізації JSON
        public Listing() { }
    }

    public class ListingRepository : Repository<Listing>
    {
        private static ListingRepository _instance;

        public static ListingRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListingRepository();
                }
                return _instance;
            }
        }

        private const string ListingsFilePath = "../../listings.json";

        public void Update(Listing updatedListing)
        {
            var existingListing = _entities.FirstOrDefault(l => l.ID == updatedListing.ID);
            if (existingListing != null)
            {
                existingListing.Title = updatedListing.Title;
                existingListing.Description = updatedListing.Description;
                existingListing.Location = updatedListing.Location;
                existingListing.RentPrice = updatedListing.RentPrice;
                existingListing.RoomCount = updatedListing.RoomCount;
                existingListing.Area = updatedListing.Area;
                existingListing.OwnerID = updatedListing.OwnerID;
                existingListing.PublishDate = updatedListing.PublishDate;

                SaveToFile(); // Зберігаємо зміни у JSON
            }
        }

        public void SaveToFile()
        {
            var json = JsonConvert.SerializeObject(_entities, Formatting.Indented);
            File.WriteAllText(ListingsFilePath, json);
        }

        public void LoadFromFile()
        {
            if (!File.Exists(ListingsFilePath)) return;

            var json = File.ReadAllText(ListingsFilePath);
            var listings = JsonConvert.DeserializeObject<List<Listing>>(json);
            _entities.Clear();
            _entities.AddRange(listings);
        }
    }
}
