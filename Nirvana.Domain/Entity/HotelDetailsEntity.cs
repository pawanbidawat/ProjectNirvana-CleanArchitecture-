
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Domain.Entity
{
    public class HotelDetailsEntity
    {
        [Key]
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? HotelAddress { get; set; }
        public string? HotelDescription { get; set; }
        public string? BlockedChildRange { get; set; }

        public string? HotelImage { get; set; }
        public decimal Rating { get; set; }
        public List<HotelRoomEntity>? HotelRooms { get; set; }
    }
}
