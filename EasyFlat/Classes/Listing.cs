using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Classes
{
    public class Listing
    {
        public int ID { get; }
        public string Title { get; }
        public string Description { get; }
        public string Location { get; }
        public decimal RentPrice { get; }
        public int RoomCount { get; }
        public double Area { get; }
        public string PhotoUrl { get; }
        public int OwnerID { get; }
        public DateTime PublishDate { get; }

        public Listing(int id, string title, string description, string location, decimal rentPrice, int roomCount, double area, string photoUrl, int ownerID, DateTime publishDate)
        {
            ID = id;
            Title = title;
            Description = description;
            Location = location;
            RentPrice = rentPrice;
            RoomCount = roomCount;
            Area = area;
            PhotoUrl = photoUrl;
            OwnerID = ownerID;
            PublishDate = publishDate;
        }
    }
}
