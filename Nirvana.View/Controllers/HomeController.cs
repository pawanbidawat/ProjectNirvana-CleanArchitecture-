using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Nirvana.Application.Interfaces;
using Nirvana.Domain.Entity;
using Nirvana.View.Models;
using System.Diagnostics;
using System.Net.Http;

namespace Nirvana.View.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
         
        }

        public async Task<IActionResult> Index()
        {
            var apiUrl = "https://localhost:44396/api/NirvanaApi/GetAllHotelDetails";

            var Client = new HttpClient();
            var response = await Client.GetAsync(apiUrl);

            var data = JsonConvert.DeserializeObject<List<HotelDetailsEntity>>(await response.Content.ReadAsStringAsync());
           

            return View(data);
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
