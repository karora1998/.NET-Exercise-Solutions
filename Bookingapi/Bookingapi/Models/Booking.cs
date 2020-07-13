using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookingapi.Models
{
    public class Booking
    {
        [Key]
       public int  roomId { get; set; }
       public string HotelName { get; set; }    
       public DateTime Date_of_booking { get; set; }
        public string Customer_name { get; set; }     
        public string Address { get; set; }
        public bool Status_of_booking { get; set; }
        public string Email_of_customer { get; set; }

    }
}
