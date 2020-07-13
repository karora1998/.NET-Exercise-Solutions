using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookingapi.Data
{
    public class BookingRepository: DbContext
    {
        public BookingRepository(DbContextOptions<BookingRepository> options) : base(options)
        {
        }
        public DbSet<Models.Booking> Booking { get; set; }
    }
    
}

