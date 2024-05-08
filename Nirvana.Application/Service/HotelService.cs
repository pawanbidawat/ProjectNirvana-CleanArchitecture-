using Nirvana.Application.Interfaces;
using Nirvana.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Application.Service
{
    public class HotelService:IHotelService
    {
        private readonly IHotelRepository _repo;
        public HotelService(IHotelRepository repo)
        {
            _repo = repo; 
        }

        public Task<bool> AddBlackoutDates(int roomId, List<DateTime> dates)
        {
            throw new NotImplementedException();
        }

        public bool AddHoteldetails(HotelDetailsEntity hotelDetails)
        {
           bool response = _repo.AddHoteldetails(hotelDetails);
            if(response)
            {
                return true;
            }
            else
            { return false; }   
        }

        public bool AddRoomDateRange(RoomPriceAndDateRangeEntity Entity)
        {
            throw new NotImplementedException();
        }

        public bool AddRoomDetails(HotelRoomEntity room)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoomById(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoomPriceByDateRangeId(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditRoomDetails(int id, HotelRoomEntity Entity)
        {
            throw new NotImplementedException();
        }

        public List<HotelDetailsEntity> GetAllHotels()
        {
            var hotels = _repo.GetAllHotels();
            return hotels;
        }

        public List<BlackoutDateEntity> getblackoutdates(int roomid)
        {
            throw new NotImplementedException();
        }

        public HotelDetailsEntity GetHotelsDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<HotelDetailsEntity> GetHotelSearchResult(string searchValue)
        {
            throw new NotImplementedException();
        }

        public List<RoomPriceAndDateRangeEntity> GetRoomDateRange(int id)
        {
            throw new NotImplementedException();
        }

        public RoomPriceAndDateRangeEntity GetRoomDateRangeByDateRangeId(int id)
        {
            throw new NotImplementedException();
        }

        public HotelRoomEntity GetRoomDetailsByRoomId(int id)
        {
            throw new NotImplementedException();
        }

        public List<HotelRoomEntity> GetRoomsByHotelId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveBlackoutDates(int roomId, List<DateTime> dates)
        {
            throw new NotImplementedException();
        }

        public bool RemoveHotel(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateHotelDetails(int id, HotelDetailsEntity hotelDetails)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRoomDateRange(RoomPriceAndDateRangeEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}
