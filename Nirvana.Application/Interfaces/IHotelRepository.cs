using Nirvana.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Application.Interfaces
{
    public interface IHotelRepository
    {
        List<HotelDetailsEntity> GetAllHotels();
        HotelDetailsEntity GetHotelsDetailsById(int id);
        List<HotelRoomEntity> GetRoomsByHotelId(int Id);
        HotelRoomEntity GetRoomDetailsByRoomId(int id);
        bool DeleteRoomById(int id);
        bool AddHoteldetails(HotelDetailsEntity hotelDetails);
        bool RemoveHotel(int id);
        bool AddRoomDetails(HotelRoomEntity room);
        bool EditRoomDetails(int id, HotelRoomEntity Entity);
        List<RoomPriceAndDateRangeEntity> GetRoomDateRange(int id);
        RoomPriceAndDateRangeEntity GetRoomDateRangeByDateRangeId(int id);

        bool AddRoomDateRange(RoomPriceAndDateRangeEntity Entity);
        bool DeleteRoomPriceByDateRangeId(int id);
        bool UpdateRoomDateRange(RoomPriceAndDateRangeEntity Entity);
        bool UpdateHotelDetails(int id, HotelDetailsEntity hotelDetails);

        Task<bool> AddBlackoutDates(int roomId, List<DateTime> dates);
        Task<bool> RemoveBlackoutDates(int roomId, List<DateTime> dates);
        List<BlackoutDateEntity> getblackoutdates(int roomid);
        IQueryable<HotelDetailsEntity> GetHotelSearchResult(string searchValue);
    }
}
