using System;
namespace HouseHotel.DAL
{
    public interface IHomeRentalContext
    {
        System.Data.Entity.DbSet<HouseHotel.Models.Property> Properties { get; set; }
        System.Data.Entity.DbSet<HouseHotel.Models.Reservation> Reservations { get; set; }
    }
}
