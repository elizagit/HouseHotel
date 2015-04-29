using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HouseHotel.Models;

namespace HouseHotel.DAL
{
    public class HomeRentalInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HomeRentalContext>
    {
        protected override void Seed(HomeRentalContext context)
        {
            
           var properties = new List<Property>
            {
            new Property{ PropertyID = "12345",  Address = "California", Country = "America", DepositRequired = 200, PriceHighSeason = 900, PriceMidSeason = 700, PriceLowSeason= 400, UnitDescription = "Bungalow"},
            new Property{ PropertyID = "54321", Address = "Paris", Country = "France", DepositRequired = 500, PriceHighSeason = 1500, PriceMidSeason = 1200, PriceLowSeason= 1000, UnitDescription = "Apartment"},
            new Property{ PropertyID = "54321", Address = "Paris", Country = "France", DepositRequired = 500, PriceHighSeason = 1500, PriceMidSeason = 1200, PriceLowSeason= 1000, UnitDescription = "Apartment"},
    
            };

            properties.ForEach(p => context.Properties.Add(p));
            context.SaveChanges();
 


    
        
            var reservations = new List<Reservation>
            {
            new Reservation { DepositReceived = 200, ReservationID = "12345RD", Status = "Free", TimeSegment = DateTime.Parse("25-01-2016"), PropertyID = "12345"}
            };

            reservations.ForEach(r => context.Reservations.Add(r));
            context.SaveChanges();
        
        
    
                  }
    }
}
   

            
         
           
          
        
    


       

