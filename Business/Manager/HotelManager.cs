using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data.Model;
using Data.Reporitory;

using BusinessEntities.Entities;
using Data.Reporitory.Interface;
using Business.Manager.Interface;
namespace Business.Manager
{
    public class HotelManager : IHotelManager
    {
        IHotelManager hotelManager;
        public HotelManager(IHotelManager manager)
        {
            hotelManager = manager;
        }
        public bool AddHotel(Hotel hotel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Hotel, tblHotel>());
            IMapper mapper = config.CreateMapper();
            tblHotel ht = mapper.Map<Hotel, tblHotel>(hotel);
            return hotelManager.AddHotel(hotel);
        }

        public IList<Hotel> GetAllHotel()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblHotel, Hotel>());
            IMapper mapper = config.CreateMapper();
            var data = hotelManager.GetAllHotel().ToList();
            return data;
        }

        public Hotel GetHotelById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
