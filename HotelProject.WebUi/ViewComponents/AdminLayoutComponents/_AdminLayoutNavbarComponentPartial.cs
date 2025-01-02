using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUi.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
