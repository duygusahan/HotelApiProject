using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUi.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
