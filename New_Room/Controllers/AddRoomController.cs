using Microsoft.AspNetCore.Mvc;
using RoomManagementMVCApp.Data;
using RoomManagementMVCApp.DTO;

namespace RoomManagementMVCApp.Controllers
{
    public class AddRoomController : Controller
    {
        RoomManagementDbContext context;
        public AddRoomController(RoomManagementDbContext _context) { 
            context = _context;
        }
        [HttpGet]
        public IActionResult Add()
        {
            MeetingRoomDTO meetingRoom = new MeetingRoomDTO();
            return View(meetingRoom);
        }
        [HttpPost]
        public IActionResult Add(MeetingRoomDTO model)
        {
            MeetingRoom meetingRoom = new MeetingRoom()
            {
                RoomId = Guid.NewGuid(),
                RoomName= model.RoomName,
                Capacity = model.Capacity,
                Location = model.Location
            };
            context.meetingRooms.Add(meetingRoom);
            context.SaveChanges();
            return View(model);
        }
    }
}
