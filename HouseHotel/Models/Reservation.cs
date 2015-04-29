using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseHotel.Models
{
    public class Reservation
    {
        public String ReservationID { get; set; }

        public String PropertyID { get; set; }
        public String Status { get; set; }

        public DateTime TimeSegment { get; set; }
        public double DepositReceived { get; set; }

        public virtual Property Property { get; set; }
    }
}