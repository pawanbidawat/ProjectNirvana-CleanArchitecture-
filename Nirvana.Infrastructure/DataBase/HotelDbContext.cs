using Microsoft.EntityFrameworkCore;
using Nirvana.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Infrastructure.DataBase
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext>options):base(options)
        {
            
        }
        public DbSet<HotelDetailsEntity> HotelDetails { get; set; }
        public DbSet<HotelRoomEntity> HotelRoom { get; set; }
        public DbSet<RoomPriceAndDateRangeEntity> RoomPriceAndDateRange { get; set; }
        public DbSet<BlackoutDateEntity> BlackoutDates { get; set; }
    }
}
