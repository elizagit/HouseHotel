using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;


namespace HouseHotel.Models
{
    public class Property
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String PropertyID { get; set; }
        public String Address { get; set; }
        public String Country { get; set; }

        public String UnitDescription { get; set; }
        public double PriceMidSeason { get; set; }
        public double PriceLowSeason { get; set; }
        public double PriceHighSeason { get; set; }
        public double DepositRequired { get; set; }

        private ICollection<Reservation> Reservation { get; set; }
    }
}