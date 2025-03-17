using EasyFlat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Classes
{
    public class Listing : IEntity  
    {
        public int ID { get; }
        public string Title { get; }
        public string Description { get; }
        public string Location { get; }
        public decimal RentPrice { get; }
        public int RoomCount { get; }
        public double Area { get; }
        public int OwnerID { get; }
        public DateTime PublishDate { get; }

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
    }
    public class ListingRepository : Repository<Listing> { } 
}
