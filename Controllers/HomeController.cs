using ASPMVC.Data;
using ASPMVC.Models;
using ASPMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPMVC.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db, ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;
        }

		public IActionResult Index()
		{
			List<WeatherModel> weatherList = _db.Weather.ToList();

            IndexViewModel ViewModel = new() { Weather = weatherList };

            return View(ViewModel);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
