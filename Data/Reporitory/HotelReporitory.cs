using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Data.Reporitory.Interface;

namespace Data.Reporitory
{
    public class HotelReporitory : IHotelRepository
    {
        HotelManagementEntities db = new HotelManagementEntities();
        public bool AddHotel(tblHotel hotel)
        {
            db.tblHotels.Add(hotel);
            return db.SaveChanges() > 0;
        }

        public IQueryable<tblHotel> GetAllHotel()
        {
            return db.tblHotels;
        }

        public tblHotel GetHotelById(int id)
        {
            return db.tblHotels.Find(id);
        }
    }
}
