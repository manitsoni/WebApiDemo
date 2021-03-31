using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using BusinessEntities.Entities;
namespace Business.Manager.Interface
{
    public interface IRoomManager
    {
        bool AddRoom(Room room);
        IList<RoomList> GetAllRoom(int hotelid);
    }
}
