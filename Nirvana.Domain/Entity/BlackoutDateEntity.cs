
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Domain.Entity
{
    public class BlackoutDateEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public HotelRoomEntity? RoomEntity { get; set; }
    }
}
