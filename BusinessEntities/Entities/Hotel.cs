using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Hotelname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public Nullable<int> Contactnumber { get; set; }
        public string Contactperson { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> Createddate { get; set; }
        public Nullable<int> Createdby { get; set; }
        public Nullable<System.DateTime> Updateddate { get; set; }
        public Nullable<int> Updatedby { get; set; }
    }
}
