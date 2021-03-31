using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Business;
using BusinessEntities.Entities;
using Business.Manager;
using Business.Manager.Interface;
namespace WebApiDemo.Controllers
{
    public class HotelController : ApiController
    {
        private IHotelManager hotelmanager;
        public HotelController(IHotelManager manager)
        {
            hotelmanager = manager;
        }
        [HttpPost]
        [Route("Hotel/Api/AddHotel")]
        public IHttpActionResult AddHotel(Hotel hotel)
        {
            try
            {
                hotel.Createdby = 1;
                hotel.Updatedby = 1;
                hotel.Createddate = DateTime.Now;
                hotel.Updateddate = DateTime.Now;
                hotel.IsActive = true;
                return Ok(hotelmanager.AddHotel(hotel));
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("Hotel/Api/GetHotel")]
        public IHttpActionResult GetHotels()
        {
            try
            {
                return Ok(hotelmanager.GetAllHotel().ToList());
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
