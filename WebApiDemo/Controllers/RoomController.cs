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
    public class RoomController : ApiController
    {
        IRoomManager roommanager;
        public RoomController(IRoomManager manager)
        {
            roommanager = manager;
        }
        [HttpPost]
        [Route("Room/Api/AddRoom")]
        public IHttpActionResult AddRoom(Room room)
        {
            try
            {
                room.IsActive = true;
                room.Createdby = 1;
                room.Createddate = DateTime.Now;
                room.Updatedby = 1;
                room.Updateddate = DateTime.Now;
                return Ok(roommanager.AddRoom(room));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("Room/Api/GetRoom")]
        public IHttpActionResult GetRoom(int hotelid)
        {
            try
            {
                return Ok(roommanager.GetAllRoom(hotelid).ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
