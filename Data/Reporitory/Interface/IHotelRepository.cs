using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
namespace Data.Reporitory.Interface
{
    public interface IHotelRepository
    {
        bool AddHotel(tblHotel hotel);
        IQueryable<tblHotel> GetAllHotel();
        tblHotel GetHotelById(int id);

    }
}
