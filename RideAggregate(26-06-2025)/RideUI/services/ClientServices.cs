using Microsoft.AspNetCore.Mvc;
using RideUI.DTO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace RideUI.services
{
    public class ClientServices
    {
        HttpClient httpClient;
        IConfiguration configuration;
        public ClientServices(HttpClient client,IConfiguration config)
        {
            httpClient = client;
            configuration = config;
            var secValue = config.GetValue<string>("ApiUrl:ClientUrl");
            httpClient.BaseAddress= new Uri(secValue);

        }
        public async Task<GetPickUp> ViewPickUp()
        {
            HttpResponseMessage msg = await httpClient.GetAsync("PickUpRide");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetPickUp>(RespString);
            return list;
        }
        public async Task<List<LocationDTO>> getAllLocations()
        {
            HttpResponseMessage msg = await httpClient.GetAsync("Location");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var locList= JsonSerializer.Deserialize<GetLocation>(RespString);
            return locList.data;
        }
        public async Task<List<DriverDTO>> getAllDrivers()
        {
            HttpResponseMessage msg = await httpClient.GetAsync("Driver");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var drv = JsonSerializer.Deserialize<GetDriver>(RespString);

            return drv.result;
        }
        public async Task<List<PickUpRideDTO>> AddPickUp(AddPickUpDrop data, HttpContext httpContext)
        {
            var sessionData = httpContext.Session.GetString("userdata");
            data.custId = Guid.Parse(sessionData);
            var jsonData = JsonSerializer.Serialize(data);
            var content = new StringContent(jsonData);
            HttpResponseMessage msg = await httpClient.PostAsync("PickUpRide", content);
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var locList = JsonSerializer.Deserialize<GetPickUp>(RespString);
            return locList.result;
        }//doubt
    }
}
