using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Room
    {
        public int Id { get; set; }

        public int? Hotelid { get; set; }

        public string Roomname { get; set; }

        public string Roomcategory { get; set; }

        public decimal? Roomprice { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? Createddate { get; set; }

        public int? Createdby { get; set; }

        public DateTime? Updateddate { get; set; }

        public int? Updatedby { get; set; }
    }
}
