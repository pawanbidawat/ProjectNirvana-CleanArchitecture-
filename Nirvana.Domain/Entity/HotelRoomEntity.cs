
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Domain.Entity
{
    public class HotelRoomEntity
    {
        [Key]
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public string? RoomType { get; set; }
        public string? Description { get; set; }
        public string? RoomImage { get; set; }

        // Foreign key for Hotel    
        [ForeignKey(nameof(HotelId))]
        public HotelDetailsEntity? HotelDetail { get; set; }


        public List<BlackoutDateEntity>? BlackoutDates { get; set; }
        public List<RoomPriceAndDateRangeEntity>? DateRanges { get; set; }
    }
}
