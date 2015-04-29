using HouseHotel.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HouseHotel.DAL
{
    public class HomeRentalContext : DbContext
    {
        
        public HomeRentalContext() : base("HomeRentalContext")
        {
        }
        
        public DbSet<Property> Properties { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}