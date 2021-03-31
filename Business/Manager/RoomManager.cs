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
    public class RoomManager : IRoomManager
    {
        IRoomRepository roommanager;
        public RoomManager(IRoomRepository repository)
        {
            roommanager = repository;
        }
        public bool AddRoom(Room room)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Room, tblRoom>());
            IMapper mapper = config.CreateMapper();
            tblRoom rm = mapper.Map<Room, tblRoom>(room);
            return roommanager.AddRomm(rm);
        }
        public IList<RoomList> GetAllRoom(int hotelid)
        {
            return roommanager.GetRoomList(hotelid).ToList();
        }
    }
}
