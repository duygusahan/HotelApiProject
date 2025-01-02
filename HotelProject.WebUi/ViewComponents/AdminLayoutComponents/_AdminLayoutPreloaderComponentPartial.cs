using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUi.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutPreloaderComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
