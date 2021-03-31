using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using BusinessEntities.Entities;
using Data.Reporitory.Interface;

namespace Data.Reporitory
{
    public class RoomRepository : IRoomRepository
    {
        HotelManagementEntities db = new HotelManagementEntities();
        public bool AddRomm(tblRoom room)
        {
            db.tblRooms.Add(room);
            return db.SaveChanges() > 0;
        }

        public IList<RoomList> GetRoomList(int hotelid)
        {
            var RoomList = (from rm in db.tblRooms
                            join hd in db.tblHotels on rm.Hotelid equals hd.Id
                            where rm.Hotelid == hotelid
                            select new RoomList
                            {
                                Id = rm.Id,
                                Createdby = rm.Createdby,
                                IsActive = rm.IsActive,
                                Createddate = rm.Createddate,
                                Hotelname = hd.Hotelname,
                                Roomcategory = rm.Roomcategory,
                                Roomname = rm.Roomname,
                                Roomprice = rm.Roomprice,
                                Updatedby = rm.Updatedby,
                                Updateddate = rm.Updateddate
                                   
                            }).ToList();
            return RoomList;
        }
    }
}
