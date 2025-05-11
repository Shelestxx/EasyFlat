using EasyFlat.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        public string PhoneNumber { get; set; }

        public Listing(int id, string title, string description, string location, decimal rentPrice, int roomCount, double area, int ownerID, DateTime publishDate, string phoneNumber)
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
            PhoneNumber = phoneNumber;
        }
    }

    public class ListingRepository : Repository<Listing>
    {
        private static ListingRepository _instance;
        private const string ListingsFilePath = "../../listings.json";

        public static ListingRepository Instance => _instance ?? (_instance = new ListingRepository());

        public void LoadFromFile()
        {
            if (!File.Exists(ListingsFilePath)) return;

            var json = File.ReadAllText(ListingsFilePath);
            var listings = JsonConvert.DeserializeObject<List<Listing>>(json);
            _entities = listings ?? new List<Listing>();
        }

        public void SaveToFile()
        {
            var json = JsonConvert.SerializeObject(_entities, Formatting.Indented);
            File.WriteAllText(ListingsFilePath, json);
        }

        public void Update(Listing updatedListing)
        {
            var index = _entities.FindIndex(l => l.ID == updatedListing.ID);
            if (index != -1)
            {
                _entities[index] = updatedListing;
                SaveToFile();
            }
        }

        public override void Remove(Listing listing)
        {
            base.Remove(listing);
            SaveToFile();
        }

        public override void Add(Listing entity)
        {
            base.Add(entity);
            SaveToFile();
        }
    }
}