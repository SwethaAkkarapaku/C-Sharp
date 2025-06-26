using Microsoft.AspNetCore.Mvc.Rendering;

namespace RideUI.DTO
{
    public class AddPickUpDrop
    {
        public Guid sourceLoc { get; set; }

        public Guid destinationLoc { get; set; }

        public Guid driverId { get; set; }
        public Guid custId { get; set; }
        public List<SelectListItem> srcList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> destList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> drvList { get; set; } = new List<SelectListItem>();

    }
}
