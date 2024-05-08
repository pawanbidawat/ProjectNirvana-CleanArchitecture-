using Microsoft.EntityFrameworkCore;
using Nirvana.Application.Interfaces;
using Nirvana.Domain.Entity;
using Nirvana.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Infrastructure.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelDbContext _context;
        public HotelRepository(HotelDbContext context)
        {
            _context = context;
        }
        public Task<bool> AddBlackoutDates(int roomId, List<DateTime> dates)
        {
            throw new NotImplementedException();
        }

        public bool AddHoteldetails(HotelDetailsEntity hotelDetails)
        {
             _context.HotelDetails.Add(hotelDetails);
            int response = _context.SaveChanges();
            return response > 0;
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
            var data = _context.HotelDetails.Include(x => x.HotelRooms).ThenInclude(y => y.DateRanges).ToList();
            return data;
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
