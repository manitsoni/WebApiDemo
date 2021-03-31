using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using BusinessEntities.Entities;
namespace Data.Reporitory.Interface
{
    public interface IRoomRepository
    {
        bool AddRomm(tblRoom room);
        IList<RoomList> GetRoomList(int hotelid);
    }
}
