using EasyFlat.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EasyFlat.Classes
{
    public class Listing : IEntity
    {
        public int ID { get; set; }

        [MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string Location { get; set; }

        public decimal RentPrice { get; set; }

        public int RoomCount { get; set; }

        public double Area { get; set; }

        public DateTime PublishDate { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public int OwnerID { get; set; }

        public virtual User Owner { get; set; }
    


   
        public Listing() { }

        public Listing(int id, string title, string description, string location, decimal rentPrice, int roomCount, double area, int ownerId, DateTime publishDate, string phoneNumber)
        {
            ID = id;
            Title = title;
            Description = description;
            Location = location;
            RentPrice = rentPrice;
            RoomCount = roomCount;
            Area = area;
            OwnerID = ownerId;
            PublishDate = publishDate;
            PhoneNumber = phoneNumber;
        }
    }


    public class ListingRepository : Repository<Listing>
    {
        
        private readonly AppDbContext _context;

        public ListingRepository(AppDbContext context)
        {
            _context = context;
        }

        public override IEnumerable<Listing> GetAll()
        {
            return _context.Listings.Include(l => l.Owner).ToList();
        }

        public override Listing GetById(int id)
        {
            return _context.Listings.Include(l => l.Owner).FirstOrDefault(l => l.ID == id);
        }

        public override void Add(Listing entity)
        {
            _context.Listings.Add(entity);
            _context.SaveChanges();
        }

        public override void Remove(Listing listing)
        {
            _context.Listings.Remove(listing);
            _context.SaveChanges();
        }

        public void Update(Listing updatedListing)
        {
            _context.Listings.Update(updatedListing);
            _context.SaveChanges();
        }
    }
}