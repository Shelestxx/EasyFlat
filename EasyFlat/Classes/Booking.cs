using EasyFlat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFlat.Classes
{
    public enum BookingStatus
    {
        Awaiting_confirmation,   //Очікує підтвердження
        Confirm,                 //Підтверджено
        Cancelled,               //Скасовано
    }

    public class Booking : IEntity
    {
        public int ID { get; }
        public int TenantID { get; }
        public int ListingID { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public BookingStatus Status { get; private set; }

        public Booking(int id, int tenantID, int listingID, DateTime startDate, DateTime endDate, BookingStatus status)
        {
            ID = id;
            TenantID = tenantID;
            ListingID = listingID;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }

        public void UpdateStatus(BookingStatus newStatus)
        {
            Status = newStatus;
        }
    }
    public class BookingRepository : Repository<Booking> { }
}