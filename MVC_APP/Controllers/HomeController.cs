using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Infra;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //BDService _srv;
        IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger,IConfiguration config)//,BDService srv)//Constructor injection
        {
            _logger = logger;
            //_srv = srv;
            _configuration = config;
        }

        public IActionResult Index()
        {
            //return View();//for html type view
            //return Json(new { Name = "swetha", Role = "user" });//for json type view

            //FileStream fs = new FileStream("",FileMode.Open,FileAccess.Read);
            //byte[] fileContent = new byte[fs.Length];
            //fs.Read(fileContent,0,fileContent.Length);
            //fs.Close();
            //return new FileContentResult(fileContent,"");

            //FileStream fs = new FileStream("wwwroot/css/site.css", FileMode.Open, FileAccess.Read);
            //byte[] fileContent = new byte[fs.Length];
            //fs.Read(fileContent, 0, fileContent.Length);
            //fs.Close();
            //return new FileContentResult(fileContent, "application/text");

            //FileStream fs = new FileStream("wwwroot/css/site.css", FileMode.Open, FileAccess.Read);
            //byte[] fileContent = new byte[fs.Length];
            //fs.Read(fileContent, 0, fileContent.Length);
            //fs.Close();
            //return new FileContentResult(fileContent, "application/text");

            //string Res = _srv.GetMessage();
            //ViewBag.Message = Res;

            //string secret=_configuration.GetValue<string>("Logging:LogLevel:Default");//we can get the prdefined configuration as well with multiple keys in order wise
            string secret =_configuration.GetValue<string>("AppKey:Secret");
            ViewBag.Secret = secret;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
