using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUi.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutScriptsComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
