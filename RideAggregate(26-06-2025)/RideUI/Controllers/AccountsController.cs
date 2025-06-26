using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using RideUI.DTO;
using System.Security.Claims;
using System.Text.Json;

namespace RideUI.Controllers
{
    public class AccountsController : Controller
    {
        private readonly HttpClient _client;

        public AccountsController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("http://localhost:5067/api/");
        }

        public async Task<IActionResult> ViewUsers()
        {
            HttpResponseMessage msg = await _client.GetAsync("Account");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list=JsonSerializer.Deserialize<GetUserData>(RespString);
            return View(list);
        }

        public async Task<GetUserData> GetUsers()
        {
            try
            {
                HttpResponseMessage msg = await _client.GetAsync("Account");
                msg.EnsureSuccessStatusCode();
                string RespString = await msg.Content.ReadAsStringAsync();
                var list = JsonSerializer.Deserialize<GetUserData>(RespString);
                return list;
            }
            catch (HttpRequestException e)
            {
                // Handle error (e.g., log it, return null, etc.)
                return null;
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUser data)
        {
            GetUserData user = await GetUsers();
            var list =user.data.FirstOrDefault(u => u.email == data.email && u.password == data.password);
            if(list!=null)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, data.email));
                claims.Add(new Claim(ClaimTypes.Role, list.userRole));

                ClaimsIdentity identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);

                HttpContext.Session.SetString("userdata",System.Text.Json.JsonSerializer.Serialize(list));
            }
            if (list.userRole == "customer")
            {
                return RedirectToAction("ViewCustomers", "Customer");
            }
            else if (list.userRole == "driver")
            {
                return RedirectToAction("ViewDriver", "Driver");
            }
            return View();
        }
    }
}
