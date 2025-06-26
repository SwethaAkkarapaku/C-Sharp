using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RideUI.DTO;
using RideUI.services;
using System.Text.Json;
using System.Linq;
namespace RideUI.Controllers
{
    public class PickUpRidesController : Controller
    {
        ClientServices clientServices;
        public PickUpRidesController(ClientServices services)
        {
            clientServices = services;
        }
        public async Task<IActionResult> AddPickUp()
        {
            var loclist = await clientServices.getAllLocations();
            var drvData = await clientServices.getAllDrivers();
            AddPickUpDrop model = new AddPickUpDrop()
            {
                srcList = loclist.Select<LocationDTO, SelectListItem>(l =>
                {
                    return new SelectListItem()
                    {
                        Text = l.locationName,
                        Value = l.locationId.ToString()
                    };
                }).ToList(),
                destList=loclist.Select<LocationDTO,SelectListItem>(d=>
                {
                    return new SelectListItem()
                    {
                        Text = d.locationName,
                        Value = d.locationId.ToString()
                    };
                }).ToList(),
                drvList=drvData.Select<DriverDTO,SelectListItem>(d=>
                {
                    return new SelectListItem()
                    {
                        Text = d.driverName,
                        Value = d.driverId.ToString()
                    };
                }).ToList()
            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ViewPickUp()
        {
            var model = await clientServices.ViewPickUp();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPickUp(AddPickUpDrop data)
        {
            var status = clientServices.AddPickUp(data, HttpContext);
            if(status!=null)
            {
                return RedirectToAction("ViewPickUp","PickUpRides");
            }
            return View();
        }
    }
}
